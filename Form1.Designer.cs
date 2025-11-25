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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(62, 212);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(664, 184);
            dataGridView1.TabIndex = 0;
            // 
            // kat_com
            // 
            kat_com.FormattingEnabled = true;
            kat_com.Location = new Point(71, 97);
            kat_com.Name = "kat_com";
            kat_com.Size = new Size(88, 23);
            kat_com.TabIndex = 1;
            // 
            // txtHind
            // 
            txtHind.Location = new Point(240, 114);
            txtHind.Name = "txtHind";
            txtHind.Size = new Size(100, 23);
            txtHind.TabIndex = 2;
            // 
            // txtKogus
            // 
            txtKogus.Location = new Point(356, 160);
            txtKogus.Name = "txtKogus";
            txtKogus.Size = new Size(100, 23);
            txtKogus.TabIndex = 3;
            // 
            // txtNimetus
            // 
            txtNimetus.Location = new Point(366, 63);
            txtNimetus.Name = "txtNimetus";
            txtNimetus.Size = new Size(100, 23);
            txtNimetus.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNimetus);
            Controls.Add(txtKogus);
            Controls.Add(txtHind);
            Controls.Add(kat_com);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox kat_com;
        private TextBox txtHind;
        private TextBox txtKogus;
        private TextBox txtNimetus;
    }
}
