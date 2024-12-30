namespace ProjeAppSube1
{
    partial class OgrenciEkleme
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
            groupBox1 = new GroupBox();
            DersSeç = new Button();
            Bul = new Button();
            Kaydet = new Button();
            Guncelle = new Button();
            cmbxSinif = new ComboBox();
            txtNumara = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DersSeç);
            groupBox1.Controls.Add(Bul);
            groupBox1.Controls.Add(Kaydet);
            groupBox1.Controls.Add(Guncelle);
            groupBox1.Controls.Add(cmbxSinif);
            groupBox1.Controls.Add(txtNumara);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(151, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(434, 417);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci ekleme";
            // 
            // DersSeç
            // 
            DersSeç.Location = new Point(170, 351);
            DersSeç.Name = "DersSeç";
            DersSeç.Size = new Size(120, 29);
            DersSeç.TabIndex = 13;
            DersSeç.Text = "Ders Seçimi";
            DersSeç.UseVisualStyleBackColor = true;
            DersSeç.Click += DersSeç_Click;
            // 
            // Bul
            // 
            Bul.Location = new Point(309, 300);
            Bul.Name = "Bul";
            Bul.Size = new Size(94, 29);
            Bul.TabIndex = 12;
            Bul.Text = "Bul";
            Bul.UseVisualStyleBackColor = true;
            Bul.Click += Bul_Click;
            // 
            // Kaydet
            // 
            Kaydet.Location = new Point(180, 300);
            Kaydet.Name = "Kaydet";
            Kaydet.Size = new Size(94, 29);
            Kaydet.TabIndex = 11;
            Kaydet.Text = "Kaydet";
            Kaydet.UseVisualStyleBackColor = true;
            Kaydet.Click += Kaydet_Click;
            // 
            // Guncelle
            // 
            Guncelle.Location = new Point(46, 300);
            Guncelle.Name = "Guncelle";
            Guncelle.Size = new Size(94, 29);
            Guncelle.TabIndex = 10;
            Guncelle.Text = "Güncelle";
            Guncelle.UseVisualStyleBackColor = true;
            Guncelle.Click += Guncelle_Click_1;
            // 
            // cmbxSinif
            // 
            cmbxSinif.FormattingEnabled = true;
            cmbxSinif.Location = new Point(206, 232);
            cmbxSinif.Name = "cmbxSinif";
            cmbxSinif.Size = new Size(123, 28);
            cmbxSinif.TabIndex = 9;
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(206, 183);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(125, 27);
            txtNumara.TabIndex = 8;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(206, 140);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(123, 27);
            txtSoyad.TabIndex = 7;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(206, 90);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(90, 240);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 4;
            label5.Text = "Sınıf seçiniz";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 190);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 3;
            label4.Text = "Numara";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 143);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 93);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 1;
            label2.Text = "Ad";
            // 
            // OgrenciEkleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 578);
            Controls.Add(groupBox1);
            Name = "OgrenciEkleme";
            Text = "Form1";
            Load += OgrenciEkleme_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbxSinif;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button DersSeç;
        private Button Bul;
        private Button Kaydet;
        private Button Guncelle;
        private TextBox txtNumara;
        private TextBox txtSoyad;
        private TextBox txtAd;
    }
}