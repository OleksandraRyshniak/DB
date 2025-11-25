using Microsoft.EntityFrameworkCore;

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
            string imagesFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images");
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
            //PuhastaVorm();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
