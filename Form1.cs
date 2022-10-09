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
    public partial class fGiris : Form
    {
        public fGiris()
        {
            InitializeComponent();
        }
        private void fGiris_Load(object sender, EventArgs e)
        {
            bGiris.Enabled = false;
        }

        private void tSifre_TextChanged(object sender, EventArgs e)
        {
            if (tSifre.Text.Length > 4)
            {
                bGiris.Enabled = true;
            }
            else
            {
                bGiris.Enabled = false;
            }
        }

        private void bGiris_Click(object sender, EventArgs e)
        {

            husuEntities db = new husuEntities();        

            Kullanici_Bilgi karsilastirma = db.Kullanici_Bilgi.Where(x => x.Kullanici_Adi == tKullaniciAdi.Text).SingleOrDefault();
            //Kullanici_Bilgi karsilastirma1 = db.Kullanici_Bilgi.Where(x => x.Sifre == tSifre.Text).SingleOrDefault();
          
                if (karsilastirma != null && karsilastirma.Kullanici_Adi == tKullaniciAdi.Text && karsilastirma.Sifre == tSifre.Text)
                {                 
                    MessageBox.Show("Giris Basarili", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fAnaSayfa form2 = new fAnaSayfa();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Girdiginiz bilgiler hatali", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }                            
        }
        private void fGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }

}
