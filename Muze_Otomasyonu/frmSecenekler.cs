using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muze_Otomasyonu
{
    public partial class frmSecenekler : Form
    {
       
        public static string isim="";
        public static string soyisim = "";
        public static string mail = "";


        public frmSecenekler()
        {
            InitializeComponent();
        }

       
        private void btnUye_MouseLeave(object sender, EventArgs e) // butondan ayrıldığında tetiklenen olay
        {
            btnUyeGiris.BackColor = Color.White;
        }

        private void btnUye_MouseEnter(object sender, EventArgs e) // butona geldiğinde tetiklenen olay
        {
            btnUyeGiris.BackColor = Color.Transparent;
        }

        private void btnYonetici_MouseLeave(object sender, EventArgs e)
        {
            btnYoneticiGiris.BackColor = Color.White;
        }

        private void btnYonetici_MouseEnter(object sender, EventArgs e)
        {
            btnYoneticiGiris.BackColor = Color.Transparent;
        }
        
        private void btnUyeKayit_MouseLeave(object sender, EventArgs e)
        {
            btnUyeKayit.BackColor = Color.White;
        }
        private void btnUyeKayit_MouseEnter(object sender, EventArgs e)
        {
            btnUyeKayit.BackColor = Color.Transparent;
        }

       
            
        private void btnUyeKayit_Click(object sender, EventArgs e)
        {
            UyeKayit kayit = new UyeKayit();  
            kayit.ShowDialog();            
        }
        private void btnYonetici_Click(object sender, EventArgs e)
        {
           
            frmKullaniciGirisi kullanici = new frmKullaniciGirisi("yonetici"); 
            kullanici.Show();
            //**************************************************  Hocanın göreceği durum  
            frmAnaSayfa anaSayfa = new frmAnaSayfa("yonetici");
            anaSayfa.pctr_biletGif.Visible = false;
            anaSayfa.btn_Sikayet.Visible = false;
            anaSayfa.lblBiletOdeme.Visible = true;
            anaSayfa.txt_biletOdeme.Visible = true;
            anaSayfa.btn_biletAl.Text = "Ziyaretçi Geldi";
            anaSayfa.btn_SikayetGoster.Location = new Point(399, 50);
            anaSayfa.Size = new Size(1113, 683);
            anaSayfa.ShowDialog();
            

        }
        
        private void btnUye_Click(object sender, EventArgs e)
        {
            frmKullaniciGirisi kullanici = new frmKullaniciGirisi("uye"); 
            kullanici.Show();
            //****************************************************** Hocanın göreceği durum
            frmAnaSayfa anaSayfa = new frmAnaSayfa("uye");
            anaSayfa.pctr_biletGif.Visible = false;
            anaSayfa.grpPersonelPaneli.Visible = false;
            anaSayfa.txt_biletId.Visible = false;
            anaSayfa.lbl_randevuId.Visible = false;
            anaSayfa.dtGrd_bilet.Visible = false;
            anaSayfa.pctr_biletGif.Visible = true;

            anaSayfa.btn_biletAl.Location = new Point(164, 230);
            anaSayfa.pctr_Muze.Location = new Point(86, 160);
            anaSayfa.btn_Sikayet.Visible = false;
            anaSayfa.btnEserler.Location = new Point(181, 30);
            anaSayfa.btnEserler.Size = new Size(372, 45);
            anaSayfa.ShowDialog();
        }
        
      
        private void btn_Hakkinda_Click(object sender, EventArgs e)
        {
            frmAnaSayfa anaSayfa = new frmAnaSayfa("");
            anaSayfa.grpBiletPaneli.Visible = false;
            anaSayfa.grpPersonelPaneli.Visible = false;
            anaSayfa.pctr_Muze.Location = new Point(86, 160);
            anaSayfa.Size = new Size(748, 683);
            anaSayfa.pctr_Muze.Location = new Point(61,120);
            anaSayfa.lbl_MüzeBilgi.Location = new Point(450,470);
            this.Hide();   
            anaSayfa.ShowDialog();
            this.Show();   
            
        }
    }
}
