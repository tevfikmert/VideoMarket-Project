namespace wfVideoMarketProjesi
{
    partial class frmDetayliSatisRaporu
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.btnGetir = new System.Windows.Forms.Button();
            this.dtpTarih2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTarih1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VideoMarketDataSet = new wfVideoMarketProjesi.VideoMarketDataSet();
            this.vw_DetayliSatisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_DetayliSatisTableAdapter = new wfVideoMarketProjesi.VideoMarketDataSetTableAdapters.vw_DetayliSatisTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VideoMarketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_DetayliSatisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(263, 119);
            this.btnGetir.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(163, 28);
            this.btnGetir.TabIndex = 50;
            this.btnGetir.Text = "Satışları Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // dtpTarih2
            // 
            this.dtpTarih2.Location = new System.Drawing.Point(412, 63);
            this.dtpTarih2.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTarih2.Name = "dtpTarih2";
            this.dtpTarih2.Size = new System.Drawing.Size(141, 20);
            this.dtpTarih2.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Son Tarih";
            // 
            // dtpTarih1
            // 
            this.dtpTarih1.Location = new System.Drawing.Point(137, 63);
            this.dtpTarih1.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTarih1.Name = "dtpTarih1";
            this.dtpTarih1.Size = new System.Drawing.Size(141, 20);
            this.dtpTarih1.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "İlk Tarih";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vw_DetayliSatisBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "wfVideoMarketProjesi.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(49, 154);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(634, 246);
            this.reportViewer1.TabIndex = 51;
            // 
            // VideoMarketDataSet
            // 
            this.VideoMarketDataSet.DataSetName = "VideoMarketDataSet";
            this.VideoMarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_DetayliSatisBindingSource
            // 
            this.vw_DetayliSatisBindingSource.DataMember = "vw_DetayliSatis";
            this.vw_DetayliSatisBindingSource.DataSource = this.VideoMarketDataSet;
            // 
            // vw_DetayliSatisTableAdapter
            // 
            this.vw_DetayliSatisTableAdapter.ClearBeforeFill = true;
            // 
            // frmDetayliSatisRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 443);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.dtpTarih2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpTarih1);
            this.Controls.Add(this.label1);
            this.Name = "frmDetayliSatisRaporu";
            this.Text = "frmDetayliSatisRaporu";
            this.Load += new System.EventHandler(this.frmDetayliSatisRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VideoMarketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_DetayliSatisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.DateTimePicker dtpTarih2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTarih1;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vw_DetayliSatisBindingSource;
        private VideoMarketDataSet VideoMarketDataSet;
        private VideoMarketDataSetTableAdapters.vw_DetayliSatisTableAdapter vw_DetayliSatisTableAdapter;
    }
}