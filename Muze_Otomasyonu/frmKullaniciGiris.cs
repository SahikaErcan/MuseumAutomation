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
    public partial class frmKullaniciGirisi : Form
    {
        sqlBaglantisi bgl = new sqlBaglantisi();


        
        string _gelenVeri;  
        public frmKullaniciGirisi(string gelenVeri)   
        {
            InitializeComponent();
           
            _gelenVeri = gelenVeri;
            if (_gelenVeri.Equals("yonetici"))   // parametreden gelen değer yöneticiye eşit ise
            {
                this.Text = "Yönetici Girişi";  
            }
            if (_gelenVeri.Equals("uye"))
            {
                this.Text = "Üye Girişi";  
                
            }
        }
       

        public void kullanıcıGiris()
        {
            SqlCommand komut = new SqlCommand("Select*From tblKayit where Adi=@p1 and Sifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtKullaniciSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("ÜYE GİRİŞİ ONAYLANMIŞTIR...");
                frmAnaSayfa anaSayfa = new frmAnaSayfa("üye");
                
                anaSayfa.grpPersonelPaneli.Visible = false;
                anaSayfa.txt_biletId.Visible = false;
                anaSayfa.lbl_randevuId.Visible = false;
                anaSayfa.dtGrd_bilet.Visible = false;
                
                anaSayfa.btn_biletAl.Location = new Point(164,230);
                anaSayfa.pctr_Muze.Location = new Point(86,160);
                anaSayfa.btn_Sikayet.Visible = false;
                anaSayfa.btnEserler.Location = new Point(181,30);
                anaSayfa.btnEserler.Size = new Size(372, 45);
                
                frmSecenekler.isim = dr["Adi"].ToString();
                frmSecenekler.soyisim = dr["Soyadi"].ToString();
                frmSecenekler.mail = dr["Eposta"].ToString();


                anaSayfa.ShowDialog();
               
                this.Hide();   
            }  
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız...","Giriş Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);      
            }
        }
        public void yoneticiGiris()
        {
            SqlCommand komut = new SqlCommand("Select*From tblYonetici where Adi ='"+txtKullaniciAdi.Text+ "' AND Sifre='"+txtKullaniciSifre.Text +"'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("YÖNETİCİ GİRİŞİ ONAYLANMIŞTIR...");
                frmAnaSayfa anaSayfa = new frmAnaSayfa("yönetici");
                anaSayfa.pctr_biletGif.Visible = false;
                anaSayfa.btn_Sikayet.Visible = false;
                anaSayfa.lblBiletOdeme.Visible = true;
                anaSayfa.txt_biletOdeme.Visible = true;
                anaSayfa.btn_biletAl.Text = "Ziyaretçi Geldi";
                anaSayfa.btn_SikayetGoster.Location = new Point(399, 50);
                anaSayfa.Size = new Size(1113,683);
                anaSayfa.ShowDialog();
                this.Hide();
            }
            
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız...", "Giriş Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (_gelenVeri.Equals("yonetici")) yoneticiGiris();
            if (_gelenVeri.Equals("uye"))kullanıcıGiris();                       
        }

   
        private void txtKullaniciAdi_MouseClick(object sender, MouseEventArgs e)
        {
            txtKullaniciAdi.Clear();
            txtKullaniciAdi.ForeColor = Color.Black;
        }
        private void txtKullaniciSifre_MouseClick_1(object sender, MouseEventArgs e)
        { 
            txtKullaniciSifre.Clear();
            txtKullaniciSifre.PasswordChar = '●';
            txtKullaniciSifre.ForeColor = Color.Black;         
        }   
        private void chck_SifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chck_SifreGoster.Checked)
            {
                txtKullaniciSifre.UseSystemPasswordChar = true; // şifreyi göster
            }
            else
            {
                txtKullaniciSifre.UseSystemPasswordChar = false; // şifreyi gizle
            }
        }
       
        private void lnkSifreDegis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSifreGüncelle guncelle = new frmSifreGüncelle("guncelleme");
            guncelle.Show(); 
        }

        private void lnkSifreUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSifreGüncelle yenile = new frmSifreGüncelle("sifreYenileme");
            yenile.Show();
            yenile.btn_SifreGuncelle.Text = "Şifre Yenile";  // bunlara erişebilmek için frmSifreGuncelle
            yenile.lbl_Sifre.Text = "E-Posta :";//formunda MODİFİERS özelliğini PUBLİC yaptık.
            yenile.lbl_Renk.Text = "Yeni Sifre :";         
        }

        
    }
}
