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
    public partial class frmFilmSatis : Form
    {
        public frmFilmSatis()
        {
            InitializeComponent();
        }
        int ilkAdet = 0;
        private void frmFilmSatis_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            txtTarih.Text = DateTime.Now.ToShortDateString();
            cFilmSatis fs = new cFilmSatis();
            fs.SatislariGetir(lvSatislar, txtToplamAdet, txtToplamTutar);
        }
        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            txtTarih.Text = dtpTarih.Value.ToShortDateString();
        }
        private void btnMusteriBul_Click(object sender, EventArgs e)
        {
            frmMusteriSorgulama frm = new frmMusteriSorgulama();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            txtMusteriNo.Text = cGenel.musteriNo.ToString();
            txtMusteri.Text = cGenel.musteri;
        }
        private void btnFilmBul_Click(object sender, EventArgs e)
        {
            frmFilmSorgulama frm = new frmFilmSorgulama();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            txtFilmNo.Text = cGenel.filmNo.ToString();
            txtFilm.Text = cGenel.film;
            txtStok.Text = cGenel.stokMiktar.ToString();
            txtAdet.Focus();
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            btnFilmBul.Enabled = true;
            btnMusteriBul.Enabled = true;
            Temizle();
        }
        private void Temizle()
        {
            txtAdet.Text = "1";
            txtFiyat.Text = "0";
            txtTutar.Text = "0";
            txtFilm.Clear();
            txtFilmNo.Clear();
            txtStok.Clear();
            txtFilm.Focus();
        }
        private void txtAdet_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdet.Text))
            {
                txtAdet.Text = "1";
                txtAdet.Select(0, txtAdet.Text.Length);
            }
            if (string.IsNullOrEmpty(txtFiyat.Text))
            {
                txtFiyat.Text = "0";
                txtFiyat.Select(0, txtFiyat.Text.Length);
            }
            txtTutar.Text = (Convert.ToInt32(txtAdet.Text) * Convert.ToDouble(txtFiyat.Text)).ToString();
        }
        private void txtFiyat_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdet.Text))
            {
                txtAdet.Text = "1";
                txtAdet.Select(0, txtAdet.Text.Length);
            }
            if (string.IsNullOrEmpty(txtFiyat.Text))
            {
                txtFiyat.Text = "0";
                txtFiyat.Select(0, txtFiyat.Text.Length);
            }
            txtTutar.Text = (Convert.ToInt32(txtAdet.Text) * Convert.ToDouble(txtFiyat.Text)).ToString();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(txtFilmNo.Text.Trim() != "" && txtMusteriNo.Text.Trim() != "")
            {
                if(Convert.ToInt32(txtAdet.Text) > Convert.ToInt32(txtStok.Text))
                {
                    MessageBox.Show("Stok Miktarı yetersiz!");
                    txtAdet.Text = txtStok.Text;
                    txtAdet.Focus();
                }else
                {
                    cFilmSatis fs = new cFilmSatis();
                    fs.Tarih = Convert.ToDateTime(txtTarih.Text);
                    fs.FilmNo = Convert.ToInt32(txtFilmNo.Text);
                    fs.MusteriNo = Convert.ToInt32(txtMusteriNo.Text);
                    fs.Adet = Convert.ToInt32(txtAdet.Text);
                    fs.BirimFiyat = Convert.ToDouble(txtFiyat.Text);
                    if(fs.SatisEkle(fs))
                    {
                        MessageBox.Show("Satış Bilgileri kayıt edildi.");
                        //Satılan filmin stok miktarı güncellenmeli (azaltılmalı)
                        cFilm f = new cFilm();
                        bool Sonuc = f.StokGuncelleBySatisEkle(Convert.ToInt32(txtFilmNo.Text), Convert.ToInt32(txtAdet.Text));
                        if(Sonuc)
                        {
                            MessageBox.Show("Stok Güncellendi!");
                            fs.SatislariGetir(lvSatislar, txtToplamAdet, txtToplamTutar);
                            Temizle();
                            btnKaydet.Enabled = false;
                            btnFilmBul.Enabled = false;
                            btnMusteriBul.Enabled = false;
                        }
                    }
                    else { MessageBox.Show("Satış kaydı gerçekleşmedi!"); }
                }
            }
            else
            {
                MessageBox.Show("Müşteri ve Film seçilmelidir!", "Dikkat! Eksik Bilgi!");
                txtMusteri.Focus();
            }
        }
        private void lvSatislar_DoubleClick(object sender, EventArgs e)
        {
            txtSatisNo.Text = lvSatislar.SelectedItems[0].SubItems[0].Text;
            txtTarih.Text = lvSatislar.SelectedItems[0].SubItems[1].Text;
            txtFilm.Text = lvSatislar.SelectedItems[0].SubItems[2].Text;
            txtMusteri.Text = lvSatislar.SelectedItems[0].SubItems[3].Text;
            txtFiyat.Text = lvSatislar.SelectedItems[0].SubItems[4].Text;
            txtAdet.Text = lvSatislar.SelectedItems[0].SubItems[5].Text;
            ilkAdet=Convert.ToInt32(lvSatislar.SelectedItems[0].SubItems[5].Text);
            txtFilmNo.Text = lvSatislar.SelectedItems[0].SubItems[7].Text;
            txtMusteriNo.Text = lvSatislar.SelectedItems[0].SubItems[8].Text;
            txtStok.Text = lvSatislar.SelectedItems[0].SubItems[9].Text;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Silmek İstiyor musunuz?","SİLİNSİN Mİ?",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                cFilmSatis fs = new cFilmSatis();
                if(fs.SatisIptal(Convert.ToInt32(txtSatisNo.Text)))
                {
                    MessageBox.Show("Satış bilgileri iptal edildi.");
                    //Film stok miktarı güncellenmeli
                    cFilm f = new cFilm();
                    bool Sonuc = f.StokGuncelleBySatisIptal(Convert.ToInt32(txtFilmNo.Text), Convert.ToInt32(txtAdet.Text));
                    if (Sonuc)
                        MessageBox.Show("Satış iptali gerçekleştirildi.");
                    else
                        MessageBox.Show("Satış iptali gerçekleşmedi.");

                }
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtAdet.Text) > Convert.ToInt32(txtStok.Text))
            {
                MessageBox.Show("Stok Miktarı yetersiz!");
                txtAdet.Text = txtStok.Text;
                txtAdet.Focus();
            }
            else
            {
                cFilmSatis fs = new cFilmSatis();
                fs.SatisNo = Convert.ToInt32(txtSatisNo.Text);
                fs.Tarih = Convert.ToDateTime(txtTarih.Text);
                fs.FilmNo = Convert.ToInt32(txtFilmNo.Text);
                fs.MusteriNo = Convert.ToInt32(txtMusteriNo.Text);
                fs.Adet = Convert.ToInt32(txtAdet.Text);
                fs.BirimFiyat = Convert.ToDouble(txtFiyat.Text);
                if (fs.SatisGuncelle(fs))
                {
                    MessageBox.Show("Satış Bilgileri değiştirildi.");
                    //Satılan filmin stok miktarı güncellenmeli 

                    if (Convert.ToInt32(txtAdet.Text) != ilkAdet)
                    {
                        cFilm f = new cFilm();

                        bool Sonuc = f.StokGuncelleBySatisDegistir(Convert.ToInt32(txtFilmNo.Text), Convert.ToInt32(txtAdet.Text),ilkAdet);
                        if (Sonuc)
                        {
                            MessageBox.Show("Stok Güncellendi!");
                            fs.SatislariGetir(lvSatislar, txtToplamAdet, txtToplamTutar);
                            Temizle();
                            btnKaydet.Enabled = false;
                            btnFilmBul.Enabled = false;
                            btnMusteriBul.Enabled = false;
                        }
                    }
                }
                else { MessageBox.Show("Satış kaydı gerçekleşmedi!"); }
            }
        }
    }
}
