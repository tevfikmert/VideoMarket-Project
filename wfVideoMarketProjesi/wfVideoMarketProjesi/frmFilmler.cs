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
    public partial class frmFilmler : Form
    {
        public frmFilmler()
        {
            InitializeComponent();
        }

        private void frmFilmler_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cFilm f = new cFilm();
            f.FilmleriGetir(lvFilmler);

            cFilmTuru ft = new cFilmTuru();
            ft.FilmTurleriGetir(cbFilmTurleri);
        }

        private void cbFilmTurleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            cFilmTuru ft = (cFilmTuru)cbFilmTurleri.SelectedItem;
            txtFilmTuru.Text = ft.TurAd;
            txtTurNo.Text = Convert.ToString(ft.FilmTurNo);

            //txtFilmTuru.Text = cbFilmTurleri.SelectedItem.ToString();

            //txtTurNo.Text = ft.FilmTurNoGetirByTureGore(txtFilmTuru.Text).ToString();
            txtYonetmen.Focus();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            Temizle();
        }
        private void Temizle()
        {
            txtFilmAdi.Clear();
            txtYonetmen.Clear();
            txtOyuncular.Clear();
            txtOzet.Clear();
            txtMiktar.Text = "1";
            txtFilmAdi.Focus();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(txtFilmAdi.Text.Trim() != "" && txtYonetmen.Text.Trim() != "")
            {
                cFilm f = new cFilm();
                if(f.FilmKontrol(txtFilmAdi.Text, txtYonetmen.Text))
                {
                    MessageBox.Show("Bu film önceden kayıtlı!");
                    txtFilmAdi.Focus();
                }
                else
                {
                    f.FilmAd = txtFilmAdi.Text;
                    f.FilmTurNo = Convert.ToInt32(txtTurNo.Text);
                    f.Yonetmen = txtYonetmen.Text;
                    f.Oyuncular = txtOyuncular.Text;
                    f.Ozet = txtOzet.Text;
                    f.Miktar = Convert.ToInt32(txtMiktar.Text);
                    if(f.FilmEkle(f))
                    {
                        MessageBox.Show("Film Bilgileri kayıt edildi.");
                        f.FilmleriGetir(lvFilmler);
                        Temizle();
                        btnKaydet.Enabled = false;                        
                    }
                    else { MessageBox.Show("Film kayıt işlemi gerçekleşmedi!"); }
                }
            }
        }
        private void lvFilmler_DoubleClick(object sender, EventArgs e)
        {
            txtFilmNo.Text = lvFilmler.SelectedItems[0].SubItems[0].Text;
            txtFilmAdi.Text = lvFilmler.SelectedItems[0].SubItems[1].Text;
            txtTurNo.Text = lvFilmler.SelectedItems[0].SubItems[2].Text;
            txtFilmTuru.Text = lvFilmler.SelectedItems[0].SubItems[3].Text;           
            txtYonetmen.Text = lvFilmler.SelectedItems[0].SubItems[4].Text;
            txtOyuncular.Text = lvFilmler.SelectedItems[0].SubItems[5].Text;
            txtOzet.Text = lvFilmler.SelectedItems[0].SubItems[6].Text;
            txtMiktar.Text = lvFilmler.SelectedItems[0].SubItems[7].Text;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            txtFilmAdi.Focus();
        }
        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtFilmAdi.Text.Trim() != "" && txtYonetmen.Text.Trim() != "")
            {
                cFilm f = new cFilm();
                if (f.FilmKontrol(txtFilmAdi.Text, txtYonetmen.Text, Convert.ToInt32(txtFilmNo.Text)))
                {
                    MessageBox.Show("Bu film önceden kayıtlı!");
                    txtFilmAdi.Focus();
                }
                else
                {
                    f.FilmNo = Convert.ToInt32(txtFilmNo.Text);
                    f.FilmAd = txtFilmAdi.Text;
                    f.FilmTurNo = Convert.ToInt32(txtTurNo.Text);
                    f.Yonetmen = txtYonetmen.Text;
                    f.Oyuncular = txtOyuncular.Text;
                    f.Ozet = txtOzet.Text;
                    f.Miktar = Convert.ToInt32(txtMiktar.Text);
                    if (f.FilmGuncelle(f))
                    {
                        MessageBox.Show("Film Bilgileri değiştirildi.");
                        f.FilmleriGetir(lvFilmler);
                        Temizle();
                        btnKaydet.Enabled = false;
                    }
                    else { MessageBox.Show("Film güncelleme işlemi gerçekleşmedi!"); }
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cFilm f = new cFilm();
                bool Sonuc = f.FilmSil(Convert.ToInt32(txtFilmNo.Text));
                if (Sonuc)
                {
                    MessageBox.Show("Film bilgileri silindi.");
                    Temizle();
                    btnDegistir.Enabled = false;
                    btnSil.Enabled = false;
                    f.FilmleriGetir(lvFilmler);
                }
            }
        }
        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            cFilm f = new cFilm();
            f.FilmleriGetirByAdaGore(txtAdaGore.Text, lvFilmler);
        }
    }
}
