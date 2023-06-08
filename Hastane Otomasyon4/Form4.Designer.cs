namespace Hastane_Otomasyon4
{
    partial class Form4
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
            this.hastaneOtomasyonDataSet = new Hastane_Otomasyon4.HastaneOtomasyonDataSet();
            this.hasta1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hasta1TableAdapter = new Hastane_Otomasyon4.HastaneOtomasyonDataSetTableAdapters.hasta1TableAdapter();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.hastaneOtomasyonDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvrandevu = new System.Windows.Forms.DataGridView();
            this.hastaneOtomasyonDataSet3 = new Hastane_Otomasyon4.HastaneOtomasyonDataSet3();
            this.hastaneOtomasyonDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneOtomasyonDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.updateOrderOptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.randevu1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.randevu1TableAdapter = new Hastane_Otomasyon4.HastaneOtomasyonDataSet3TableAdapters.Randevu1TableAdapter();
            this.randevuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klinikAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hasta1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrandevu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateOrderOptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevu1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hastaneOtomasyonDataSet
            // 
            this.hastaneOtomasyonDataSet.DataSetName = "HastaneOtomasyonDataSet";
            this.hastaneOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hasta1BindingSource
            // 
            this.hasta1BindingSource.DataMember = "hasta1";
            this.hasta1BindingSource.DataSource = this.hastaneOtomasyonDataSet;
            // 
            // hasta1TableAdapter
            // 
            this.hasta1TableAdapter.ClearBeforeFill = true;
            // 
            // btnsil
            // 
            this.btnsil.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(1060, 533);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(123, 44);
            this.btnsil.TabIndex = 1;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.Location = new System.Drawing.Point(1219, 533);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(135, 44);
            this.btnguncelle.TabIndex = 2;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // hastaneOtomasyonDataSetBindingSource
            // 
            this.hastaneOtomasyonDataSetBindingSource.DataSource = this.hastaneOtomasyonDataSet;
            this.hastaneOtomasyonDataSetBindingSource.Position = 0;
            // 
            // dgvrandevu
            // 
            this.dgvrandevu.AutoGenerateColumns = false;
            this.dgvrandevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrandevu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.randevuidDataGridViewTextBoxColumn,
            this.hastaTCDataGridViewTextBoxColumn,
            this.randevuTarihDataGridViewTextBoxColumn,
            this.klinikAdiDataGridViewTextBoxColumn,
            this.doktorAdDataGridViewTextBoxColumn});
            this.dgvrandevu.DataSource = this.randevu1BindingSource;
            this.dgvrandevu.Location = new System.Drawing.Point(0, 0);
            this.dgvrandevu.Name = "dgvrandevu";
            this.dgvrandevu.RowHeadersWidth = 51;
            this.dgvrandevu.RowTemplate.Height = 24;
            this.dgvrandevu.Size = new System.Drawing.Size(1412, 500);
            this.dgvrandevu.TabIndex = 3;
            // 
            // hastaneOtomasyonDataSet3
            // 
            this.hastaneOtomasyonDataSet3.DataSetName = "HastaneOtomasyonDataSet3";
            this.hastaneOtomasyonDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaneOtomasyonDataSet3BindingSource
            // 
            this.hastaneOtomasyonDataSet3BindingSource.DataSource = this.hastaneOtomasyonDataSet3;
            this.hastaneOtomasyonDataSet3BindingSource.Position = 0;
            // 
            // hastaneOtomasyonDataSetBindingSource1
            // 
            this.hastaneOtomasyonDataSetBindingSource1.DataSource = this.hastaneOtomasyonDataSet;
            this.hastaneOtomasyonDataSetBindingSource1.Position = 0;
            // 
            // updateOrderOptionBindingSource
            // 
            this.updateOrderOptionBindingSource.DataSource = typeof(Hastane_Otomasyon4.HastaneOtomasyonDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption);
            // 
            // randevu1BindingSource
            // 
            this.randevu1BindingSource.DataMember = "Randevu1";
            this.randevu1BindingSource.DataSource = this.hastaneOtomasyonDataSet3BindingSource;
            // 
            // randevu1TableAdapter
            // 
            this.randevu1TableAdapter.ClearBeforeFill = true;
            // 
            // randevuidDataGridViewTextBoxColumn
            // 
            this.randevuidDataGridViewTextBoxColumn.DataPropertyName = "Randevuid";
            this.randevuidDataGridViewTextBoxColumn.HeaderText = "Randevuid";
            this.randevuidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.randevuidDataGridViewTextBoxColumn.Name = "randevuidDataGridViewTextBoxColumn";
            this.randevuidDataGridViewTextBoxColumn.ReadOnly = true;
            this.randevuidDataGridViewTextBoxColumn.Width = 125;
            // 
            // hastaTCDataGridViewTextBoxColumn
            // 
            this.hastaTCDataGridViewTextBoxColumn.DataPropertyName = "HastaTC";
            this.hastaTCDataGridViewTextBoxColumn.HeaderText = "HastaTC";
            this.hastaTCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hastaTCDataGridViewTextBoxColumn.Name = "hastaTCDataGridViewTextBoxColumn";
            this.hastaTCDataGridViewTextBoxColumn.Width = 125;
            // 
            // randevuTarihDataGridViewTextBoxColumn
            // 
            this.randevuTarihDataGridViewTextBoxColumn.DataPropertyName = "RandevuTarih";
            this.randevuTarihDataGridViewTextBoxColumn.HeaderText = "RandevuTarih";
            this.randevuTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.randevuTarihDataGridViewTextBoxColumn.Name = "randevuTarihDataGridViewTextBoxColumn";
            this.randevuTarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // klinikAdiDataGridViewTextBoxColumn
            // 
            this.klinikAdiDataGridViewTextBoxColumn.DataPropertyName = "KlinikAdi";
            this.klinikAdiDataGridViewTextBoxColumn.HeaderText = "KlinikAdi";
            this.klinikAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.klinikAdiDataGridViewTextBoxColumn.Name = "klinikAdiDataGridViewTextBoxColumn";
            this.klinikAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // doktorAdDataGridViewTextBoxColumn
            // 
            this.doktorAdDataGridViewTextBoxColumn.DataPropertyName = "DoktorAd";
            this.doktorAdDataGridViewTextBoxColumn.HeaderText = "DoktorAd";
            this.doktorAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doktorAdDataGridViewTextBoxColumn.Name = "doktorAdDataGridViewTextBoxColumn";
            this.doktorAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 597);
            this.Controls.Add(this.dgvrandevu);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hasta1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrandevu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateOrderOptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevu1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private HastaneOtomasyonDataSet hastaneOtomasyonDataSet;
        private System.Windows.Forms.BindingSource hasta1BindingSource;
        private HastaneOtomasyonDataSetTableAdapters.hasta1TableAdapter hasta1TableAdapter;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.BindingSource hastaneOtomasyonDataSetBindingSource;
        private System.Windows.Forms.DataGridView dgvrandevu;
        private System.Windows.Forms.BindingSource hastaneOtomasyonDataSetBindingSource1;
        private HastaneOtomasyonDataSet3 hastaneOtomasyonDataSet3;
        private System.Windows.Forms.BindingSource hastaneOtomasyonDataSet3BindingSource;
        private System.Windows.Forms.BindingSource updateOrderOptionBindingSource;
        private System.Windows.Forms.BindingSource randevu1BindingSource;
        private HastaneOtomasyonDataSet3TableAdapters.Randevu1TableAdapter randevu1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klinikAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorAdDataGridViewTextBoxColumn;
    }
}