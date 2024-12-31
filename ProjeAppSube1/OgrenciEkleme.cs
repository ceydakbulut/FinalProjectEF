using Microsoft.EntityFrameworkCore;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace ProjeAppSube1
{

    public partial class OgrenciEkleme : Form
    {
        private AppDbContext dbcontext;

        public OgrenciEkleme()
        {
            InitializeComponent();
            dbcontext = new AppDbContext();
        }
        private void OgrenciEkleme_Load(object sender, EventArgs e)
        {
            using (var dbContext = new AppDbContext())
            {
                var siniflar = dbContext.Siniflar.Select(s => new Sinif { SinifId = s.SinifId, SinifAd = s.SinifAd, }).ToList(); cmbxSinif.DataSource = siniflar;
            }
        }
        private void Kaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAd.Text) ||
                string.IsNullOrEmpty(txtSoyad.Text) ||
                string.IsNullOrEmpty(txtNumara.Text))
            {
                MessageBox.Show("Tüm alanlar zorunludur.");
                return;
            }
            string Ad = txtAd.Text;
            string Soyad = txtSoyad.Text;
            string Numara = txtNumara.Text;
            var seciliSnf = (Sinif)cmbxSinif.SelectedItem;
            int seciliSnfId = seciliSnf.SinifId;

            using (var context = new AppDbContext())
            {
                if (KontenjanDoluluk(seciliSnfId))
                {
                    var ogrenci = new Ogrenci();
                    ogrenci.Numara = Numara;
                    ogrenci.Ad = Ad;
                    ogrenci.Soyad = Soyad;
                    ogrenci.SinifId = seciliSnfId;
                    context.Ogrenciler.Add(ogrenci);
                    context.SaveChanges();

                }
                MessageBox.Show("Kullanýcý baþarýyla kaydedildi.");
            }
        }


        private bool KontenjanDoluluk(int sinifId)
        {
            using (var context = new AppDbContext())
            {
                var sinif = context.Siniflar.FirstOrDefault(s => s.SinifId == sinifId);
                var kontenjanDoluluk = context.Ogrenciler.Count(o => o.SinifId == sinifId);

                return kontenjanDoluluk >= int.Parse(sinif.SinifKontenjan);
            }

        }

        private void Bul_Click(object sender, EventArgs e)
        {
            string numara = txtNumara.Text;

            if (string.IsNullOrEmpty(numara))
            {
                MessageBox.Show("Lütfen bir numara girin.");
                return;
            }

            using (var context = new AppDbContext())
            {
                var ogrenci = context.Ogrenciler.Where(o => o.Numara == numara).Include(o => o.Sinif) // Ýlgili sýnýf bilgisini de getiriyoruz.
                .FirstOrDefault();

                if (ogrenci != null)
                {
                    txtAd.Text = ogrenci.Ad;
                    txtSoyad.Text = ogrenci.Soyad;

                    cmbxSinif.SelectedItem = cmbxSinif.Items
                    .Cast<Sinif>()
                    .FirstOrDefault(s => s.SinifId == ogrenci.SinifId);
                }
                else
                {
                    MessageBox.Show("Öðrenci bulunamadý.");
                }
            }
        }

        private void DersSeç_Click(object sender, EventArgs e)
        {
            string Ad = txtAd.Text;
            string Soyad = txtSoyad.Text;
            string Numara = txtNumara.Text;
            string SinifAdi = cmbxSinif.SelectedItem.ToString();
            DersSeçme dersSecme = new DersSeçme(Ad, Soyad, Numara, SinifAdi);
            dersSecme.Show();
        }


        private void Guncelle_Click_1(object sender, EventArgs e)
        {
            string Numara = txtNumara.Text;

            using (var context = new AppDbContext())
            {
                var ogrenci = context.Ogrenciler.FirstOrDefault(o => o.Numara == Numara);

                if (ogrenci != null) //(boþ deðilse)" anlamýna gelir.
                {
                    ogrenci.Ad = txtAd.Text;
                    ogrenci.Soyad = txtSoyad.Text;


                    context.SaveChanges();

                    MessageBox.Show("Öðrenci bilgileri baþarýyla güncellendi.");
                }

                else
                {
                    MessageBox.Show("Öðrenci bulunamadý.");
                }
            }


        }
    }
}

