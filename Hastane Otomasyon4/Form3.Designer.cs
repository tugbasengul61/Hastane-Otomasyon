namespace Hastane_Otomasyon4
{
    partial class frmguncelle
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
            this.dgvguncelle = new System.Windows.Forms.DataGridView();
            this.Hastaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HastaTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HastaAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HastaSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HastaBabaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HastaAnneAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HastaDogumTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HastaDogumYeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HastaTelefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HastaCinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasta1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneOtomasyonDataSet1 = new Hastane_Otomasyon4.HastaneOtomasyonDataSet1();
            this.hasta1TableAdapter = new Hastane_Otomasyon4.HastaneOtomasyonDataSet1TableAdapters.hasta1TableAdapter();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvguncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hasta1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvguncelle
            // 
            this.dgvguncelle.AutoGenerateColumns = false;
            this.dgvguncelle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvguncelle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hastaid,
            this.HastaTC,
            this.HastaAd,
            this.HastaSoyad,
            this.HastaBabaAdi,
            this.HastaAnneAdi,
            this.HastaDogumTarihi,
            this.HastaDogumYeri,
            this.HastaTelefon,
            this.HastaCinsiyet});
            this.dgvguncelle.DataSource = this.hasta1BindingSource;
            this.dgvguncelle.Location = new System.Drawing.Point(-2, 1);
            this.dgvguncelle.Name = "dgvguncelle";
            this.dgvguncelle.RowHeadersWidth = 51;
            this.dgvguncelle.RowTemplate.Height = 24;
            this.dgvguncelle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvguncelle.Size = new System.Drawing.Size(1760, 573);
            this.dgvguncelle.TabIndex = 0;
            this.dgvguncelle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvguncelle_CellContentClick);
            // 
            // Hastaid
            // 
            this.Hastaid.DataPropertyName = "Hastaid";
            this.Hastaid.HeaderText = "Hastaid";
            this.Hastaid.MinimumWidth = 6;
            this.Hastaid.Name = "Hastaid";
            this.Hastaid.ReadOnly = true;
            this.Hastaid.Width = 125;
            // 
            // HastaTC
            // 
            this.HastaTC.DataPropertyName = "HastaTC";
            this.HastaTC.HeaderText = "HastaTC";
            this.HastaTC.MinimumWidth = 6;
            this.HastaTC.Name = "HastaTC";
            this.HastaTC.Width = 125;
            // 
            // HastaAd
            // 
            this.HastaAd.DataPropertyName = "HastaAd";
            this.HastaAd.HeaderText = "HastaAd";
            this.HastaAd.MinimumWidth = 6;
            this.HastaAd.Name = "HastaAd";
            this.HastaAd.Width = 125;
            // 
            // HastaSoyad
            // 
            this.HastaSoyad.DataPropertyName = "HastaSoyad";
            this.HastaSoyad.HeaderText = "HastaSoyad";
            this.HastaSoyad.MinimumWidth = 6;
            this.HastaSoyad.Name = "HastaSoyad";
            this.HastaSoyad.Width = 125;
            // 
            // HastaBabaAdi
            // 
            this.HastaBabaAdi.DataPropertyName = "HastaBabaAdi";
            this.HastaBabaAdi.HeaderText = "HastaBabaAdi";
            this.HastaBabaAdi.MinimumWidth = 6;
            this.HastaBabaAdi.Name = "HastaBabaAdi";
            this.HastaBabaAdi.Width = 125;
            // 
            // HastaAnneAdi
            // 
            this.HastaAnneAdi.DataPropertyName = "HastaAnneAdi";
            this.HastaAnneAdi.HeaderText = "HastaAnneAdi";
            this.HastaAnneAdi.MinimumWidth = 6;
            this.HastaAnneAdi.Name = "HastaAnneAdi";
            this.HastaAnneAdi.Width = 125;
            // 
            // HastaDogumTarihi
            // 
            this.HastaDogumTarihi.DataPropertyName = "HastaDogumTarihi";
            this.HastaDogumTarihi.HeaderText = "HastaDogumTarihi";
            this.HastaDogumTarihi.MinimumWidth = 6;
            this.HastaDogumTarihi.Name = "HastaDogumTarihi";
            this.HastaDogumTarihi.Width = 125;
            // 
            // HastaDogumYeri
            // 
            this.HastaDogumYeri.DataPropertyName = "HastaDogumYeri";
            this.HastaDogumYeri.HeaderText = "HastaDogumYeri";
            this.HastaDogumYeri.MinimumWidth = 6;
            this.HastaDogumYeri.Name = "HastaDogumYeri";
            this.HastaDogumYeri.Width = 125;
            // 
            // HastaTelefon
            // 
            this.HastaTelefon.DataPropertyName = "HastaTelefon";
            this.HastaTelefon.HeaderText = "HastaTelefon";
            this.HastaTelefon.MinimumWidth = 6;
            this.HastaTelefon.Name = "HastaTelefon";
            this.HastaTelefon.Width = 125;
            // 
            // HastaCinsiyet
            // 
            this.HastaCinsiyet.DataPropertyName = "HastaCinsiyet";
            this.HastaCinsiyet.HeaderText = "HastaCinsiyet";
            this.HastaCinsiyet.MinimumWidth = 6;
            this.HastaCinsiyet.Name = "HastaCinsiyet";
            this.HastaCinsiyet.Width = 125;
            // 
            // hasta1BindingSource
            // 
            this.hasta1BindingSource.DataMember = "hasta1";
            this.hasta1BindingSource.DataSource = this.hastaneOtomasyonDataSet1;
            // 
            // hastaneOtomasyonDataSet1
            // 
            this.hastaneOtomasyonDataSet1.DataSetName = "HastaneOtomasyonDataSet1";
            this.hastaneOtomasyonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hasta1TableAdapter
            // 
            this.hasta1TableAdapter.ClearBeforeFill = true;
            // 
            // btnguncelle
            // 
            this.btnguncelle.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.Location = new System.Drawing.Point(1462, 621);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(140, 39);
            this.btnguncelle.TabIndex = 2;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(1294, 621);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(140, 39);
            this.btnsil.TabIndex = 3;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // frmguncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1758, 688);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.dgvguncelle);
            this.Name = "frmguncelle";
            this.Text = "Bilgileri Güncelle";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvguncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hasta1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvguncelle;
        private HastaneOtomasyonDataSet1 hastaneOtomasyonDataSet1;
        private System.Windows.Forms.BindingSource hasta1BindingSource;
        private HastaneOtomasyonDataSet1TableAdapters.hasta1TableAdapter hasta1TableAdapter;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hastaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaBabaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaAnneAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaDogumTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaDogumYeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaTelefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaCinsiyet;
        private System.Windows.Forms.Button btnsil;
    }
}