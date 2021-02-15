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
    public partial class frmOdeme : Form
    {
        public frmOdeme()
        {
            InitializeComponent();
            
        }

        sqlBaglantisi bgl = new sqlBaglantisi();
        
        private void btnOdemeYap_Click(object sender, EventArgs e)
        {


            if (mskKartNo.Text == "" || mskCVC.Text == "" || mskAy.Text == "" || mskYıl.Text == "")
            {
                mskKartNo.BackColor = System.Drawing.Color.FromArgb(216, 191, 216);
                mskCVC.BackColor = System.Drawing.Color.FromArgb(216, 191, 216);
                mskAy.BackColor = System.Drawing.Color.FromArgb(216, 191, 216);
                mskYıl.BackColor = System.Drawing.Color.FromArgb(216, 191, 216);
                MessageBox.Show("Renkli Alanları Boş Geçemezsiniz", "Boş Alan Hatası");
            }
            else
            {
                SqlCommand komut = new SqlCommand("insert into tblOdemeler (AdiSoyadi,Odeme) values (@p1,@p2)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", lblAdi.Text + " " + lblSoyadi.Text);
                komut.Parameters.AddWithValue("@p2", txtOdeme.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                
            }
            pctr_Odeme.Location = new Point(-3, -5);
            timer1.Start();

            

        }

        private void frmOdeme_Load(object sender, EventArgs e)
        {
            txtOdeme.ReadOnly = true;
            lblAdi.Text = frmSecenekler.isim;
            lblSoyadi.Text = frmSecenekler.soyisim;
            
            txtOdeme.Text = Convert.ToString(frmAnaSayfa.toplam); 
        }


        int sayac = 0;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label7.Text = sayac.ToString("00:00");
            if (sayac == 2)
            {
                pctr_Odeme.Location = new Point(557, -4);
                this.Hide();
            }
           
            
        }
    }
}
