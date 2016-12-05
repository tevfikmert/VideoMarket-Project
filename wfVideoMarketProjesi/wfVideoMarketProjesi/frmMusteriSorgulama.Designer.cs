namespace wfVideoMarketProjesi
{
    partial class frmMusteriSorgulama
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
            this.lvMusteriler = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtAdaGore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoyadaGore = new System.Windows.Forms.TextBox();
            this.txtTelefonaGore = new System.Windows.Forms.TextBox();
            this.txtAdreseGore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvMusteriler
            // 
            this.lvMusteriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvMusteriler.FullRowSelect = true;
            this.lvMusteriler.Location = new System.Drawing.Point(67, 101);
            this.lvMusteriler.Name = "lvMusteriler";
            this.lvMusteriler.Size = new System.Drawing.Size(521, 245);
            this.lvMusteriler.TabIndex = 15;
            this.lvMusteriler.UseCompatibleStateImageBehavior = false;
            this.lvMusteriler.View = System.Windows.Forms.View.Details;
            this.lvMusteriler.DoubleClick += new System.EventHandler(this.lvMusteriler_DoubleClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "MusteriNo";
            this.columnHeader5.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MüşteriAdı";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyadı";
            this.columnHeader2.Width = 109;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Telefon";
            this.columnHeader3.Width = 102;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Adres";
            this.columnHeader4.Width = 210;
            // 
            // txtAdaGore
            // 
            this.txtAdaGore.Location = new System.Drawing.Point(67, 75);
            this.txtAdaGore.Name = "txtAdaGore";
            this.txtAdaGore.Size = new System.Drawing.Size(91, 20);
            this.txtAdaGore.TabIndex = 18;
            this.txtAdaGore.TextChanged += new System.EventHandler(this.txtAdaGore_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Müşteri Adına Göre";
            // 
            // txtSoyadaGore
            // 
            this.txtSoyadaGore.Location = new System.Drawing.Point(159, 75);
            this.txtSoyadaGore.Name = "txtSoyadaGore";
            this.txtSoyadaGore.Size = new System.Drawing.Size(105, 20);
            this.txtSoyadaGore.TabIndex = 19;
            this.txtSoyadaGore.TextChanged += new System.EventHandler(this.txtSoyadaGore_TextChanged);
            // 
            // txtTelefonaGore
            // 
            this.txtTelefonaGore.Location = new System.Drawing.Point(266, 75);
            this.txtTelefonaGore.Name = "txtTelefonaGore";
            this.txtTelefonaGore.Size = new System.Drawing.Size(101, 20);
            this.txtTelefonaGore.TabIndex = 20;
            this.txtTelefonaGore.TextChanged += new System.EventHandler(this.txtTelefonaGore_TextChanged);
            // 
            // txtAdreseGore
            // 
            this.txtAdreseGore.Location = new System.Drawing.Point(369, 75);
            this.txtAdreseGore.Name = "txtAdreseGore";
            this.txtAdreseGore.Size = new System.Drawing.Size(211, 20);
            this.txtAdreseGore.TabIndex = 21;
            this.txtAdreseGore.TextChanged += new System.EventHandler(this.txtAdreseGore_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Soyadına Göre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Telefona Göre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Adrese Göre Arama";
            // 
            // frmMusteriSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 383);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdreseGore);
            this.Controls.Add(this.txtTelefonaGore);
            this.Controls.Add(this.txtSoyadaGore);
            this.Controls.Add(this.txtAdaGore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvMusteriler);
            this.Name = "frmMusteriSorgulama";
            this.Text = "Müşteri Sorgulama";
            this.Load += new System.EventHandler(this.frmMusteriSorgulama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvMusteriler;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtAdaGore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoyadaGore;
        private System.Windows.Forms.TextBox txtTelefonaGore;
        private System.Windows.Forms.TextBox txtAdreseGore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}