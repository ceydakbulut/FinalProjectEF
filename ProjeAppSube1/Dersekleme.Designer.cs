namespace ProjeAppSube1
{
    partial class Dersekleme
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
            groupBox1 = new GroupBox();
            btnguncelle = new Button();
            btnDersKaydet = new Button();
            textDersAdi = new TextBox();
            textDersKodu = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnguncelle);
            groupBox1.Controls.Add(btnDersKaydet);
            groupBox1.Controls.Add(textDersAdi);
            groupBox1.Controls.Add(textDersKodu);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(196, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(375, 234);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ders Seçme";
            // 
            // btnguncelle
            // 
            btnguncelle.Location = new Point(86, 159);
            btnguncelle.Name = "btnguncelle";
            btnguncelle.Size = new Size(80, 29);
            btnguncelle.TabIndex = 5;
            btnguncelle.Text = "Güncelle";
            btnguncelle.UseVisualStyleBackColor = true;
            btnguncelle.Click += btnguncelle_Click;
            // 
            // btnDersKaydet
            // 
            btnDersKaydet.Location = new Point(201, 159);
            btnDersKaydet.Name = "btnDersKaydet";
            btnDersKaydet.Size = new Size(94, 29);
            btnDersKaydet.TabIndex = 4;
            btnDersKaydet.Text = "Kaydet";
            btnDersKaydet.UseVisualStyleBackColor = true;
            btnDersKaydet.Click += btnDersKaydet_Click;
            // 
            // textDersAdi
            // 
            textDersAdi.Location = new Point(148, 104);
            textDersAdi.Name = "textDersAdi";
            textDersAdi.Size = new Size(125, 27);
            textDersAdi.TabIndex = 3;
            // 
            // textDersKodu
            // 
            textDersKodu.Location = new Point(148, 49);
            textDersKodu.Name = "textDersKodu";
            textDersKodu.Size = new Size(125, 27);
            textDersKodu.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 107);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "Ders Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 56);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Ders Kodu";
            // 
            // Dersekleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Dersekleme";
            Text = "Dersekleme";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnDersKaydet;
        private TextBox textDersAdi;
        private TextBox textDersKodu;
        private Label label2;
        private Label label1;
        private Button btnguncelle;
    }
}