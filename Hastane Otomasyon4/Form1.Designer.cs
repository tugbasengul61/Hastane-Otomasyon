namespace Hastane_Otomasyon4
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblhastaadi = new System.Windows.Forms.Label();
            this.lblhastasoyadi = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.lbldogumtarihi = new System.Windows.Forms.Label();
            this.lblanneadi = new System.Windows.Forms.Label();
            this.lblbabaadi = new System.Windows.Forms.Label();
            this.lbldogumyeri = new System.Windows.Forms.Label();
            this.lbltelefon = new System.Windows.Forms.Label();
            this.lblcinsiyet = new System.Windows.Forms.Label();
            this.txthastaadi = new System.Windows.Forms.TextBox();
            this.txthastasoyadi = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.mskdogumtarihi = new System.Windows.Forms.MaskedTextBox();
            this.txtanneadi = new System.Windows.Forms.TextBox();
            this.txtbabaadi = new System.Windows.Forms.TextBox();
            this.cmbdogumyeri = new System.Windows.Forms.ComboBox();
            this.msktelefon = new System.Windows.Forms.MaskedTextBox();
            this.rdbkadin = new System.Windows.Forms.RadioButton();
            this.rdberkek = new System.Windows.Forms.RadioButton();
            this.btngonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblhastaadi
            // 
            this.lblhastaadi.AutoSize = true;
            this.lblhastaadi.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblhastaadi.Location = new System.Drawing.Point(47, 64);
            this.lblhastaadi.Name = "lblhastaadi";
            this.lblhastaadi.Size = new System.Drawing.Size(94, 21);
            this.lblhastaadi.TabIndex = 0;
            this.lblhastaadi.Text = "Hasta Adı:";
            // 
            // lblhastasoyadi
            // 
            this.lblhastasoyadi.AutoSize = true;
            this.lblhastasoyadi.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblhastasoyadi.Location = new System.Drawing.Point(22, 108);
            this.lblhastasoyadi.Name = "lblhastasoyadi";
            this.lblhastasoyadi.Size = new System.Drawing.Size(120, 21);
            this.lblhastasoyadi.TabIndex = 1;
            this.lblhastasoyadi.Text = "Hasta Soyadı:";
            this.lblhastasoyadi.Click += new System.EventHandler(this.lblhastasoyadi_Click);
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltc.Location = new System.Drawing.Point(100, 152);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(39, 21);
            this.lbltc.TabIndex = 2;
            this.lbltc.Text = "TC:";
            // 
            // lbldogumtarihi
            // 
            this.lbldogumtarihi.AutoSize = true;
            this.lbldogumtarihi.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldogumtarihi.Location = new System.Drawing.Point(12, 201);
            this.lbldogumtarihi.Name = "lbldogumtarihi";
            this.lbldogumtarihi.Size = new System.Drawing.Size(127, 21);
            this.lbldogumtarihi.TabIndex = 3;
            this.lbldogumtarihi.Text = "Doğum Tarihi:";
            this.lbldogumtarihi.Click += new System.EventHandler(this.lbldogumtarihi_Click);
            // 
            // lblanneadi
            // 
            this.lblanneadi.AutoSize = true;
            this.lblanneadi.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblanneadi.Location = new System.Drawing.Point(49, 246);
            this.lblanneadi.Name = "lblanneadi";
            this.lblanneadi.Size = new System.Drawing.Size(90, 21);
            this.lblanneadi.TabIndex = 4;
            this.lblanneadi.Text = "Anne Adı:";
            // 
            // lblbabaadi
            // 
            this.lblbabaadi.AutoSize = true;
            this.lblbabaadi.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbabaadi.Location = new System.Drawing.Point(52, 294);
            this.lblbabaadi.Name = "lblbabaadi";
            this.lblbabaadi.Size = new System.Drawing.Size(87, 21);
            this.lblbabaadi.TabIndex = 5;
            this.lblbabaadi.Text = "Baba Adı:";
            // 
            // lbldogumyeri
            // 
            this.lbldogumyeri.AutoSize = true;
            this.lbldogumyeri.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldogumyeri.Location = new System.Drawing.Point(28, 346);
            this.lbldogumyeri.Name = "lbldogumyeri";
            this.lbldogumyeri.Size = new System.Drawing.Size(111, 21);
            this.lbldogumyeri.TabIndex = 6;
            this.lbldogumyeri.Text = "Doğum Yeri:";
            this.lbldogumyeri.Click += new System.EventHandler(this.lbldogumyeri_Click);
            // 
            // lbltelefon
            // 
            this.lbltelefon.AutoSize = true;
            this.lbltelefon.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltelefon.Location = new System.Drawing.Point(62, 397);
            this.lbltelefon.Name = "lbltelefon";
            this.lbltelefon.Size = new System.Drawing.Size(77, 21);
            this.lbltelefon.TabIndex = 7;
            this.lbltelefon.Text = "Telefon:";
            // 
            // lblcinsiyet
            // 
            this.lblcinsiyet.AutoSize = true;
            this.lblcinsiyet.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcinsiyet.Location = new System.Drawing.Point(58, 446);
            this.lblcinsiyet.Name = "lblcinsiyet";
            this.lblcinsiyet.Size = new System.Drawing.Size(81, 21);
            this.lblcinsiyet.TabIndex = 8;
            this.lblcinsiyet.Text = "Cinsiyet:";
            // 
            // txthastaadi
            // 
            this.txthastaadi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txthastaadi.Location = new System.Drawing.Point(153, 58);
            this.txthastaadi.Name = "txthastaadi";
            this.txthastaadi.Size = new System.Drawing.Size(193, 30);
            this.txthastaadi.TabIndex = 9;
            // 
            // txthastasoyadi
            // 
            this.txthastasoyadi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txthastasoyadi.Location = new System.Drawing.Point(153, 102);
            this.txthastasoyadi.Name = "txthastasoyadi";
            this.txthastasoyadi.Size = new System.Drawing.Size(193, 30);
            this.txthastasoyadi.TabIndex = 10;
            this.txthastasoyadi.TextChanged += new System.EventHandler(this.txthastasoyadi_TextChanged);
            // 
            // msktc
            // 
            this.msktc.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktc.Location = new System.Drawing.Point(153, 146);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(193, 30);
            this.msktc.TabIndex = 11;
            this.msktc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.msktc_MaskInputRejected);
            // 
            // mskdogumtarihi
            // 
            this.mskdogumtarihi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskdogumtarihi.Location = new System.Drawing.Point(153, 192);
            this.mskdogumtarihi.Mask = "00/00/0000";
            this.mskdogumtarihi.Name = "mskdogumtarihi";
            this.mskdogumtarihi.Size = new System.Drawing.Size(193, 30);
            this.mskdogumtarihi.TabIndex = 12;
            this.mskdogumtarihi.ValidatingType = typeof(System.DateTime);
            this.mskdogumtarihi.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskdogumtarihi_MaskInputRejected);
            // 
            // txtanneadi
            // 
            this.txtanneadi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtanneadi.Location = new System.Drawing.Point(153, 241);
            this.txtanneadi.Name = "txtanneadi";
            this.txtanneadi.Size = new System.Drawing.Size(193, 30);
            this.txtanneadi.TabIndex = 13;
            // 
            // txtbabaadi
            // 
            this.txtbabaadi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbabaadi.Location = new System.Drawing.Point(153, 289);
            this.txtbabaadi.Name = "txtbabaadi";
            this.txtbabaadi.Size = new System.Drawing.Size(193, 30);
            this.txtbabaadi.TabIndex = 14;
            // 
            // cmbdogumyeri
            // 
            this.cmbdogumyeri.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbdogumyeri.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbdogumyeri.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbdogumyeri.FormattingEnabled = true;
            this.cmbdogumyeri.Location = new System.Drawing.Point(153, 341);
            this.cmbdogumyeri.Name = "cmbdogumyeri";
            this.cmbdogumyeri.Size = new System.Drawing.Size(193, 32);
            this.cmbdogumyeri.TabIndex = 15;
            this.cmbdogumyeri.SelectedIndexChanged += new System.EventHandler(this.cmbdogumyeri_SelectedIndexChanged);
            // 
            // msktelefon
            // 
            this.msktelefon.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktelefon.Location = new System.Drawing.Point(153, 392);
            this.msktelefon.Mask = "(999) 000-0000";
            this.msktelefon.Name = "msktelefon";
            this.msktelefon.Size = new System.Drawing.Size(193, 30);
            this.msktelefon.TabIndex = 16;
            // 
            // rdbkadin
            // 
            this.rdbkadin.AutoSize = true;
            this.rdbkadin.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbkadin.Location = new System.Drawing.Point(153, 442);
            this.rdbkadin.Name = "rdbkadin";
            this.rdbkadin.Size = new System.Drawing.Size(84, 28);
            this.rdbkadin.TabIndex = 17;
            this.rdbkadin.TabStop = true;
            this.rdbkadin.Text = "Kadın";
            this.rdbkadin.UseVisualStyleBackColor = true;
            this.rdbkadin.CheckedChanged += new System.EventHandler(this.rdbkadin_CheckedChanged);
            // 
            // rdberkek
            // 
            this.rdberkek.AutoSize = true;
            this.rdberkek.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdberkek.Location = new System.Drawing.Point(262, 442);
            this.rdberkek.Name = "rdberkek";
            this.rdberkek.Size = new System.Drawing.Size(84, 28);
            this.rdberkek.TabIndex = 18;
            this.rdberkek.TabStop = true;
            this.rdberkek.Text = "Erkek";
            this.rdberkek.UseVisualStyleBackColor = true;
            this.rdberkek.CheckedChanged += new System.EventHandler(this.rdberkek_CheckedChanged);
            // 
            // btngonder
            // 
            this.btngonder.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngonder.Location = new System.Drawing.Point(125, 493);
            this.btngonder.Name = "btngonder";
            this.btngonder.Size = new System.Drawing.Size(129, 34);
            this.btngonder.TabIndex = 19;
            this.btngonder.Text = "Gönder";
            this.btngonder.UseVisualStyleBackColor = true;
            this.btngonder.Click += new System.EventHandler(this.btngonder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 663);
            this.Controls.Add(this.btngonder);
            this.Controls.Add(this.rdberkek);
            this.Controls.Add(this.rdbkadin);
            this.Controls.Add(this.msktelefon);
            this.Controls.Add(this.cmbdogumyeri);
            this.Controls.Add(this.txtbabaadi);
            this.Controls.Add(this.txtanneadi);
            this.Controls.Add(this.mskdogumtarihi);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.txthastasoyadi);
            this.Controls.Add(this.txthastaadi);
            this.Controls.Add(this.lblcinsiyet);
            this.Controls.Add(this.lbltelefon);
            this.Controls.Add(this.lbldogumyeri);
            this.Controls.Add(this.lblbabaadi);
            this.Controls.Add(this.lblanneadi);
            this.Controls.Add(this.lbldogumtarihi);
            this.Controls.Add(this.lbltc);
            this.Controls.Add(this.lblhastasoyadi);
            this.Controls.Add(this.lblhastaadi);
            this.Name = "Form1";
            this.Text = "Hasta Kayıt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhastaadi;
        private System.Windows.Forms.Label lblhastasoyadi;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label lbldogumtarihi;
        private System.Windows.Forms.Label lblanneadi;
        private System.Windows.Forms.Label lblbabaadi;
        private System.Windows.Forms.Label lbldogumyeri;
        private System.Windows.Forms.Label lbltelefon;
        private System.Windows.Forms.Label lblcinsiyet;
        private System.Windows.Forms.TextBox txthastaadi;
        private System.Windows.Forms.TextBox txthastasoyadi;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.MaskedTextBox mskdogumtarihi;
        private System.Windows.Forms.TextBox txtanneadi;
        private System.Windows.Forms.TextBox txtbabaadi;
        private System.Windows.Forms.ComboBox cmbdogumyeri;
        private System.Windows.Forms.MaskedTextBox msktelefon;
        private System.Windows.Forms.RadioButton rdbkadin;
        private System.Windows.Forms.RadioButton rdberkek;
        private System.Windows.Forms.Button btngonder;
    }
}

