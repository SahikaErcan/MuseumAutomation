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
    public partial class frm_MuzePlan : Form
    {
        public frm_MuzePlan()
        {
            InitializeComponent();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
