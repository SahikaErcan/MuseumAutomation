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
    public partial class UyeKayit : Form
    {
        public UyeKayit()
        {
            InitializeComponent();

        }

        sqlBaglantisi bgl = new sqlBaglantisi();

        private void btn_Kayit_Click(object sender, EventArgs e)
        {
            if (txtUyeAd.Text == "" || txtUyeSoyad.Text == "" || txtUyeGmail.Text == "" || txtUyeSifre.Text == "" || mskUyeTelefon.Text=="" || txt_SifreKurtar.Text=="")
            {
            txtUyeAd.BackColor = System.Drawing.Color.FromArgb(216, 191, 216);
            txtUyeSoyad.BackColor = System.Drawing.Color.FromArgb(216, 191, 216);
            mskUyeTelefon.BackColor = System.Drawing.Color.FromArgb(216, 191, 216);
            txtUyeGmail.BackColor = System.Drawing.Color.FromArgb(216, 191, 216);
            txtUyeSifre.BackColor = System.Drawing.Color.FromArgb(216, 191, 216);
            txt_SifreKurtar.BackColor = System.Drawing.Color.FromArgb(216, 191, 216);
            
            MessageBox.Show("Renkli Alanları Boş Geçemezsiniz", "Boş Alan Hatası");
            }
            
        
            else{
            SqlCommand komut = new SqlCommand("insert into tblKayit(Adi,Soyadi,TelefonNo,Eposta,Sifre,Cinsiyet,SifreKurtar) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtUyeAd.Text);
            komut.Parameters.AddWithValue("@p2", txtUyeSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskUyeTelefon.Text);
            komut.Parameters.AddWithValue("@p4", txtUyeGmail.Text);
            komut.Parameters.AddWithValue("@p5", txtUyeSifre.Text);
            komut.Parameters.AddWithValue("@p6", lblKayıtCinsiyet.Text);
            komut.Parameters.AddWithValue("@p7", txt_SifreKurtar.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Kaydınız Gerçekleşmiştir.\nŞifreniz : " + txtUyeSifre.Text);

            this.Hide();
            }
        }

        private void rdbtn_Kadin_CheckedChanged(object sender, EventArgs e)
        {
            lblKayıtCinsiyet.Text = "Kadın";
        }

        private void rdbtn_Erkek_CheckedChanged(object sender, EventArgs e)
        {
            lblKayıtCinsiyet.Text = "Erkek";
        }       
         private void chckbtn_SifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbtn_SifreGoster.Checked)
            {
                txtUyeSifre.UseSystemPasswordChar = false;
            }
            else
            {
                txtUyeSifre.UseSystemPasswordChar = true;
            }
        }
        private void txt_SifreKurtar_MouseClick(object sender, MouseEventArgs e)
        {
            txt_SifreKurtar.Clear();
            txt_SifreKurtar.ForeColor = Color.Black;
        }

        
    }
}
