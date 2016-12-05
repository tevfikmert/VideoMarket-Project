using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfVideoMarketProjesi
{
    public partial class frmSatisRaporu : Form
    {
        public frmSatisRaporu()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(cGenel.connStr);
        private void frmSatisRaporu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'VideoMarketDataSet1.vw_DetayliSatisRaporu' table. You can move, or remove it, as needed.
            this.vw_DetayliSatisRaporuTableAdapter.Fill(this.VideoMarketDataSet1.vw_DetayliSatisRaporu);

            this.reportViewer1.RefreshReport();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            this.VideoMarketDataSet1.vw_DetayliSatisRaporu.Clear();
            SqlDataAdapter da = new SqlDataAdapter("Select Convert(Date, Tarih, 104) as Tarih, FilmAd, MusteriAd + ' ' + MusteriSoyad as Musteri, Adet, BirimFiyat, BirimFiyat * Adet as Tutar from FilmSatis fs inner join Filmler f on fs.FilmNo = f.FilmNo inner join Musteriler m on fs.MusteriNo = m.MusteriNo where fs.Silindi=0 and Convert(Date, Tarih, 104) between Convert(Date, @Tarih1, 104) and Convert(Date, @Tarih2, 104) order by Tarih desc", conn);
            da.SelectCommand.Parameters.Add("@Tarih1", SqlDbType.DateTime).Value = dtpTarih1.Value;
            da.SelectCommand.Parameters.Add("@Tarih2", SqlDbType.DateTime).Value = dtpTarih2.Value;
            try
            {
                da.Fill(this.VideoMarketDataSet1.vw_DetayliSatisRaporu);
                this.reportViewer1.RefreshReport();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
        }
    }
}
