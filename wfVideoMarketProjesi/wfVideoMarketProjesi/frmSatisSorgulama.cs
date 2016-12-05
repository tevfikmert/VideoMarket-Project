using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfVideoMarketProjesi
{
    public partial class frmSatisSorgulama : Form
    {
        public frmSatisSorgulama()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            cFilmSatis fs = new cFilmSatis();
            //fs.SatislariGetirByTarihlerArasi(lvSatislar, txtToplamAdet, txtToplamTutar, dtpTarih1.Value, dtpTarih2.Value);
            DataTable dt = fs.SatislariGetirByTarihlerArasi(dtpTarih1.Value, dtpTarih2.Value);
            dgvSatislar.DataSource = dt;
            dgvSatislar.Columns["FilmAd"].Width = 150;
            dgvSatislar.Columns["Adet"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSatislar.Columns["BirimFiyat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvSatislar.Columns["Tutar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            int TopAdet = 0;
            double TopTutar = 0;
            foreach (DataRow dr in dt.Rows)
            {
                TopAdet += Convert.ToInt32(dr["Adet"]);
                TopTutar += Convert.ToDouble(dr["Tutar"]);
            }
            txtToplamAdet.Text = TopAdet.ToString();
            txtToplamTutar.Text = TopTutar.ToString();
        }
    }
}
