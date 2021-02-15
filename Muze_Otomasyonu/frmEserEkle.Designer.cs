namespace Muze_Otomasyonu
{
    partial class frmEserEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEserEkle));
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_eserListesi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_cikar = new System.Windows.Forms.Button();
            this.dt_eserListesi = new System.Windows.Forms.DataGridView();
            this.EserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnvanterNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KaziNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EserAdiCinsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BulunduguYer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cagi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Olcusu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GelisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GelisSekli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EserTanimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pctr_eserTemizle = new System.Windows.Forms.PictureBox();
            this.txt_envanter = new System.Windows.Forms.TextBox();
            this.txt_kazi = new System.Windows.Forms.TextBox();
            this.txt_eserAdi = new System.Windows.Forms.TextBox();
            this.txt_bulunduguYer = new System.Windows.Forms.TextBox();
            this.txt_cag = new System.Windows.Forms.TextBox();
            this.txt_eserOlcusu = new System.Windows.Forms.TextBox();
            this.txt_gelisSekli = new System.Windows.Forms.TextBox();
            this.rch_erserTanimi = new System.Windows.Forms.RichTextBox();
            this.msk_eserTarih = new System.Windows.Forms.MaskedTextBox();
            this.txt_eserId = new System.Windows.Forms.TextBox();
            this.lblEserId = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dt_eserListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctr_eserTemizle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.SystemColors.Window;
            this.btn_ekle.Location = new System.Drawing.Point(17, 568);
            this.btn_ekle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(186, 49);
            this.btn_ekle.TabIndex = 0;
            this.btn_ekle.Text = "Eser Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_eserListesi
            // 
            this.btn_eserListesi.BackColor = System.Drawing.SystemColors.Window;
            this.btn_eserListesi.Location = new System.Drawing.Point(429, 568);
            this.btn_eserListesi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_eserListesi.Name = "btn_eserListesi";
            this.btn_eserListesi.Size = new System.Drawing.Size(186, 49);
            this.btn_eserListesi.TabIndex = 1;
            this.btn_eserListesi.Text = "ESER LİSTESİ";
            this.btn_eserListesi.UseVisualStyleBackColor = false;
            this.btn_eserListesi.Click += new System.EventHandler(this.btn_eserListesi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(83, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Envanter No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(83, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kazı No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(83, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Eser Adı / Cinsi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(83, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bulunduğu Yer :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(83, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Çağı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(83, 488);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Eserin Tanımı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(83, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ölçüsü :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(83, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "Müzeye Geldiği Tarih :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(83, 440);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "Müzeye Geliş Şekli :";
            // 
            // btn_cikar
            // 
            this.btn_cikar.BackColor = System.Drawing.SystemColors.Window;
            this.btn_cikar.Location = new System.Drawing.Point(226, 568);
            this.btn_cikar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cikar.Name = "btn_cikar";
            this.btn_cikar.Size = new System.Drawing.Size(186, 49);
            this.btn_cikar.TabIndex = 11;
            this.btn_cikar.Text = "Eser Çıkar";
            this.btn_cikar.UseVisualStyleBackColor = false;
            this.btn_cikar.Click += new System.EventHandler(this.btn_cikar_Click);
            // 
            // dt_eserListesi
            // 
            this.dt_eserListesi.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dt_eserListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_eserListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EserId,
            this.EnvanterNo,
            this.KaziNo,
            this.EserAdiCinsi,
            this.BulunduguYer,
            this.Cagi,
            this.Olcusu,
            this.GelisTarihi,
            this.GelisSekli,
            this.EserTanimi});
            this.dt_eserListesi.Location = new System.Drawing.Point(642, 50);
            this.dt_eserListesi.Name = "dt_eserListesi";
            this.dt_eserListesi.RowTemplate.Height = 24;
            this.dt_eserListesi.Size = new System.Drawing.Size(599, 447);
            this.dt_eserListesi.TabIndex = 12;
            this.dt_eserListesi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_eserListesi_CellDoubleClick);
            // 
            // EserId
            // 
            this.EserId.DataPropertyName = "EserId";
            this.EserId.HeaderText = "Eser Id";
            this.EserId.Name = "EserId";
            // 
            // EnvanterNo
            // 
            this.EnvanterNo.DataPropertyName = "EnvanterNo";
            this.EnvanterNo.HeaderText = "Envanter No";
            this.EnvanterNo.Name = "EnvanterNo";
            // 
            // KaziNo
            // 
            this.KaziNo.DataPropertyName = "KaziNo";
            this.KaziNo.HeaderText = "Kazı No";
            this.KaziNo.Name = "KaziNo";
            // 
            // EserAdiCinsi
            // 
            this.EserAdiCinsi.DataPropertyName = "EserAdiCinsi";
            this.EserAdiCinsi.HeaderText = "Eser Adı / Cinsi";
            this.EserAdiCinsi.Name = "EserAdiCinsi";
            // 
            // BulunduguYer
            // 
            this.BulunduguYer.DataPropertyName = "BulunduguYer";
            this.BulunduguYer.HeaderText = "Bulunduğu Yer";
            this.BulunduguYer.Name = "BulunduguYer";
            // 
            // Cagi
            // 
            this.Cagi.DataPropertyName = "Cagi";
            this.Cagi.HeaderText = "Çağı";
            this.Cagi.Name = "Cagi";
            // 
            // Olcusu
            // 
            this.Olcusu.DataPropertyName = "Olcusu";
            this.Olcusu.HeaderText = "Ölçüsü";
            this.Olcusu.Name = "Olcusu";
            // 
            // GelisTarihi
            // 
            this.GelisTarihi.DataPropertyName = "GelisTarihi";
            this.GelisTarihi.HeaderText = "Geliş Tarihi";
            this.GelisTarihi.Name = "GelisTarihi";
            // 
            // GelisSekli
            // 
            this.GelisSekli.DataPropertyName = "GelisSekli";
            this.GelisSekli.HeaderText = "Geliş Şekli";
            this.GelisSekli.Name = "GelisSekli";
            // 
            // EserTanimi
            // 
            this.EserTanimi.DataPropertyName = "EserTanimi";
            this.EserTanimi.HeaderText = "Eser Tanımı";
            this.EserTanimi.Name = "EserTanimi";
            // 
            // pctr_eserTemizle
            // 
            this.pctr_eserTemizle.BackColor = System.Drawing.Color.Transparent;
            this.pctr_eserTemizle.Image = ((System.Drawing.Image)(resources.GetObject("pctr_eserTemizle.Image")));
            this.pctr_eserTemizle.Location = new System.Drawing.Point(642, 517);
            this.pctr_eserTemizle.Name = "pctr_eserTemizle";
            this.pctr_eserTemizle.Size = new System.Drawing.Size(62, 54);
            this.pctr_eserTemizle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctr_eserTemizle.TabIndex = 72;
            this.pctr_eserTemizle.TabStop = false;
            this.pctr_eserTemizle.Click += new System.EventHandler(this.pctr_eserTemizle_Click);
            // 
            // txt_envanter
            // 
            this.txt_envanter.Location = new System.Drawing.Point(306, 60);
            this.txt_envanter.Name = "txt_envanter";
            this.txt_envanter.Size = new System.Drawing.Size(242, 31);
            this.txt_envanter.TabIndex = 73;
            // 
            // txt_kazi
            // 
            this.txt_kazi.Location = new System.Drawing.Point(306, 115);
            this.txt_kazi.Name = "txt_kazi";
            this.txt_kazi.Size = new System.Drawing.Size(242, 31);
            this.txt_kazi.TabIndex = 74;
            // 
            // txt_eserAdi
            // 
            this.txt_eserAdi.Location = new System.Drawing.Point(306, 167);
            this.txt_eserAdi.Name = "txt_eserAdi";
            this.txt_eserAdi.Size = new System.Drawing.Size(242, 31);
            this.txt_eserAdi.TabIndex = 75;
            // 
            // txt_bulunduguYer
            // 
            this.txt_bulunduguYer.Location = new System.Drawing.Point(306, 224);
            this.txt_bulunduguYer.Name = "txt_bulunduguYer";
            this.txt_bulunduguYer.Size = new System.Drawing.Size(242, 31);
            this.txt_bulunduguYer.TabIndex = 76;
            // 
            // txt_cag
            // 
            this.txt_cag.Location = new System.Drawing.Point(306, 280);
            this.txt_cag.Name = "txt_cag";
            this.txt_cag.Size = new System.Drawing.Size(242, 31);
            this.txt_cag.TabIndex = 77;
            // 
            // txt_eserOlcusu
            // 
            this.txt_eserOlcusu.Location = new System.Drawing.Point(306, 335);
            this.txt_eserOlcusu.Name = "txt_eserOlcusu";
            this.txt_eserOlcusu.Size = new System.Drawing.Size(242, 31);
            this.txt_eserOlcusu.TabIndex = 78;
            // 
            // txt_gelisSekli
            // 
            this.txt_gelisSekli.Location = new System.Drawing.Point(306, 437);
            this.txt_gelisSekli.Name = "txt_gelisSekli";
            this.txt_gelisSekli.Size = new System.Drawing.Size(242, 31);
            this.txt_gelisSekli.TabIndex = 79;
            // 
            // rch_erserTanimi
            // 
            this.rch_erserTanimi.Location = new System.Drawing.Point(306, 485);
            this.rch_erserTanimi.Name = "rch_erserTanimi";
            this.rch_erserTanimi.Size = new System.Drawing.Size(242, 67);
            this.rch_erserTanimi.TabIndex = 81;
            this.rch_erserTanimi.Text = "";
            // 
            // msk_eserTarih
            // 
            this.msk_eserTarih.Location = new System.Drawing.Point(306, 385);
            this.msk_eserTarih.Mask = "00/00/0000";
            this.msk_eserTarih.Name = "msk_eserTarih";
            this.msk_eserTarih.Size = new System.Drawing.Size(242, 31);
            this.msk_eserTarih.TabIndex = 82;
            this.msk_eserTarih.ValidatingType = typeof(System.DateTime);
            // 
            // txt_eserId
            // 
            this.txt_eserId.Location = new System.Drawing.Point(306, 6);
            this.txt_eserId.Name = "txt_eserId";
            this.txt_eserId.Size = new System.Drawing.Size(242, 31);
            this.txt_eserId.TabIndex = 84;
            this.txt_eserId.Visible = false;
            // 
            // lblEserId
            // 
            this.lblEserId.AutoSize = true;
            this.lblEserId.BackColor = System.Drawing.Color.Transparent;
            this.lblEserId.ForeColor = System.Drawing.SystemColors.Window;
            this.lblEserId.Location = new System.Drawing.Point(83, 9);
            this.lblEserId.Name = "lblEserId";
            this.lblEserId.Size = new System.Drawing.Size(84, 23);
            this.lblEserId.TabIndex = 83;
            this.lblEserId.Text = "Eser Id :";
            this.lblEserId.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1193, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmEserEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(628, 635);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_eserId);
            this.Controls.Add(this.lblEserId);
            this.Controls.Add(this.msk_eserTarih);
            this.Controls.Add(this.rch_erserTanimi);
            this.Controls.Add(this.txt_gelisSekli);
            this.Controls.Add(this.txt_eserOlcusu);
            this.Controls.Add(this.txt_cag);
            this.Controls.Add(this.txt_bulunduguYer);
            this.Controls.Add(this.txt_eserAdi);
            this.Controls.Add(this.txt_kazi);
            this.Controls.Add(this.txt_envanter);
            this.Controls.Add(this.pctr_eserTemizle);
            this.Controls.Add(this.dt_eserListesi);
            this.Controls.Add(this.btn_cikar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_eserListesi);
            this.Controls.Add(this.btn_ekle);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEserEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eser Kayıt";
            ((System.ComponentModel.ISupportInitialize)(this.dt_eserListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctr_eserTemizle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_eserListesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_cikar;
        private System.Windows.Forms.DataGridView dt_eserListesi;
        private System.Windows.Forms.PictureBox pctr_eserTemizle;
        private System.Windows.Forms.TextBox txt_envanter;
        private System.Windows.Forms.TextBox txt_kazi;
        private System.Windows.Forms.TextBox txt_eserAdi;
        private System.Windows.Forms.TextBox txt_bulunduguYer;
        private System.Windows.Forms.TextBox txt_cag;
        private System.Windows.Forms.TextBox txt_eserOlcusu;
        private System.Windows.Forms.TextBox txt_gelisSekli;
        private System.Windows.Forms.RichTextBox rch_erserTanimi;
        private System.Windows.Forms.MaskedTextBox msk_eserTarih;
        private System.Windows.Forms.TextBox txt_eserId;
        private System.Windows.Forms.Label lblEserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnvanterNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn KaziNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EserAdiCinsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn BulunduguYer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cagi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Olcusu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GelisTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GelisSekli;
        private System.Windows.Forms.DataGridViewTextBoxColumn EserTanimi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}