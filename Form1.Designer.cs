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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(71, 283);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(759, 245);
            dataGridView1.TabIndex = 0;
            // 
            // kat_com
            // 
            kat_com.FormattingEnabled = true;
            kat_com.Location = new Point(203, 181);
            kat_com.Margin = new Padding(3, 4, 3, 4);
            kat_com.Name = "kat_com";
            kat_com.Size = new Size(150, 28);
            kat_com.TabIndex = 1;
            // 
            // txtHind
            // 
            txtHind.Location = new Point(203, 46);
            txtHind.Margin = new Padding(3, 4, 3, 4);
            txtHind.Name = "txtHind";
            txtHind.Size = new Size(150, 27);
            txtHind.TabIndex = 2;
            // 
            // txtKogus
            // 
            txtKogus.Location = new Point(203, 137);
            txtKogus.Margin = new Padding(3, 4, 3, 4);
            txtKogus.Name = "txtKogus";
            txtKogus.Size = new Size(150, 27);
            txtKogus.TabIndex = 3;
            // 
            // txtNimetus
            // 
            txtNimetus.Location = new Point(203, 91);
            txtNimetus.Margin = new Padding(3, 4, 3, 4);
            txtNimetus.Name = "txtNimetus";
            txtNimetus.Size = new Size(150, 27);
            txtNimetus.TabIndex = 4;
            // 
            // vali_pilt_btn
            // 
            vali_pilt_btn.Location = new Point(430, 228);
            vali_pilt_btn.Name = "vali_pilt_btn";
            vali_pilt_btn.Size = new Size(94, 29);
            vali_pilt_btn.TabIndex = 5;
            vali_pilt_btn.Text = "Vali pilt";
            vali_pilt_btn.UseVisualStyleBackColor = true;
            // 
            // kustuta_btn
            // 
            kustuta_btn.Location = new Point(171, 228);
            kustuta_btn.Name = "kustuta_btn";
            kustuta_btn.Size = new Size(94, 29);
            kustuta_btn.TabIndex = 6;
            kustuta_btn.Text = "Kustuta";
            kustuta_btn.UseVisualStyleBackColor = true;
            // 
            // uuenda_btn
            // 
            uuenda_btn.Location = new Point(271, 228);
            uuenda_btn.Name = "uuenda_btn";
            uuenda_btn.Size = new Size(94, 29);
            uuenda_btn.TabIndex = 7;
            uuenda_btn.Text = "Uuenda";
            uuenda_btn.UseVisualStyleBackColor = true;
            // 
            // lisa_btn
            // 
            lisa_btn.Location = new Point(71, 228);
            lisa_btn.Name = "lisa_btn";
            lisa_btn.Size = new Size(94, 29);
            lisa_btn.TabIndex = 8;
            lisa_btn.Text = "Lisa";
            lisa_btn.UseVisualStyleBackColor = true;
            lisa_btn.Click += lisa_btn_Click;
            // 
            // toode_nim
            // 
            toode_nim.AutoSize = true;
            toode_nim.Location = new Point(71, 53);
            toode_nim.Name = "toode_nim";
            toode_nim.Size = new Size(107, 20);
            toode_nim.TabIndex = 9;
            toode_nim.Text = "Toode nimetus";
            // 
            // toode_kogus
            // 
            toode_kogus.AutoSize = true;
            toode_kogus.Location = new Point(71, 98);
            toode_kogus.Name = "toode_kogus";
            toode_kogus.Size = new Size(94, 20);
            toode_kogus.TabIndex = 10;
            toode_kogus.Text = "Toode kogus";
            // 
            // toode_hind
            // 
            toode_hind.AutoSize = true;
            toode_hind.Location = new Point(71, 144);
            toode_hind.Name = "toode_hind";
            toode_hind.Size = new Size(84, 20);
            toode_hind.TabIndex = 11;
            toode_hind.Text = "Toode hind";
            // 
            // kat
            // 
            kat.AutoSize = true;
            kat.Location = new Point(71, 181);
            kat.Name = "kat";
            kat.Size = new Size(83, 20);
            kat.TabIndex = 12;
            kat.Text = "Kategooria";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(430, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 175);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox1);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}
