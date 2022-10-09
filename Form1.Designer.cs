
namespace Windows_Form_APP
{
    partial class fGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.bGiris = new System.Windows.Forms.Button();
            this.tKullaniciAdi = new System.Windows.Forms.TextBox();
            this.tSifre = new System.Windows.Forms.TextBox();
            this.lKullaniciAdi = new System.Windows.Forms.Label();
            this.lSifre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bGiris
            // 
            this.bGiris.Location = new System.Drawing.Point(137, 99);
            this.bGiris.Name = "bGiris";
            this.bGiris.Size = new System.Drawing.Size(82, 27);
            this.bGiris.TabIndex = 0;
            this.bGiris.Text = "Giriş Yap";
            this.bGiris.UseVisualStyleBackColor = true;
            this.bGiris.Click += new System.EventHandler(this.bGiris_Click);
            // 
            // tKullaniciAdi
            // 
            this.tKullaniciAdi.Location = new System.Drawing.Point(137, 23);
            this.tKullaniciAdi.Name = "tKullaniciAdi";
            this.tKullaniciAdi.Size = new System.Drawing.Size(160, 22);
            this.tKullaniciAdi.TabIndex = 1;
            // 
            // tSifre
            // 
            this.tSifre.Location = new System.Drawing.Point(137, 60);
            this.tSifre.Name = "tSifre";
            this.tSifre.PasswordChar = '*';
            this.tSifre.Size = new System.Drawing.Size(160, 22);
            this.tSifre.TabIndex = 2;
            this.tSifre.TextChanged += new System.EventHandler(this.tSifre_TextChanged);
            // 
            // lKullaniciAdi
            // 
            this.lKullaniciAdi.AutoSize = true;
            this.lKullaniciAdi.Location = new System.Drawing.Point(39, 23);
            this.lKullaniciAdi.Name = "lKullaniciAdi";
            this.lKullaniciAdi.Size = new System.Drawing.Size(92, 17);
            this.lKullaniciAdi.TabIndex = 3;
            this.lKullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // lSifre
            // 
            this.lSifre.AutoSize = true;
            this.lSifre.Location = new System.Drawing.Point(86, 60);
            this.lSifre.Name = "lSifre";
            this.lSifre.Size = new System.Drawing.Size(45, 17);
            this.lSifre.TabIndex = 4;
            this.lSifre.Text = "Şifre :";
            // 
            // fGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 141);
            this.Controls.Add(this.lSifre);
            this.Controls.Add(this.lKullaniciAdi);
            this.Controls.Add(this.tSifre);
            this.Controls.Add(this.tKullaniciAdi);
            this.Controls.Add(this.bGiris);
            this.Name = "fGiris";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.fGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bGiris;
        private System.Windows.Forms.TextBox tKullaniciAdi;
        private System.Windows.Forms.TextBox tSifre;
        private System.Windows.Forms.Label lKullaniciAdi;
        private System.Windows.Forms.Label lSifre;
    }
}

