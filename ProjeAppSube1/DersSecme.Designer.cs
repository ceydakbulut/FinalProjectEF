namespace ProjeAppSube1
{
    partial class DersSeçme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblOgrenciBilgileri = new Label();
            dataGridView1 = new DataGridView();
            btnKaydet = new Button();
            lblSecilenDersler = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblOgrenciBilgileri
            // 
            lblOgrenciBilgileri.AutoSize = true;
            lblOgrenciBilgileri.Location = new Point(333, 34);
            lblOgrenciBilgileri.Name = "lblOgrenciBilgileri";
            lblOgrenciBilgileri.Size = new Size(50, 20);
            lblOgrenciBilgileri.TabIndex = 0;
            lblOgrenciBilgileri.Text = "label1";
            lblOgrenciBilgileri.UseWaitCursor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(145, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(500, 227);
            dataGridView1.TabIndex = 1;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(539, 360);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(106, 36);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lblSecilenDersler
            // 
            lblSecilenDersler.AutoSize = true;
            lblSecilenDersler.Location = new Point(265, 368);
            lblSecilenDersler.Name = "lblSecilenDersler";
            lblSecilenDersler.Size = new Size(42, 20);
            lblSecilenDersler.TabIndex = 3;
            lblSecilenDersler.Text = "label";
            // 
            // DersSeçme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSecilenDersler);
            Controls.Add(btnKaydet);
            Controls.Add(dataGridView1);
            Controls.Add(lblOgrenciBilgileri);
            Name = "DersSeçme";
            Text = "DersSeçme";
            Load += DersSeçme_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOgrenciBilgileri;
        private DataGridView dataGridView1;
        private Button btnKaydet;
        private Label lblSecilenDersler;
    }
}