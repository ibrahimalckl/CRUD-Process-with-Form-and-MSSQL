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
    public partial class fKayitSil : Form
    {
        husuEntities db = new husuEntities();

        public fKayitSil()
        {
            InitializeComponent();
        }
        
        private void bSil_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    int secilen = int.Parse(tKullaniciNO.Text);
            //}
            //catch (FormatException hata2)
            //{
            //    tKullaniciNO.Text = "Hatali Turde Veri Girdiniz";
            //    this.Close();
            //}

            Bilgi okunacak = db.Bilgi.Where(x => x.KullaniciNO.ToString() == tKullaniciNO.Text).SingleOrDefault();
            
            if (okunacak != null)
            {
                if (MessageBox.Show(okunacak.Adi + " " + okunacak.Soyadi + " " + okunacak.Bolum + " silinecek. Onayliyor musunuz?", "Bilgilendirme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    //foreach (ListViewItem item in listView1.SelectedItems)
                    //{
                    //    item.Remove();
                    //}

                    db.Bilgi.Remove(okunacak);

                    MessageBox.Show("Kayit basariyla silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.SaveChanges();                 
  
                }
                else
                {
                    MessageBox.Show("Silme islemi iptal edilmistir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (okunacak == null)
            {
                MessageBox.Show("Dogru Bir Deger Girdinigizden Emin Olunuz!", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }              
                     
        }

        private void fKayitSil_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form2 = Application.OpenForms["fAnaSayfa"];

            form2 = new fAnaSayfa();          
            form2.Refresh();     
        }
    }
}
