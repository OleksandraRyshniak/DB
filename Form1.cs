using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;

namespace toode
{
    public partial class Form1 : Form
    {
        private ToodeContext _db;
        public Form1()
        {
            InitializeComponent();
            _db = new ToodeContext();
            LaeKategooriad();
            LaeTooded();
            using (var db = new ToodeContext())
            {
                db.Database.EnsureCreated();
            }
            //Update-Database
        }

        private void LaeKategooriad()
        {
            kat_com.DataSource = _db.Kategooriatabel.ToList();
            kat_com.DisplayMember = "Kategooria_nimetus";
            kat_com.ValueMember = "Id";
        }
        private void LaeTooded()
        {
            dataGridView1.DataSource = _db.Tootetabel.Include(t => t.Kategooria).Select(t => new
            {
                t.Id,
                t.Toodenimetus,
                t.Kogus,
                t.Hind,
                Kategooria = t.Kategooria.Kategooria_nimetus,
                t.Pilt,
                t.Lisatud,
                t.KategooriaId

            })
            .ToList();
            if (dataGridView1.Columns["KategooriaId"] != null)
            {
                dataGridView1.Columns["KategooriaId"].Visible = false;
            }
        }

        string valitudPilt;

        private void lisa_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNimetus.Text))
            {
                MessageBox.Show("Toode nimetus on kohustuslik!");
                return;
            }
            var uus = new Toode
            {
                Toodenimetus = txtNimetus.Text,
                Kogus = int.Parse(txtKogus.Text),
                Hind = float.Parse(txtHind.Text),
                KategooriaId = (int)kat_com.SelectedValue,
            };
            string imagesFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "image");
            if (!Directory.Exists(imagesFolder))
                Directory.CreateDirectory(imagesFolder);
            string fileName;
            if (string.IsNullOrEmpty(valitudPilt))
            {
                fileName = "pood.png";
            }
            else
            {
                fileName = Path.GetFileName(valitudPilt);
                string sihtKoht = Path.Combine(imagesFolder, fileName);
                File.Copy(valitudPilt, sihtKoht, true);
            }
            uus.Pilt = fileName;
            _db.Tootetabel.Add(uus);
            _db.SaveChanges();
            LaeTooded();
            PuhastaVorm();

        }
        private void vali_pilt_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Pildi failid|*.jpg;*.jpeg;*.png;*.bmp";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                valitudPilt = dlg.FileName;
                pb.Image = Image.FromFile(valitudPilt);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        private void PuhastaVorm()
        {
            txtNimetus.Clear();
            txtKogus.Clear();
            txtHind.Clear();
            pb.Image = null;
            valitudPilt = null;
        }
        private void uuenda_btn_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
            var toode = _db.Tootetabel.Find(id);

            toode.Toodenimetus = txtNimetus.Text;
            toode.Kogus = int.Parse(txtKogus.Text);
            toode.Hind = float.Parse(txtHind.Text);
            toode.KategooriaId = (int)kat_com.SelectedValue;

            if (valitudPilt != null)
            {
                toode.Pilt = Path.GetFileName(valitudPilt);
                File.Copy(valitudPilt, Path.Combine("image", toode.Pilt), true);
            }

            _db.SaveChanges();
            LaeTooded();
        }
        private void kustuta_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Palun valige kustutatav toode.", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string toodeNimetus = dataGridView1.SelectedRows[0].Cells["Toodenimetus"].Value?.ToString() ?? "valitud toode";
            DialogResult vastus = MessageBox.Show(
                $"Kas olete kindel, et soovite kustutada toote: {toodeNimetus}?",
                "Kustutamise kinnitus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (vastus == DialogResult.Yes)
            {
                try
                {
                    int id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                    var toode = _db.Tootetabel.Find(id);

                    if (toode != null)
                    {
                        _db.Tootetabel.Remove(toode);
                        _db.SaveChanges();
                        LaeTooded();
                        PuhastaVorm();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Kustutamisel tekkis viga: {ex.Message}", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _keelLaetud = false;

            keel_com.Items.Clear();
            keel_com.Items.Add("Eesti");
            keel_com.Items.Add("English");
            string savedLangCode = Properties.Settings.Default.UserLanguage;
            string displayLanguage = "Eesti";

            if (savedLangCode == "en-US")
            {
                displayLanguage = "English";
            }
            else
            {
                displayLanguage = "Eesti";
            }
            keel_com.SelectedItem = displayLanguage;
            _keelLaetud = true;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txtNimetus.Text = row.Cells["Toodenimetus"].Value?.ToString();
            txtKogus.Text = row.Cells["Kogus"].Value?.ToString();
            txtHind.Text = row.Cells["Hind"].Value?.ToString();
            kat_com.SelectedValue = row.Cells["KategooriaId"]?.Value;
            string piltFail = row.Cells["Pilt"].Value?.ToString();
            if (!string.IsNullOrEmpty(piltFail))
            {
                string tee = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", piltFail);
                if (File.Exists(tee))
                    pb.Image = Image.FromFile(tee);
                else
                    pb.Image = null;
            }
            else
            {
                pb.Image = null;
            }
        }

        bool _keelLaetud;

        private void ChangeLanguage(string lang)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(lang);
            var res = new ComponentResourceManager(typeof(Form1));
            ApplyResourcesToControl(this, res);
            res.ApplyResources(this, "$this");
            Properties.Settings.Default.UserLanguage = lang;
            Properties.Settings.Default.Save();

        }
        private void keel_com_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!_keelLaetud)
                return;
            if (keel_com.SelectedItem?.ToString() == "English")
            {
                ChangeLanguage("en-US");
            }
            else 
            {
                ChangeLanguage("et-EE");
            }
        }
        private void ApplyResourcesToControl(Control ctrl, ComponentResourceManager res)
        {
            res.ApplyResources(ctrl, ctrl.Name);
            foreach (Control child in ctrl.Controls)
            {
                ApplyResourcesToControl(child, res);
            }
        }
    }
}
