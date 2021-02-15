namespace Muze_Otomasyonu
{
    partial class frmOdeme
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdeme));
            this.btnOdemeYap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mskKartNo = new System.Windows.Forms.MaskedTextBox();
            this.mskAy = new System.Windows.Forms.MaskedTextBox();
            this.mskYıl = new System.Windows.Forms.MaskedTextBox();
            this.txtOdeme = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskCVC = new System.Windows.Forms.MaskedTextBox();
            this.lblAdi = new System.Windows.Forms.Label();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_Odeme = new System.Windows.Forms.Panel();
            this.pctr_Odeme = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_Odeme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctr_Odeme)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOdemeYap.BackgroundImage")));
            this.btnOdemeYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOdemeYap.Location = new System.Drawing.Point(229, 246);
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(255, 46);
            this.btnOdemeYap.TabIndex = 0;
            this.btnOdemeYap.UseVisualStyleBackColor = true;
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı Soyadı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kart Numarası :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(15, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Son Kullanım Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(15, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ödenecek Tutar :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(264, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "/";
            // 
            // mskKartNo
            // 
            this.mskKartNo.Location = new System.Drawing.Point(229, 65);
            this.mskKartNo.Mask = "TR0000-0000-0000-00000000-0000";
            this.mskKartNo.Name = "mskKartNo";
            this.mskKartNo.Size = new System.Drawing.Size(255, 31);
            this.mskKartNo.TabIndex = 10;
            // 
            // mskAy
            // 
            this.mskAy.Location = new System.Drawing.Point(229, 107);
            this.mskAy.Mask = "00";
            this.mskAy.Name = "mskAy";
            this.mskAy.Size = new System.Drawing.Size(34, 31);
            this.mskAy.TabIndex = 12;
            // 
            // mskYıl
            // 
            this.mskYıl.Location = new System.Drawing.Point(285, 107);
            this.mskYıl.Mask = "00";
            this.mskYıl.Name = "mskYıl";
            this.mskYıl.Size = new System.Drawing.Size(34, 31);
            this.mskYıl.TabIndex = 13;
            // 
            // txtOdeme
            // 
            this.txtOdeme.Location = new System.Drawing.Point(229, 192);
            this.txtOdeme.Name = "txtOdeme";
            this.txtOdeme.Size = new System.Drawing.Size(95, 31);
            this.txtOdeme.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(15, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Güvenlik Kodu / CVC :";
            // 
            // mskCVC
            // 
            this.mskCVC.Location = new System.Drawing.Point(229, 148);
            this.mskCVC.Mask = "*00";
            this.mskCVC.Name = "mskCVC";
            this.mskCVC.Size = new System.Drawing.Size(43, 31);
            this.mskCVC.TabIndex = 16;
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblAdi.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAdi.Location = new System.Drawing.Point(225, 29);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(70, 23);
            this.lblAdi.TabIndex = 17;
            this.lblAdi.Text = "............";
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.AutoSize = true;
            this.lblSoyadi.BackColor = System.Drawing.Color.Transparent;
            this.lblSoyadi.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSoyadi.Location = new System.Drawing.Point(304, 29);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(70, 23);
            this.lblSoyadi.TabIndex = 18;
            this.lblSoyadi.Text = "............";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(375, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_Odeme
            // 
            this.pnl_Odeme.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Odeme.Controls.Add(this.mskKartNo);
            this.pnl_Odeme.Controls.Add(this.pictureBox1);
            this.pnl_Odeme.Controls.Add(this.btnOdemeYap);
            this.pnl_Odeme.Controls.Add(this.lblSoyadi);
            this.pnl_Odeme.Controls.Add(this.label1);
            this.pnl_Odeme.Controls.Add(this.lblAdi);
            this.pnl_Odeme.Controls.Add(this.label2);
            this.pnl_Odeme.Controls.Add(this.mskCVC);
            this.pnl_Odeme.Controls.Add(this.label3);
            this.pnl_Odeme.Controls.Add(this.txtOdeme);
            this.pnl_Odeme.Controls.Add(this.label4);
            this.pnl_Odeme.Controls.Add(this.label6);
            this.pnl_Odeme.Controls.Add(this.label5);
            this.pnl_Odeme.Controls.Add(this.mskYıl);
            this.pnl_Odeme.Controls.Add(this.mskAy);
            this.pnl_Odeme.Location = new System.Drawing.Point(-3, 70);
            this.pnl_Odeme.Name = "pnl_Odeme";
            this.pnl_Odeme.Size = new System.Drawing.Size(505, 322);
            this.pnl_Odeme.TabIndex = 20;
            // 
            // pctr_Odeme
            // 
            this.pctr_Odeme.BackColor = System.Drawing.Color.Transparent;
            this.pctr_Odeme.Image = ((System.Drawing.Image)(resources.GetObject("pctr_Odeme.Image")));
            this.pctr_Odeme.Location = new System.Drawing.Point(557, -4);
            this.pctr_Odeme.Name = "pctr_Odeme";
            this.pctr_Odeme.Size = new System.Drawing.Size(526, 413);
            this.pctr_Odeme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctr_Odeme.TabIndex = 21;
            this.pctr_Odeme.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Gabriola", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(149, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 63);
            this.label8.TabIndex = 23;
            this.label8.Text = "Güvenli Ödeme";
            // 
            // frmOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(503, 412);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pctr_Odeme);
            this.Controls.Add(this.pnl_Odeme);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOdeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme İşlemleri";
            this.Load += new System.EventHandler(this.frmOdeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_Odeme.ResumeLayout(false);
            this.pnl_Odeme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctr_Odeme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdemeYap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskKartNo;
        private System.Windows.Forms.MaskedTextBox mskAy;
        private System.Windows.Forms.MaskedTextBox mskYıl;
        private System.Windows.Forms.TextBox txtOdeme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskCVC;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.Label lblSoyadi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_Odeme;
        private System.Windows.Forms.PictureBox pctr_Odeme;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}