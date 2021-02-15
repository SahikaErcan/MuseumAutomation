namespace Muze_Otomasyonu
{
    partial class frmSikayetOneri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSikayetOneri));
            this.dt_sikayetOneriListesi = new System.Windows.Forms.DataGridView();
            this.SikayetId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eposta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SikayetOneri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dt_sikayetOneriListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_sikayetOneriListesi
            // 
            this.dt_sikayetOneriListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_sikayetOneriListesi.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dt_sikayetOneriListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_sikayetOneriListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SikayetId,
            this.Adi,
            this.Soyadi,
            this.Eposta,
            this.SikayetOneri});
            this.dt_sikayetOneriListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt_sikayetOneriListesi.Location = new System.Drawing.Point(0, 0);
            this.dt_sikayetOneriListesi.Name = "dt_sikayetOneriListesi";
            this.dt_sikayetOneriListesi.RowTemplate.Height = 24;
            this.dt_sikayetOneriListesi.Size = new System.Drawing.Size(800, 450);
            this.dt_sikayetOneriListesi.TabIndex = 0;
            // 
            // SikayetId
            // 
            this.SikayetId.DataPropertyName = "SikayetId";
            this.SikayetId.HeaderText = "Şikayet Id";
            this.SikayetId.Name = "SikayetId";
            // 
            // Adi
            // 
            this.Adi.DataPropertyName = "Adi";
            this.Adi.HeaderText = "Adı";
            this.Adi.Name = "Adi";
            // 
            // Soyadi
            // 
            this.Soyadi.DataPropertyName = "Soyadi";
            this.Soyadi.HeaderText = "Soyadı";
            this.Soyadi.Name = "Soyadi";
            // 
            // Eposta
            // 
            this.Eposta.DataPropertyName = "Eposta";
            this.Eposta.HeaderText = "E-posta";
            this.Eposta.Name = "Eposta";
            // 
            // SikayetOneri
            // 
            this.SikayetOneri.DataPropertyName = "SikayetOneri";
            this.SikayetOneri.HeaderText = "Şikayet ve Önerler";
            this.SikayetOneri.Name = "SikayetOneri";
            // 
            // frmSikayetOneri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dt_sikayetOneriListesi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSikayetOneri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şikayet ve Öneriler";
            ((System.ComponentModel.ISupportInitialize)(this.dt_sikayetOneriListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_sikayetOneriListesi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SikayetId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eposta;
        private System.Windows.Forms.DataGridViewTextBoxColumn SikayetOneri;
    }
}