namespace Hastane_Otomasyon4
{
    partial class Randevu
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
            this.lblhastatc = new System.Windows.Forms.Label();
            this.cmbklinik = new System.Windows.Forms.ComboBox();
            this.lblklinik = new System.Windows.Forms.Label();
            this.lbldoktor = new System.Windows.Forms.Label();
            this.cmbdoktor = new System.Windows.Forms.ComboBox();
            this.lbltarih = new System.Windows.Forms.Label();
            this.lblsaat = new System.Windows.Forms.Label();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.mskhastatc = new System.Windows.Forms.MaskedTextBox();
            this.dtptarih = new System.Windows.Forms.DateTimePicker();
            this.dtpsaat = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblhastatc
            // 
            this.lblhastatc.AutoSize = true;
            this.lblhastatc.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhastatc.Location = new System.Drawing.Point(117, 67);
            this.lblhastatc.Name = "lblhastatc";
            this.lblhastatc.Size = new System.Drawing.Size(99, 20);
            this.lblhastatc.TabIndex = 0;
            this.lblhastatc.Text = "Hasta T.C. :";
            // 
            // cmbklinik
            // 
            this.cmbklinik.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbklinik.FormattingEnabled = true;
            this.cmbklinik.Location = new System.Drawing.Point(238, 117);
            this.cmbklinik.Name = "cmbklinik";
            this.cmbklinik.Size = new System.Drawing.Size(214, 29);
            this.cmbklinik.TabIndex = 1;
            this.cmbklinik.SelectedIndexChanged += new System.EventHandler(this.cmbklinik_SelectedIndexChanged);
            // 
            // lblklinik
            // 
            this.lblklinik.AutoSize = true;
            this.lblklinik.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblklinik.Location = new System.Drawing.Point(152, 117);
            this.lblklinik.Name = "lblklinik";
            this.lblklinik.Size = new System.Drawing.Size(64, 20);
            this.lblklinik.TabIndex = 3;
            this.lblklinik.Text = "Klinik :";
            // 
            // lbldoktor
            // 
            this.lbldoktor.AutoSize = true;
            this.lbldoktor.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldoktor.Location = new System.Drawing.Point(145, 173);
            this.lbldoktor.Name = "lbldoktor";
            this.lbldoktor.Size = new System.Drawing.Size(71, 20);
            this.lbldoktor.TabIndex = 4;
            this.lbldoktor.Text = "Doktor :";
            // 
            // cmbdoktor
            // 
            this.cmbdoktor.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbdoktor.FormattingEnabled = true;
            this.cmbdoktor.Location = new System.Drawing.Point(238, 173);
            this.cmbdoktor.Name = "cmbdoktor";
            this.cmbdoktor.Size = new System.Drawing.Size(214, 29);
            this.cmbdoktor.TabIndex = 5;
            // 
            // lbltarih
            // 
            this.lbltarih.AutoSize = true;
            this.lbltarih.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltarih.Location = new System.Drawing.Point(22, 233);
            this.lbltarih.Name = "lbltarih";
            this.lbltarih.Size = new System.Drawing.Size(194, 20);
            this.lbltarih.TabIndex = 6;
            this.lbltarih.Text = "Randevu Tarihi Seçiniz :";
            // 
            // lblsaat
            // 
            this.lblsaat.AutoSize = true;
            this.lblsaat.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsaat.Location = new System.Drawing.Point(30, 284);
            this.lblsaat.Name = "lblsaat";
            this.lblsaat.Size = new System.Drawing.Size(186, 20);
            this.lblsaat.TabIndex = 8;
            this.lblsaat.Text = "Randevu Saati Seçiniz :";
            // 
            // btnkaydet
            // 
            this.btnkaydet.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Location = new System.Drawing.Point(156, 348);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(101, 48);
            this.btnkaydet.TabIndex = 10;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // mskhastatc
            // 
            this.mskhastatc.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskhastatc.Location = new System.Drawing.Point(238, 63);
            this.mskhastatc.Mask = "00000000000";
            this.mskhastatc.Name = "mskhastatc";
            this.mskhastatc.Size = new System.Drawing.Size(214, 28);
            this.mskhastatc.TabIndex = 11;
            this.mskhastatc.ValidatingType = typeof(System.DateTime);
            // 
            // dtptarih
            // 
            this.dtptarih.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtptarih.Location = new System.Drawing.Point(238, 233);
            this.dtptarih.Name = "dtptarih";
            this.dtptarih.Size = new System.Drawing.Size(214, 27);
            this.dtptarih.TabIndex = 12;
            // 
            // dtpsaat
            // 
            this.dtpsaat.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpsaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpsaat.Location = new System.Drawing.Point(238, 284);
            this.dtpsaat.Name = "dtpsaat";
            this.dtpsaat.Size = new System.Drawing.Size(214, 27);
            this.dtpsaat.TabIndex = 13;
            this.dtpsaat.Value = new System.DateTime(2023, 6, 1, 0, 0, 0, 0);
            // 
            // Randevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 547);
            this.Controls.Add(this.dtpsaat);
            this.Controls.Add(this.dtptarih);
            this.Controls.Add(this.mskhastatc);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.lblsaat);
            this.Controls.Add(this.lbltarih);
            this.Controls.Add(this.cmbdoktor);
            this.Controls.Add(this.lbldoktor);
            this.Controls.Add(this.lblklinik);
            this.Controls.Add(this.cmbklinik);
            this.Controls.Add(this.lblhastatc);
            this.Name = "Randevu";
            this.Text = "Randevu";
            this.Load += new System.EventHandler(this.Randevu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhastatc;
        private System.Windows.Forms.ComboBox cmbklinik;
        private System.Windows.Forms.Label lblklinik;
        private System.Windows.Forms.Label lbldoktor;
        private System.Windows.Forms.ComboBox cmbdoktor;
        private System.Windows.Forms.Label lbltarih;
        private System.Windows.Forms.Label lblsaat;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.MaskedTextBox mskhastatc;
        private System.Windows.Forms.DateTimePicker dtptarih;
        private System.Windows.Forms.DateTimePicker dtpsaat;
    }
}