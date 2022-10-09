
namespace Windows_Form_APP
{
    partial class fAnaSayfa
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
            this.bKayitGostr = new System.Windows.Forms.Button();
            this.bKayitSil = new System.Windows.Forms.Button();
            this.bKayitEkl = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.bKayitSayisi = new System.Windows.Forms.Button();
            this.tBolum = new System.Windows.Forms.TextBox();
            this.tAd = new System.Windows.Forms.TextBox();
            this.tSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bKayitGostr
            // 
            this.bKayitGostr.Location = new System.Drawing.Point(44, 36);
            this.bKayitGostr.Name = "bKayitGostr";
            this.bKayitGostr.Size = new System.Drawing.Size(127, 40);
            this.bKayitGostr.TabIndex = 0;
            this.bKayitGostr.Text = "Kayıtları Göster";
            this.bKayitGostr.UseVisualStyleBackColor = true;
            this.bKayitGostr.Click += new System.EventHandler(this.bKayitGoster);
            // 
            // bKayitSil
            // 
            this.bKayitSil.Location = new System.Drawing.Point(44, 155);
            this.bKayitSil.Name = "bKayitSil";
            this.bKayitSil.Size = new System.Drawing.Size(127, 38);
            this.bKayitSil.TabIndex = 1;
            this.bKayitSil.Text = "Kayıt Sil";
            this.bKayitSil.UseVisualStyleBackColor = true;
            this.bKayitSil.Click += new System.EventHandler(this.bKayitSil_Click);
            // 
            // bKayitEkl
            // 
            this.bKayitEkl.Location = new System.Drawing.Point(869, 416);
            this.bKayitEkl.Name = "bKayitEkl";
            this.bKayitEkl.Size = new System.Drawing.Size(127, 29);
            this.bKayitEkl.TabIndex = 2;
            this.bKayitEkl.Text = "Kayıt Ekle";
            this.bKayitEkl.UseVisualStyleBackColor = true;
            this.bKayitEkl.Click += new System.EventHandler(this.bKayitEkle);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(230, 36);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(766, 356);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // bKayitSayisi
            // 
            this.bKayitSayisi.Location = new System.Drawing.Point(44, 94);
            this.bKayitSayisi.Name = "bKayitSayisi";
            this.bKayitSayisi.Size = new System.Drawing.Size(127, 41);
            this.bKayitSayisi.TabIndex = 6;
            this.bKayitSayisi.Text = "Kayıt Sayısı";
            this.bKayitSayisi.UseVisualStyleBackColor = true;
            this.bKayitSayisi.Click += new System.EventHandler(this.bKayitSayisi_Click);
            // 
            // tBolum
            // 
            this.tBolum.Location = new System.Drawing.Point(652, 419);
            this.tBolum.Name = "tBolum";
            this.tBolum.Size = new System.Drawing.Size(178, 22);
            this.tBolum.TabIndex = 7;
            // 
            // tAd
            // 
            this.tAd.Location = new System.Drawing.Point(100, 419);
            this.tAd.Name = "tAd";
            this.tAd.Size = new System.Drawing.Size(178, 22);
            this.tAd.TabIndex = 10;
            // 
            // tSoyad
            // 
            this.tSoyad.Location = new System.Drawing.Point(379, 419);
            this.tSoyad.Name = "tSoyad";
            this.tSoyad.Size = new System.Drawing.Size(178, 22);
            this.tSoyad.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(591, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Bolum :";
            // 
            // fAnaSayfa
            // 
            this.ClientSize = new System.Drawing.Size(1026, 459);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tSoyad);
            this.Controls.Add(this.tAd);
            this.Controls.Add(this.tBolum);
            this.Controls.Add(this.bKayitSayisi);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.bKayitEkl);
            this.Controls.Add(this.bKayitSil);
            this.Controls.Add(this.bKayitGostr);
            this.Name = "fAnaSayfa";
            this.Text = "Ana Sayfa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fAnaSayfa_FormClosing);
            this.Load += new System.EventHandler(this.fAnaSayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bKayitGostr;
        private System.Windows.Forms.Button bKayitSil;
        private System.Windows.Forms.Button bKayitEkl;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button bKayitSayisi;
        private System.Windows.Forms.TextBox tBolum;
        private System.Windows.Forms.TextBox tAd;
        private System.Windows.Forms.TextBox tSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}