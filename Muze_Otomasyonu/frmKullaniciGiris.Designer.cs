namespace Muze_Otomasyonu
{
    partial class frmKullaniciGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciGirisi));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.chck_SifreGoster = new System.Windows.Forms.CheckBox();
            this.lnkSifreUnuttum = new System.Windows.Forms.LinkLabel();
            this.lnkSifreDegis = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(333, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(86, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı No :";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.SystemColors.Window;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGiris.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGiris.Location = new System.Drawing.Point(93, 228);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(379, 45);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // chck_SifreGoster
            // 
            this.chck_SifreGoster.AutoSize = true;
            this.chck_SifreGoster.BackColor = System.Drawing.Color.Transparent;
            this.chck_SifreGoster.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chck_SifreGoster.ForeColor = System.Drawing.SystemColors.Window;
            this.chck_SifreGoster.Location = new System.Drawing.Point(369, 202);
            this.chck_SifreGoster.Name = "chck_SifreGoster";
            this.chck_SifreGoster.Size = new System.Drawing.Size(103, 20);
            this.chck_SifreGoster.TabIndex = 26;
            this.chck_SifreGoster.Text = "Şifre Göster";
            this.chck_SifreGoster.UseVisualStyleBackColor = false;
            this.chck_SifreGoster.CheckedChanged += new System.EventHandler(this.chck_SifreGoster_CheckedChanged);
            // 
            // lnkSifreUnuttum
            // 
            this.lnkSifreUnuttum.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.lnkSifreUnuttum.AutoSize = true;
            this.lnkSifreUnuttum.BackColor = System.Drawing.Color.Transparent;
            this.lnkSifreUnuttum.Cursor = System.Windows.Forms.Cursors.Default;
            this.lnkSifreUnuttum.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkSifreUnuttum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lnkSifreUnuttum.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkSifreUnuttum.LinkColor = System.Drawing.Color.White;
            this.lnkSifreUnuttum.Location = new System.Drawing.Point(375, 326);
            this.lnkSifreUnuttum.Name = "lnkSifreUnuttum";
            this.lnkSifreUnuttum.Size = new System.Drawing.Size(163, 23);
            this.lnkSifreUnuttum.TabIndex = 27;
            this.lnkSifreUnuttum.TabStop = true;
            this.lnkSifreUnuttum.Text = "Şifremi Unuttum";
            this.lnkSifreUnuttum.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(120)))));
            this.lnkSifreUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSifreUnuttum_LinkClicked);
            // 
            // lnkSifreDegis
            // 
            this.lnkSifreDegis.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.lnkSifreDegis.AutoSize = true;
            this.lnkSifreDegis.BackColor = System.Drawing.Color.Transparent;
            this.lnkSifreDegis.Cursor = System.Windows.Forms.Cursors.Default;
            this.lnkSifreDegis.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkSifreDegis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lnkSifreDegis.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkSifreDegis.LinkColor = System.Drawing.Color.White;
            this.lnkSifreDegis.Location = new System.Drawing.Point(214, 326);
            this.lnkSifreDegis.Name = "lnkSifreDegis";
            this.lnkSifreDegis.Size = new System.Drawing.Size(129, 23);
            this.lnkSifreDegis.TabIndex = 30;
            this.lnkSifreDegis.TabStop = true;
            this.lnkSifreDegis.Text = "Şifre Değiştir";
            this.lnkSifreDegis.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(120)))));
            this.lnkSifreDegis.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSifreDegis_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(349, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 28);
            this.label3.TabIndex = 31;
            this.label3.Text = "|";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.SystemColors.Window;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(93, 91);
            this.txtKullaniciAdi.Multiline = true;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(379, 42);
            this.txtKullaniciAdi.TabIndex = 34;
            this.txtKullaniciAdi.Text = "Kullanıcı Adınızı Giriniz...";
            this.txtKullaniciAdi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtKullaniciAdi_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(428, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciSifre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtKullaniciSifre.Location = new System.Drawing.Point(93, 147);
            this.txtKullaniciSifre.Multiline = true;
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.Size = new System.Drawing.Size(379, 42);
            this.txtKullaniciSifre.TabIndex = 36;
            this.txtKullaniciSifre.Text = "Şifrenizi Giriniz...";
            this.txtKullaniciSifre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtKullaniciSifre_MouseClick_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(428, 149);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(143, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 29);
            this.label4.TabIndex = 38;
            this.label4.Text = "ARKEOLOJİ MÜZESİ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(97, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(430, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 40;
            this.pictureBox4.TabStop = false;
            // 
            // frmKullaniciGirisi
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 374);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtKullaniciSifre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lnkSifreDegis);
            this.Controls.Add(this.lnkSifreUnuttum);
            this.Controls.Add(this.chck_SifreGoster);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKullaniciGirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Girişi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.CheckBox chck_SifreGoster;
        private System.Windows.Forms.LinkLabel lnkSifreUnuttum;
        private System.Windows.Forms.LinkLabel lnkSifreDegis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.TextBox txtKullaniciSifre;
    }
}