namespace toode
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            kat_com = new ComboBox();
            txtHind = new TextBox();
            txtKogus = new TextBox();
            txtNimetus = new TextBox();
            vali_pilt_btn = new Button();
            kustuta_btn = new Button();
            uuenda_btn = new Button();
            lisa_btn = new Button();
            toode_nim = new Label();
            toode_kogus = new Label();
            toode_hind = new Label();
            kat = new Label();
            pb = new PictureBox();
            keel_com = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // kat_com
            // 
            kat_com.FormattingEnabled = true;
            resources.ApplyResources(kat_com, "kat_com");
            kat_com.Name = "kat_com";
            // 
            // txtHind
            // 
            resources.ApplyResources(txtHind, "txtHind");
            txtHind.Name = "txtHind";
            // 
            // txtKogus
            // 
            resources.ApplyResources(txtKogus, "txtKogus");
            txtKogus.Name = "txtKogus";
            // 
            // txtNimetus
            // 
            resources.ApplyResources(txtNimetus, "txtNimetus");
            txtNimetus.Name = "txtNimetus";
            // 
            // vali_pilt_btn
            // 
            resources.ApplyResources(vali_pilt_btn, "vali_pilt_btn");
            vali_pilt_btn.Name = "vali_pilt_btn";
            vali_pilt_btn.UseVisualStyleBackColor = true;
            vali_pilt_btn.Click += vali_pilt_btn_Click;
            // 
            // kustuta_btn
            // 
            resources.ApplyResources(kustuta_btn, "kustuta_btn");
            kustuta_btn.Name = "kustuta_btn";
            kustuta_btn.UseVisualStyleBackColor = true;
            kustuta_btn.Click += kustuta_btn_Click;
            // 
            // uuenda_btn
            // 
            resources.ApplyResources(uuenda_btn, "uuenda_btn");
            uuenda_btn.Name = "uuenda_btn";
            uuenda_btn.UseVisualStyleBackColor = true;
            uuenda_btn.Click += uuenda_btn_Click;
            // 
            // lisa_btn
            // 
            resources.ApplyResources(lisa_btn, "lisa_btn");
            lisa_btn.Name = "lisa_btn";
            lisa_btn.UseVisualStyleBackColor = true;
            lisa_btn.Click += lisa_btn_Click;
            // 
            // toode_nim
            // 
            resources.ApplyResources(toode_nim, "toode_nim");
            toode_nim.Name = "toode_nim";
            // 
            // toode_kogus
            // 
            resources.ApplyResources(toode_kogus, "toode_kogus");
            toode_kogus.Name = "toode_kogus";
            // 
            // toode_hind
            // 
            resources.ApplyResources(toode_hind, "toode_hind");
            toode_hind.Name = "toode_hind";
            // 
            // kat
            // 
            resources.ApplyResources(kat, "kat");
            kat.Name = "kat";
            // 
            // pb
            // 
            resources.ApplyResources(pb, "pb");
            pb.Name = "pb";
            pb.TabStop = false;
            // 
            // keel_com
            // 
            keel_com.FormattingEnabled = true;
            resources.ApplyResources(keel_com, "keel_com");
            keel_com.Name = "keel_com";
            keel_com.SelectedIndexChanged += keel_com_SelectedIndexChanged;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(keel_com);
            Controls.Add(pb);
            Controls.Add(kat);
            Controls.Add(toode_hind);
            Controls.Add(toode_kogus);
            Controls.Add(toode_nim);
            Controls.Add(lisa_btn);
            Controls.Add(uuenda_btn);
            Controls.Add(kustuta_btn);
            Controls.Add(vali_pilt_btn);
            Controls.Add(txtNimetus);
            Controls.Add(txtKogus);
            Controls.Add(txtHind);
            Controls.Add(kat_com);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox kat_com;
        private TextBox txtHind;
        private TextBox txtKogus;
        private TextBox txtNimetus;
        private Button vali_pilt_btn;
        private Button kustuta_btn;
        private Button uuenda_btn;
        private Button lisa_btn;
        private Label toode_nim;
        private Label toode_kogus;
        private Label toode_hind;
        private Label kat;
        private PictureBox pb;
        private ComboBox keel_com;
    }
}
