namespace Muze_Otomasyonu
{
    partial class frmSifreGüncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSifreGüncelle));
            this.txt_YeniSifre = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.txt_Renk = new System.Windows.Forms.TextBox();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Renk = new System.Windows.Forms.Label();
            this.btn_SifreGuncelle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_YeniSifre
            // 
            this.txt_YeniSifre.Location = new System.Drawing.Point(219, 174);
            this.txt_YeniSifre.Multiline = true;
            this.txt_YeniSifre.Name = "txt_YeniSifre";
            this.txt_YeniSifre.Size = new System.Drawing.Size(215, 45);
            this.txt_YeniSifre.TabIndex = 2;
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(219, 110);
            this.txt_Sifre.Multiline = true;
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(215, 45);
            this.txt_Sifre.TabIndex = 1;
            // 
            // txt_Renk
            // 
            this.txt_Renk.Location = new System.Drawing.Point(219, 234);
            this.txt_Renk.Multiline = true;
            this.txt_Renk.Name = "txt_Renk";
            this.txt_Renk.Size = new System.Drawing.Size(215, 44);
            this.txt_Renk.TabIndex = 3;
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Sifre.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_Sifre.Location = new System.Drawing.Point(38, 113);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(81, 28);
            this.lbl_Sifre.TabIndex = 6;
            this.lbl_Sifre.Text = "Şifre : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(38, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Yeni Şifre : ";
            // 
            // lbl_Renk
            // 
            this.lbl_Renk.AutoSize = true;
            this.lbl_Renk.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Renk.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_Renk.Location = new System.Drawing.Point(38, 237);
            this.lbl_Renk.Name = "lbl_Renk";
            this.lbl_Renk.Size = new System.Drawing.Size(161, 56);
            this.lbl_Renk.TabIndex = 8;
            this.lbl_Renk.Text = "En sevdiğiniz \r\nrenk : ";
            // 
            // btn_SifreGuncelle
            // 
            this.btn_SifreGuncelle.BackColor = System.Drawing.SystemColors.Window;
            this.btn_SifreGuncelle.Location = new System.Drawing.Point(219, 301);
            this.btn_SifreGuncelle.Name = "btn_SifreGuncelle";
            this.btn_SifreGuncelle.Size = new System.Drawing.Size(215, 51);
            this.btn_SifreGuncelle.TabIndex = 4;
            this.btn_SifreGuncelle.Text = "GÜNCELLE";
            this.btn_SifreGuncelle.UseVisualStyleBackColor = false;
            this.btn_SifreGuncelle.Click += new System.EventHandler(this.btn_SifreGuncelle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(38, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kullanıcı Adı : ";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(219, 48);
            this.txtKullaniciAdi.Multiline = true;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(215, 45);
            this.txtKullaniciAdi.TabIndex = 0;
            // 
            // frmSifreGüncelle
            // 
            this.AcceptButton = this.btn_SifreGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(474, 401);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.btn_SifreGuncelle);
            this.Controls.Add(this.lbl_Renk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Sifre);
            this.Controls.Add(this.txt_Renk);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_YeniSifre);
            this.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmSifreGüncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Değiştir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_YeniSifre;
        private System.Windows.Forms.TextBox txt_Renk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        public System.Windows.Forms.Label lbl_Sifre;
        public System.Windows.Forms.Label lbl_Renk;
        public System.Windows.Forms.Button btn_SifreGuncelle;
        private System.Windows.Forms.TextBox txt_Sifre;
    }
}