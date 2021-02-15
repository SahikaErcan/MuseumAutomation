using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Muze_Otomasyonu
{
    public partial class frmSifreGüncelle : Form
    {
        sqlBaglantisi bgl = new sqlBaglantisi();
        string _gelenVeri;
        public frmSifreGüncelle(string gelenVeri)
        {
            InitializeComponent();

            _gelenVeri = gelenVeri;

            if (_gelenVeri.Equals("guncelleme"))
            {
                this.Text = "Şifre Güncelleme";
            }
            if (_gelenVeri.Equals("sifreYenileme"))
            {
                this.Text = "Şifre Yenileme";               
            }
            
        }
        private void btn_SifreGuncelle_Click(object sender, EventArgs e)
        {
            if (_gelenVeri.Equals("guncelleme")) guncelle();
            if (_gelenVeri.Equals("sifreYenileme")) sifreYenile();
        }
        void uyari()
        {
            
             txtKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(216, 191, 216);
             txt_Sifre.BackColor = System.Drawing.Color.FromArgb(216, 191, 216);
             txt_YeniSifre.BackColor = System.Drawing.Color.FromArgb(216, 191, 216);
             txt_Renk.BackColor = System.Drawing.Color.FromArgb(216, 191, 216);
             MessageBox.Show("Renkli Alanları Boş Geçemezsiniz", "Boş Alan Hatası");

        }

        public void guncelle()
        {
            if (txt_Sifre.Text == "" || txt_YeniSifre.Text == "" || txtKullaniciAdi.Text == "" || txt_Renk.Text == "")
            {
                uyari();
                
            }
            else
            {
                SqlCommand komut = new SqlCommand("Update tblKayit Set Sifre=@p1 where SifreKurtar ='" + txt_Renk.Text + "'", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txt_YeniSifre.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Şifre başarıyla güncellenmiştir.Yeni şifreniz : " + txt_YeniSifre.Text);
                this.Close();
            }
            
        }
        
        public void sifreYenile()
        {
            if (txt_Sifre.Text == "" || txt_YeniSifre.Text == "" || txtKullaniciAdi.Text == "" || txt_Renk.Text == "")
            {
                uyari();
            }
            else
            {                                                                  // txt_Sifre aynı zamanda Eposta görevi görüyor.
                SqlCommand komut = new SqlCommand("Update tblKayit Set Sifre=@p1 where Eposta ='" + txt_Sifre.Text + "'", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txt_YeniSifre.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Şifre başarıyla güncellenmiştir.Yeni şifreniz : " + txt_YeniSifre.Text);
                this.Close();
            }
        }
       

    }
}
