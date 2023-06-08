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
using System.Globalization;

namespace Hastane_Otomasyon4
{
    public partial class Randevu : Form
    {
        public Randevu()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HastaneOtomasyon;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        SqlDataReader dr;
        private void Randevu_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HastaneOtomasyon;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *from Klini1 ORDER BY klinikid", con);
            da.Fill(dt);
            cmbklinik.ValueMember = "klinikid";
            cmbklinik.DisplayMember = "KlinikAdi";
            cmbklinik.DataSource = dt;

            dtptarih.CustomFormat = "dd-MM-yyyy";
            dtptarih.Format = DateTimePickerFormat.Custom;
        }

        private void cmbklinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbklinik.SelectedIndex != -1)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from Doktor1 where Klinikid = " + cmbklinik.SelectedValue, con);
                da.Fill(dt);
                cmbdoktor.ValueMember = "Doktorid";
                cmbdoktor.DisplayMember = "DoktorAd";
                cmbdoktor.DataSource = dt;
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                var tarih = $"{dtptarih.Value.ToLongDateString()} {dtpsaat.Value.ToLongTimeString()}";
                SqlCommand cmd = new SqlCommand("insert into Randevu1(HastaTC, KlinikAdi, DoktorAd,RandevuTarih)values(@p1, @p2, @p3, @p4)", baglanti);
                cmd.Parameters.AddWithValue("@p1", mskhastatc.Text);
                cmd.Parameters.AddWithValue("@p2", cmbklinik.Text);
                cmd.Parameters.AddWithValue("@p3", cmbdoktor.Text);
                cmd.Parameters.AddWithValue("@p4", DateTime.Parse(tarih));
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                baglanti.Close();
                MessageBox.Show("Randevu Başarılı Bir Şekilde Ekledi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata!!! Lütfen Yeniden Deneyin.");
            }
        }
    }
}

