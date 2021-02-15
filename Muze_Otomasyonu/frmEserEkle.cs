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
    public partial class frmEserEkle : Form
    {
        public frmEserEkle()
        {
            InitializeComponent();
            eserlistele();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
       
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tblEserListesi (EnvanterNo,KaziNo,EserAdiCinsi,BulunduguYer,Cagi,Olcusu,GelisTarihi,GelisSekli,EserTanimi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txt_envanter.Text);
            komut.Parameters.AddWithValue("@p2",txt_kazi.Text);
            komut.Parameters.AddWithValue("@p3", txt_eserAdi.Text);
            komut.Parameters.AddWithValue("@p4", txt_bulunduguYer.Text);
            komut.Parameters.AddWithValue("@p5", txt_cag.Text);
            komut.Parameters.AddWithValue("@p6", txt_eserOlcusu.Text);
            komut.Parameters.AddWithValue("@p7", msk_eserTarih.Text);
            komut.Parameters.AddWithValue("@p8", txt_gelisSekli.Text);
            komut.Parameters.AddWithValue("@p9",rch_erserTanimi.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            eserlistele();
        }

        private void btn_cikar_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from tblEserListesi where EserId=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txt_eserId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            eserlistele();
            MessageBox.Show("Eser Kaydı Silindi...");
            
        }
        void eserlistele()
        {
            SqlDataAdapter data = new SqlDataAdapter("Select * From tblEserListesi",bgl.baglanti());
            DataTable tablo = new DataTable();
            data.Fill(tablo);
            dt_eserListesi.DataSource=tablo;
            bgl.baglanti().Close();
        }

        private void dt_eserListesi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblEserId.Visible = true;
            txt_eserId.Visible = true;
            int secilen = dt_eserListesi.SelectedCells[0].RowIndex;
            txt_eserId.Text = dt_eserListesi.Rows[secilen].Cells[0].Value.ToString();
            txt_envanter.Text = dt_eserListesi.Rows[secilen].Cells[1].Value.ToString();
            txt_kazi.Text = dt_eserListesi.Rows[secilen].Cells[2].Value.ToString();
            txt_eserAdi.Text = dt_eserListesi.Rows[secilen].Cells[3].Value.ToString();
            txt_bulunduguYer.Text = dt_eserListesi.Rows[secilen].Cells[4].Value.ToString();
            txt_cag.Text = dt_eserListesi.Rows[secilen].Cells[5].Value.ToString();
            txt_eserOlcusu.Text = dt_eserListesi.Rows[secilen].Cells[6].Value.ToString();
            msk_eserTarih.Text = dt_eserListesi.Rows[secilen].Cells[7].Value.ToString();
            txt_gelisSekli.Text = dt_eserListesi.Rows[secilen].Cells[8].Value.ToString();
            rch_erserTanimi.Text = dt_eserListesi.Rows[secilen].Cells[9].Value.ToString();
        }

        private void pctr_eserTemizle_Click(object sender, EventArgs e)
        {
            lblEserId.Visible = false;
            txt_eserId.Visible = false;
            txt_eserId.Text = "";
            txt_envanter.Text = "";
            txt_kazi.Text = "";
            txt_eserAdi.Text = "";
            txt_bulunduguYer.Text = "";
            txt_cag.Text = "";
            txt_eserOlcusu.Text = "";
            msk_eserTarih.Text = "";
            txt_gelisSekli.Text = "";
            rch_erserTanimi.Text = "";
        }

        private void btn_eserListesi_Click(object sender, EventArgs e)
        {
            Width = 1275;
            this.DesktopLocation = new Point(100, 90);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Width = 646;
            this.DesktopLocation = new Point(500,90);
        }
    }
}
