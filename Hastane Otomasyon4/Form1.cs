using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Hastane_Otomasyon4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HastaneOtomasyon;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

        private void lblhastasoyadi_Click(object sender, EventArgs e)
        {

        }

        private void lbldogumyeri_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select sehir From iller";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbdogumyeri.Items.Add(dr["sehir"]);
            }
            baglanti.Close();

        }

        private void txthastasoyadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void msktc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lbldogumtarihi_Click(object sender, EventArgs e)
        {

        }

        private void cmbdogumyeri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btngonder_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komutkaydet = new SqlCommand("insert into hasta1 (HastaTC,HastaAd, HastaSoyad, HastaBabaAdi,HastaAnneAdi, HastaDogumTarihi, HastaDogumYeri, HastaTelefon,HastaCinsiyet) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglanti);
                int c = 0;
                if (rdbkadin.Checked == true)
                {
                    c = 1;
                }
                else c = 2; 
                
                komutkaydet.Parameters.AddWithValue("@p1", msktc.Text);
                komutkaydet.Parameters.AddWithValue("@p2", txthastaadi.Text);
                komutkaydet.Parameters.AddWithValue("@p3", txthastasoyadi.Text);
                komutkaydet.Parameters.AddWithValue("@p4", txtbabaadi.Text);
                komutkaydet.Parameters.AddWithValue("@p5", txtanneadi.Text);
                komutkaydet.Parameters.AddWithValue("@p6", mskdogumtarihi.Text);
                komutkaydet.Parameters.AddWithValue("@p7", cmbdogumyeri.Text);
                komutkaydet.Parameters.AddWithValue("@p8", msktelefon.Text);
                komutkaydet.Parameters.AddWithValue("@p9", c);

                komutkaydet.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Ekledi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata!!! Lütfen Yeniden Deneyin.");
            }
        }

        private void rdbkadin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdberkek_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mskdogumtarihi_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
    //Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = HastaneOtomasyon; Integrated Security = True
}
