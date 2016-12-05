namespace wfVideoMarketProjesi
{
    partial class frmAnaSayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuAnaSayfa = new System.Windows.Forms.MenuStrip();
            this.filmBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmFilmTanimlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmFilmTuru = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmFilmSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmMusteriTanimlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmMusteriSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.satışİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmFilmSatis = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmSatisSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmDetaylıSatisRaporu = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnaSayfa.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAnaSayfa
            // 
            this.mnuAnaSayfa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuAnaSayfa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmBilgileriToolStripMenuItem,
            this.müşterilerToolStripMenuItem,
            this.satışİşlemleriToolStripMenuItem,
            this.raporlamaToolStripMenuItem,
            this.mitmCikis});
            this.mnuAnaSayfa.Location = new System.Drawing.Point(0, 0);
            this.mnuAnaSayfa.Name = "mnuAnaSayfa";
            this.mnuAnaSayfa.Size = new System.Drawing.Size(775, 27);
            this.mnuAnaSayfa.TabIndex = 1;
            this.mnuAnaSayfa.Text = "menuStrip1";
            // 
            // filmBilgileriToolStripMenuItem
            // 
            this.filmBilgileriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmFilmTanimlama,
            this.mitmFilmTuru,
            this.mitmFilmSorgulama});
            this.filmBilgileriToolStripMenuItem.Name = "filmBilgileriToolStripMenuItem";
            this.filmBilgileriToolStripMenuItem.Size = new System.Drawing.Size(93, 23);
            this.filmBilgileriToolStripMenuItem.Text = "Film Bilgileri";
            // 
            // mitmFilmTanimlama
            // 
            this.mitmFilmTanimlama.Name = "mitmFilmTanimlama";
            this.mitmFilmTanimlama.Size = new System.Drawing.Size(203, 24);
            this.mitmFilmTanimlama.Text = "Film Tanımlama";
            this.mitmFilmTanimlama.Click += new System.EventHandler(this.mitmFilmTanimlama_Click);
            // 
            // mitmFilmTuru
            // 
            this.mitmFilmTuru.Name = "mitmFilmTuru";
            this.mitmFilmTuru.Size = new System.Drawing.Size(203, 24);
            this.mitmFilmTuru.Text = "Film Türü Tanımlama";
            this.mitmFilmTuru.Click += new System.EventHandler(this.mitmFilmTuru_Click);
            // 
            // mitmFilmSorgulama
            // 
            this.mitmFilmSorgulama.Name = "mitmFilmSorgulama";
            this.mitmFilmSorgulama.Size = new System.Drawing.Size(203, 24);
            this.mitmFilmSorgulama.Text = "Film Sorgulama";
            this.mitmFilmSorgulama.Click += new System.EventHandler(this.mitmFilmSorgulama_Click);
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmMusteriTanimlama,
            this.mitmMusteriSorgulama});
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(83, 23);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            // 
            // mitmMusteriTanimlama
            // 
            this.mitmMusteriTanimlama.Name = "mitmMusteriTanimlama";
            this.mitmMusteriTanimlama.Size = new System.Drawing.Size(194, 24);
            this.mitmMusteriTanimlama.Text = "Müşteri Tanımlama";
            this.mitmMusteriTanimlama.Click += new System.EventHandler(this.mitmMusteriTanimlama_Click);
            // 
            // mitmMusteriSorgulama
            // 
            this.mitmMusteriSorgulama.Name = "mitmMusteriSorgulama";
            this.mitmMusteriSorgulama.Size = new System.Drawing.Size(194, 24);
            this.mitmMusteriSorgulama.Text = "Müşteri Sorgulama";
            this.mitmMusteriSorgulama.Click += new System.EventHandler(this.mitmMusteriSorgulama_Click);
            // 
            // satışİşlemleriToolStripMenuItem
            // 
            this.satışİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmFilmSatis,
            this.mitmSatisSorgulama});
            this.satışİşlemleriToolStripMenuItem.Name = "satışİşlemleriToolStripMenuItem";
            this.satışİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(103, 23);
            this.satışİşlemleriToolStripMenuItem.Text = "Satış İşlemleri";
            // 
            // mitmFilmSatis
            // 
            this.mitmFilmSatis.Name = "mitmFilmSatis";
            this.mitmFilmSatis.Size = new System.Drawing.Size(175, 24);
            this.mitmFilmSatis.Text = "Film Satış";
            this.mitmFilmSatis.Click += new System.EventHandler(this.mitmFilmSatis_Click);
            // 
            // mitmSatisSorgulama
            // 
            this.mitmSatisSorgulama.Name = "mitmSatisSorgulama";
            this.mitmSatisSorgulama.Size = new System.Drawing.Size(175, 24);
            this.mitmSatisSorgulama.Text = "Satış Sorgulama";
            this.mitmSatisSorgulama.Click += new System.EventHandler(this.mitmSatisSorgulama_Click);
            // 
            // raporlamaToolStripMenuItem
            // 
            this.raporlamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmDetaylıSatisRaporu});
            this.raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            this.raporlamaToolStripMenuItem.Size = new System.Drawing.Size(86, 23);
            this.raporlamaToolStripMenuItem.Text = "Raporlama";
            // 
            // mitmDetaylıSatisRaporu
            // 
            this.mitmDetaylıSatisRaporu.Name = "mitmDetaylıSatisRaporu";
            this.mitmDetaylıSatisRaporu.Size = new System.Drawing.Size(200, 24);
            this.mitmDetaylıSatisRaporu.Text = "Detaylı Satış Raporu";
            this.mitmDetaylıSatisRaporu.Click += new System.EventHandler(this.mitmDetaylıSatisRaporu_Click);
            // 
            // mitmCikis
            // 
            this.mitmCikis.Name = "mitmCikis";
            this.mitmCikis.Size = new System.Drawing.Size(49, 23);
            this.mitmCikis.Text = "Çıkış";
            this.mitmCikis.Click += new System.EventHandler(this.mitmCikis_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 427);
            this.Controls.Add(this.mnuAnaSayfa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuAnaSayfa;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAnaSayfa";
            this.Text = "VideoMarket AnaSayfa İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuAnaSayfa.ResumeLayout(false);
            this.mnuAnaSayfa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAnaSayfa;
        private System.Windows.Forms.ToolStripMenuItem filmBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitmFilmTanimlama;
        private System.Windows.Forms.ToolStripMenuItem mitmFilmTuru;
        private System.Windows.Forms.ToolStripMenuItem mitmFilmSorgulama;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitmMusteriTanimlama;
        private System.Windows.Forms.ToolStripMenuItem mitmMusteriSorgulama;
        private System.Windows.Forms.ToolStripMenuItem satışİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitmFilmSatis;
        private System.Windows.Forms.ToolStripMenuItem mitmSatisSorgulama;
        private System.Windows.Forms.ToolStripMenuItem raporlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitmDetaylıSatisRaporu;
        private System.Windows.Forms.ToolStripMenuItem mitmCikis;
    }
}