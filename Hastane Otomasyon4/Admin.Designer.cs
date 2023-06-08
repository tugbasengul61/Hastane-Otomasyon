namespace Hastane_Otomasyon4
{
    partial class Admin
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
            this.lblkullaniciadi = new System.Windows.Forms.Label();
            this.lblsifre = new System.Windows.Forms.Label();
            this.txtkullaniciadi = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.btngiris = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblkullaniciadi
            // 
            this.lblkullaniciadi.AutoSize = true;
            this.lblkullaniciadi.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkullaniciadi.Location = new System.Drawing.Point(99, 71);
            this.lblkullaniciadi.Name = "lblkullaniciadi";
            this.lblkullaniciadi.Size = new System.Drawing.Size(141, 26);
            this.lblkullaniciadi.TabIndex = 0;
            this.lblkullaniciadi.Text = "Kullanıcı Adı";
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsifre.Location = new System.Drawing.Point(162, 117);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(47, 21);
            this.lblsifre.TabIndex = 1;
            this.lblsifre.Text = "Şifre";
            // 
            // txtkullaniciadi
            // 
            this.txtkullaniciadi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkullaniciadi.Location = new System.Drawing.Point(228, 66);
            this.txtkullaniciadi.Name = "txtkullaniciadi";
            this.txtkullaniciadi.Size = new System.Drawing.Size(175, 30);
            this.txtkullaniciadi.TabIndex = 2;
            // 
            // txtsifre
            // 
            this.txtsifre.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifre.Location = new System.Drawing.Point(228, 112);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(175, 30);
            this.txtsifre.TabIndex = 3;
            // 
            // btngiris
            // 
            this.btngiris.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngiris.Location = new System.Drawing.Point(204, 172);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(96, 36);
            this.btngiris.TabIndex = 4;
            this.btngiris.Text = "GİRİŞ";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1.Location = new System.Drawing.Point(87, 235);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 25);
            this.lbl1.TabIndex = 5;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtkullaniciadi);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lblkullaniciadi);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblkullaniciadi;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.TextBox txtkullaniciadi;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Label lbl1;
    }
}