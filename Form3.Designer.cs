
namespace Windows_Form_APP
{
    partial class fKayitSil
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
            this.bSil = new System.Windows.Forms.Button();
            this.tKullaniciNO = new System.Windows.Forms.TextBox();
            this.lKullaniciNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bSil
            // 
            this.bSil.Location = new System.Drawing.Point(326, 38);
            this.bSil.Name = "bSil";
            this.bSil.Size = new System.Drawing.Size(107, 30);
            this.bSil.TabIndex = 0;
            this.bSil.Text = "Sil";
            this.bSil.UseVisualStyleBackColor = true;
            this.bSil.Click += new System.EventHandler(this.bSil_Click);
            // 
            // tKullaniciNO
            // 
            this.tKullaniciNO.Location = new System.Drawing.Point(143, 42);
            this.tKullaniciNO.Name = "tKullaniciNO";
            this.tKullaniciNO.Size = new System.Drawing.Size(153, 22);
            this.tKullaniciNO.TabIndex = 1;
            // 
            // lKullaniciNo
            // 
            this.lKullaniciNo.AutoSize = true;
            this.lKullaniciNo.Location = new System.Drawing.Point(44, 45);
            this.lKullaniciNo.Name = "lKullaniciNo";
            this.lKullaniciNo.Size = new System.Drawing.Size(93, 17);
            this.lKullaniciNo.TabIndex = 2;
            this.lKullaniciNo.Text = "Kullanıcı NO :";
            // 
            // fKayitSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 113);
            this.Controls.Add(this.lKullaniciNo);
            this.Controls.Add(this.tKullaniciNO);
            this.Controls.Add(this.bSil);
            this.Name = "fKayitSil";
            this.Text = "Kayıt Sil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fKayitSil_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSil;
        private System.Windows.Forms.TextBox tKullaniciNO;
        private System.Windows.Forms.Label lKullaniciNo;
    }
}