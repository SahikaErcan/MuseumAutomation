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
    public partial class frmAnaSayfa : Form
    {
        
        public static int toplam;  // bilet ücret hesabı

        string _gelenveri;

        sqlBaglantisi bgl = new sqlBaglantisi();
        ToolTip aciklama = new ToolTip();

        public frmAnaSayfa(string gelenveri)
        {
            _gelenveri = gelenveri;

            InitializeComponent();
            listele();
            uyelistele();
          
        // GroupBoxın ForeColor ını Beyaz yaptığım için tablodaki yazılarda beyaz oldu bunu engellemek için tablonun yazı rengini burada belirledik.
            this.dt_Personel.DefaultCellStyle.ForeColor = Color.Black;
            this.dtGrd_bilet.DefaultCellStyle.ForeColor = Color.Black;
           
            // Fare butonun üzerine geldiğinde açıklama yazma
            aciklama.SetToolTip(btn_MuzePlan, "Müze Planı");
            aciklama.SetToolTip(pctr_Temizle, "Temizle");
            aciklama.SetToolTip(btn_SikayetKaydet, "Gönder");
            
        }
        
        private void btn_Ekle_Click_1(object sender, EventArgs e)
        {
            //Giriş yapılmayan alanlarda uyarıyor.
            if (txt_Adi.Text == "" || txt_Soyadi.Text == "" || msk_Telefon.Text == "" || txt_Eposta.Text == String.Empty || txt_Adres.Text == String.Empty || msk_BaslamaTarihi.Text == String.Empty || txt_Departman.Text == String.Empty || lbl_Cinsiyet.Text == String.Empty)
            {
                txt_Adi.BackColor = System.Drawing.Color.FromArgb(216, 191, 216);
                txt_Soyadi.BackColor = System.Drawing.Color.FromArgb(216, 191, 216);
                msk_Telefon.BackColor = System.Drawing.Color.FromArgb(216, 191, 216);
                txt_Eposta.BackColor = System.Drawing.Color.FromArgb(216, 191, 216);
                txt_Adres.BackColor = System.Drawing.Color.FromArgb(216, 191, 216);
                msk_BaslamaTarihi.BackColor = System.Drawing.Color.FromArgb(216, 191, 216);
                txt_Departman.BackColor = System.Drawing.Color.FromArgb(216, 191, 216);
                MessageBox.Show("Boş Alanları Doldurunuz...", "Boş Alan Hatası");
            }
            else
            {
                SqlCommand komut = new SqlCommand("insert into tblPersonel(Adi,Soyadi,TelefonNo,Eposta,Adres,BaslamaTarihi,Departman,Cinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txt_Adi.Text);
                komut.Parameters.AddWithValue("@p2", txt_Soyadi.Text);
                komut.Parameters.AddWithValue("@p3", msk_Telefon.Text);
                komut.Parameters.AddWithValue("@p4", txt_Eposta.Text);
                komut.Parameters.AddWithValue("@p5", txt_Adres.Text);
                komut.Parameters.AddWithValue("@p6", msk_BaslamaTarihi.Text);
                komut.Parameters.AddWithValue("@p7", txt_Departman.Text);
                komut.Parameters.AddWithValue("@p8", lbl_Cinsiyet.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show(txt_Adi.Text + " adlı personelin kaydı başarıyla gerçekleşmiştir.");
                listele();
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txt_Adi.Text == "" || txt_Soyadi.Text == "" || msk_Telefon.Text == "" || txt_Eposta.Text == String.Empty || txt_Adres.Text == String.Empty || msk_BaslamaTarihi.Text == String.Empty || txt_Departman.Text == String.Empty || lbl_Cinsiyet.Text == String.Empty)
            {
              // Boş alan uyarısı

                txt_Adi.BackColor = System.Drawing.Color.FromArgb(216, 191, 216);
                txt_Soyadi.BackColor = System.Drawing.Color.FromArgb(216, 191, 216);
                msk_Telefon.BackColor = System.Drawing.Color.FromArgb(216, 191, 216);
                txt_Eposta.BackColor = System.Drawing.Color.FromArgb(216, 191, 216);
                txt_Adres.BackColor = System.Drawing.Color.FromArgb(216, 191, 216);
                msk_BaslamaTarihi.BackColor = System.Drawing.Color.FromArgb(216, 191, 216);
                txt_Departman.BackColor = System.Drawing.Color.FromArgb(216, 191, 216);
                MessageBox.Show("Renkli Alanları Boş Geçemezsiniz...", "Boş Alan Hatası");
            }
            else
            { 
                SqlCommand komut = new SqlCommand("Update tblPersonel Set Adi=@s1, Soyadi=@s2, TelefonNo=@s3, Eposta=@s4, Adres=@s5, BaslamaTarihi=@s6,Departman=@s7,Cinsiyet=@s8 where Personel_Id=@s9", bgl.baglanti());
                komut.Parameters.AddWithValue("@s1", txt_Adi.Text);
                komut.Parameters.AddWithValue("@s2", txt_Soyadi.Text);
                komut.Parameters.AddWithValue("@s3", msk_Telefon.Text);
                komut.Parameters.AddWithValue("@s4", txt_Eposta.Text);
                komut.Parameters.AddWithValue("@s5", txt_Adres.Text);
                komut.Parameters.AddWithValue("@s6", msk_BaslamaTarihi.Text);
                komut.Parameters.AddWithValue("@s7", txt_Departman.Text);
                komut.Parameters.AddWithValue("@s8", lbl_Cinsiyet.Text);
                komut.Parameters.AddWithValue("@s9", txt_Id.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Personel Bilgileri Güncellendi...");
                listele();
            }
        }
        private void rdbtn_Kadin_CheckedChanged_1(object sender, EventArgs e)
        {
            lbl_Cinsiyet.Text = "Kadın";
        }

        private void rdbtn_Erkek_CheckedChanged_1(object sender, EventArgs e)
        {
            lbl_Cinsiyet.Text = "Erkek";
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete from tblPersonel where Personel_Id=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txt_Id.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Silindi...");
                listele();

            }
        }

        public void listele()
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter("select * from tblPersonel", bgl.baglanti());
            data.Fill(tablo);
            dt_Personel.DataSource = tablo;
            bgl.baglanti().Close();
        }
        private void btn_Listele_Click(object sender, EventArgs e)
        {
            grpPersonelPaneli.Width = 983;
            listele();
            btnGuncelle.Visible = true;
            btn_Sil.Visible = true;
        }
        void personelTemizle()
        {
            txt_Id.Text = "";
            txt_Adi.Text = "";
            txt_Soyadi.Text = "";
            msk_Telefon.Text = "";
            txt_Eposta.Text = "";
            txt_Adres.Text = "";
            msk_BaslamaTarihi.Text = "";
            txt_Departman.Text = "";
            lbl_Cinsiyet.Text = "";

            txt_Id.Visible = false;
            lblId.Visible = false;
        }
        private void pctr_Temizle_Click(object sender, EventArgs e)
        {
        // Personel tablosuna click olayı uyguladığımızda textlerin içi doluyor, bu kısımda textlerin içini temizliyoruz.
            personelTemizle();
        }
        
        private void pctr_Kapat_Click(object sender, EventArgs e)
        {
        //Personel ekle/güncelle/sil bölümünde personel listesine tıkladığımızda groupBox genişliyor.GrupBox ı eski haline getirmek için kullanıyoruz.
            grpPersonelPaneli.Width = 395;
            personelTemizle();
            btn_Sil.Visible = false;
            btnGuncelle.Visible = false;
        }
        private void btn_Sikayet_Click(object sender, EventArgs e)
        {
            // Üye olmayak kullanıcılara şikayet ve öneride bulunmaları için şart koştuk.
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Şikayet veya öneride bulunmak için lütfen üye olunuz.", "Bilgilendirme!", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            if (dialog == DialogResult.OK)
            {
                UyeKayit kayit = new UyeKayit();  //OK tıkladığımız da Kayıt formu açılıyor.
                kayit.FormBorderStyle = FormBorderStyle.None;
                this.Hide();
                kayit.ShowDialog();
                this.Show();
                
                frmKullaniciGirisi kullaniciGirisi = new frmKullaniciGirisi("uye"); // kayıt olduktan sonra giriş formunu açıyoruz.
                kullaniciGirisi.ShowDialog();
                this.Hide();
            }

        }
        private void btn_SikayetKaydet_Click(object sender, EventArgs e)
        {   
            // Çektiğimiz isim soyisim ve mail bigilerini kullanarak şikayet ve önerileri ekledik.
            SqlCommand komut = new SqlCommand("Insert into tblSikayetOneri(Adi,Soyadi,Eposta,SikayetOneri) values (@p1,@p2,@p3,@p4)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",frmSecenekler.isim);
            komut.Parameters.AddWithValue("@p2",frmSecenekler.soyisim);
            komut.Parameters.AddWithValue("@p3",frmSecenekler.mail);
            komut.Parameters.AddWithValue("@p4",rchSikayet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Şikayet veya önerilerinizi dikkate alacağız.", "TEŞEKKÜRLER!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            rchSikayet.Text = "";


        } 
        private void dt_Personel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verileri click olayı ile textlere taşıyoruz ve taşırken visible false olan id bilgidini true yapıyoruz.
            txt_Id.Visible = true;
            lblId.Visible = true;
            int secilen = dt_Personel.SelectedCells[0].RowIndex;
            txt_Id.Text = dt_Personel.Rows[secilen].Cells[0].Value.ToString();
            txt_Adi.Text = dt_Personel.Rows[secilen].Cells[1].Value.ToString();
            txt_Soyadi.Text = dt_Personel.Rows[secilen].Cells[2].Value.ToString();
            msk_Telefon.Text = dt_Personel.Rows[secilen].Cells[3].Value.ToString();
            txt_Eposta.Text = dt_Personel.Rows[secilen].Cells[4].Value.ToString();
            txt_Adres.Text = dt_Personel.Rows[secilen].Cells[5].Value.ToString();
            msk_BaslamaTarihi.Text = dt_Personel.Rows[secilen].Cells[6].Value.ToString();
            txt_Departman.Text = dt_Personel.Rows[secilen].Cells[7].Value.ToString();
            lbl_Cinsiyet.Text = dt_Personel.Rows[secilen].Cells[8].Value.ToString();
            if (lbl_Cinsiyet.Text == "Kadın")
            {
                rdbtn_Kadin.Checked = true;  // radioButon üzerindeki değişikliği label aracılığı ile gerçekleştirdik.
            }
            else
            {
                rdbtn_Erkek.Checked = true;
            }
        }

        private void btn_SikayetGoster_Click(object sender, EventArgs e)
        {
            frmSikayetOneri sikayet = new frmSikayetOneri();
            sikayet.ShowDialog();
        }

        private void btn_MuzePlan_Click(object sender, EventArgs e)
        {
            frm_MuzePlan muze = new frm_MuzePlan();
            this.Hide();
            muze.ShowDialog();
            this.Show();
            
        }
        
        private void dtGrd_bilet_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {   // Verileri click olayı ile textlere taşıyoruz
            
            int secilen = dtGrd_bilet.SelectedCells[0].RowIndex;
            txt_biletId.Text = dtGrd_bilet.Rows[secilen].Cells[0].Value.ToString();
            txt_biletAdSoyad.Text = dtGrd_bilet.Rows[secilen].Cells[1].Value.ToString();
            dtp_biletTarih.Text = dtGrd_bilet.Rows[secilen].Cells[2].Value.ToString();
            msk_biletSaat.Text = dtGrd_bilet.Rows[secilen].Cells[3].Value.ToString();
            txt_biletKisiSayisi.Text = dtGrd_bilet.Rows[secilen].Cells[4].Value.ToString();
            txt_biletOdeme.Text = dtGrd_bilet.Rows[secilen].Cells[5].Value.ToString();

        }

        private void btnEserler_Click(object sender, EventArgs e)
        {            
            if (_gelenveri.Equals("yonetici"))  //Eğer yönetici giriş yapmış ise btnEserler butonu Eser Ekleme formunu açsın.
            {
                frmEserEkle eserEkle = new frmEserEkle();
                this.Hide();
                eserEkle.ShowDialog();
                this.Show();
            }
            else
            { // Eğer yönetici giriş yapmamış ise müze ve müzede ki eserler hakkında bilgi veren formu açsın.
                frm_Eserler eserler = new frm_Eserler();
                this.Hide();
                eserler.ShowDialog();
                this.Show();
            }
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            txt_biletAdSoyad.Text = frmSecenekler.isim + " " + frmSecenekler.soyisim;
            listele();
            uyelistele();
            
        }

        void uyelistele()
        {  // 2 tablodaki bilgiler birleştirildi.
            SqlCommand komut = new SqlCommand("Select tblBilet.BiletId,tblBilet.AdiSoyadi,tblBilet.Tarih,tblBilet.Saat,tblBilet.KisiSayisi,tblOdemeler.Odeme From tblBilet INNER JOIN tblOdemeler ON tblBilet.AdiSoyadi=tblOdemeler.AdiSoyadi", bgl.baglanti());
            SqlDataAdapter data = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            data.Fill(tablo);
            komut.ExecuteNonQuery();
            dtGrd_bilet.DataSource = tablo;
            bgl.baglanti().Close();
        }
        void biletTemizle()
        {
            txt_biletOdeme.Text = "";
            txt_biletId.Text = "";
            txt_biletAdSoyad.Text = "";
            txt_biletKisiSayisi.Text = "";
            msk_biletSaat.Text = "";
        }
        private void btn_biletAl_Click_1(object sender, EventArgs e)
        {
            toplam = Convert.ToInt32(txt_biletKisiSayisi.Text) * 8;

            if (msk_biletSaat.Text == "" || txt_biletKisiSayisi.Text == "" || dtp_biletTarih.Text == String.Empty)
            {
                msk_biletSaat.BackColor = System.Drawing.Color.FromArgb(216, 191, 216);
                txt_biletKisiSayisi.BackColor = System.Drawing.Color.FromArgb(216, 191, 216);
                dtp_biletTarih.BackColor = System.Drawing.Color.FromArgb(216, 191, 216);

                MessageBox.Show("Boş Alanları Doldurunuz...", "Boş Alan Hatası");
            }

            if (btn_biletAl.Text=="Ziyaretçi Geldi")
            {                                           // 2 tablodanda aynı anda kayıt siliyor.
                SqlCommand komut = new SqlCommand("Delete from tblBilet where BiletId=@p1;Delete from tblOdemeler where Odeme=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txt_biletId.Text);
                komut.Parameters.AddWithValue("@p2", txt_biletOdeme.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Gelen ziyaretçiler sistemden silindi.");
                biletTemizle();
            }
            else
            {
                SqlCommand komut = new SqlCommand("Insert into tblBilet (AdiSoyadi,Tarih,Saat,KisiSayisi) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
                DateTime d = Convert.ToDateTime(dtp_biletTarih.Value);
                komut.Parameters.AddWithValue("@p1", frmSecenekler.isim + " " + frmSecenekler.soyisim);
                komut.Parameters.AddWithValue("@p2", d.ToString("MMMM dd,yyyy"));
                komut.Parameters.AddWithValue("@p3", msk_biletSaat.Text);
                komut.Parameters.AddWithValue("@p4", txt_biletKisiSayisi.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                frmOdeme odeme = new frmOdeme();
                odeme.Show();
                biletTemizle();
            }                           
        }

       
    }
}