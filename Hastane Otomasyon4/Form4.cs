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

namespace Hastane_Otomasyon4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HastaneOtomasyon;Integrated Security=True");

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneOtomasyonDataSet3.Randevu1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.randevu1TableAdapter.Fill(this.hastaneOtomasyonDataSet3.Randevu1);
            // TODO: Bu kod satırı 'hastaneOtomasyonDataSet.hasta1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hasta1TableAdapter.Fill(this.hastaneOtomasyonDataSet.hasta1);

        }

        DataTable yenile()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from hasta1", baglanti);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            string HastaTC, KlinikAdi, DoktorAd;
            DateTime RandevuTarih;
            HastaTC = dgvrandevu.CurrentRow.Cells["HastaTC"].Value.ToString();
            KlinikAdi = dgvrandevu.CurrentRow.Cells["KlinikAdi"].Value.ToString();
            DoktorAd = dgvrandevu.CurrentRow.Cells["DoktorAd"].Value.ToString();
            RandevuTarih = DateTime.Parse(dgvrandevu.CurrentRow.Cells["RandevuTarih"].Value.ToString());
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Randevu1 set HastaTC='" + HastaTC + "', KlinikAdi='" + KlinikAdi+ "', DoktorAd='"+DoktorAd+"', RandevuTarih='" +RandevuTarih+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            dgvrandevu.DataSource = yenile();
            MessageBox.Show("İşlem Başarılı...");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvrandevu.SelectedRows.Count; i++)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from hasta1 where HastaTC='" + dgvrandevu.SelectedRows[i].Cells["HastaTC"].Value.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            MessageBox.Show("Kayıt(lar) Silindi...");
            dgvrandevu.DataSource = yenile();
        }
    }
}
