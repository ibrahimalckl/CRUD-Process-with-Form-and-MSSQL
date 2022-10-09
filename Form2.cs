using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_APP
{
    public partial class fAnaSayfa : Form
    {
        husuEntities db = new husuEntities();

        private void fAnaSayfa_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("No", 50);
            listView1.Columns.Add("Ad", 160);
            listView1.Columns.Add("Soyad", 160);
            listView1.Columns.Add("Bolum", 160);
        }

        public fAnaSayfa()
        {
            InitializeComponent();
        }

        private void fAnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bKayitGoster(object sender, EventArgs e)
        {          
            listView1.Items.Clear();

            husuEntities db = new husuEntities();

            List<Bilgi> gosterilecek = db.Bilgi.ToList();
            
            foreach (Bilgi item in gosterilecek)
            {
                string no = item.KullaniciNO.ToString();
                string ad = item.Adi;
                string soyad = item.Soyadi;
                string bolum = item.Bolum;
                string[] bilgiler = { no, ad, soyad, bolum };
                listView1.Items.Add(new ListViewItem(bilgiler));
            }

            //int kayitsayisi = listView1.Items.Count; 
            
            //if (kayitsayisi > 2)
            //{
            //    bKayitGostr.Enabled = false;
            //}
            //else
            //{
            //    bKayitGostr.Enabled = true;
            //}
        }

        private void bKayitEkle(object sender, EventArgs e)
        {

            if (tAd.Text != null && tAd.Text != "" && tSoyad.Text != null && tSoyad.Text != "" && tBolum.Text != null && tBolum.Text != "")
            {
                Bilgi yeniKayit = new Bilgi();
                yeniKayit.Adi = tAd.Text;
                yeniKayit.Soyadi = tSoyad.Text;
                yeniKayit.Bolum = tBolum.Text;

                db.Bilgi.Add(yeniKayit);
                db.SaveChanges();

                string no = yeniKayit.KullaniciNO.ToString();
                string ad = yeniKayit.Adi;
                string soyad = yeniKayit.Soyadi;
                string bolum = yeniKayit.Bolum;
                string[] bilgiler = { no, ad, soyad, bolum };

                listView1.Items.Add(new ListViewItem(bilgiler));
                MessageBox.Show("Kayit Basariyla Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Dogru Bir Deger Girdinigizden Emin Olunuz!", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void bKayitSayisi_Click(object sender, EventArgs e)
        {
            int kayitSayisi = listView1.Items.Count;
            MessageBox.Show(kayitSayisi + " adet kayit vardir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bKayitSil_Click(object sender, EventArgs e)
        {

            var form3 = Application.OpenForms["fKayitSil"];
            if (form3 == null)
            {
                form3 = new fKayitSil();
            }
            
            form3.Show();         
        }

    }
}

