using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeAppSube1
{
    public partial class Dersekleme : Form
    {
        public Dersekleme()
        {
            InitializeComponent();
        }

        private void btnDersKaydet_Click(object sender, EventArgs e)
        {
            if (textDersAdi.Text == String.Empty || textDersKodu.Text == String.Empty)
            {
                MessageBox.Show("Tüm alanlar zorunludur.");
                return;
            }
            string DersAdi = textDersAdi.Text;
            string DersKodu = textDersKodu.Text;

            using (var context = new AppDbContext())
            {
                try
                {
                    var drs = new Ders();
                    drs.DersAd = DersAdi;
                    drs.DersKod = DersKodu;

                    context.Dersler.Add(drs);
                    context.SaveChanges();

                    MessageBox.Show("Ders başarıyla kaydedildi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
