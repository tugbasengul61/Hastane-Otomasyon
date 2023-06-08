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
using System.Security.Policy;

namespace Hastane_Otomasyon4
{
    public partial class frmguncelle : Form
    {
        public frmguncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HastaneOtomasyon;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

        DataTable yenile()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from hasta1", baglanti);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneOtomasyonDataSet1.hasta1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hasta1TableAdapter.Fill(this.hastaneOtomasyonDataSet1.hasta1);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            string HastaTC, HastaAd, HastaSoyad, HastaBabaAdi, HastaAnneAdi, HastaDogumTarihi, HastaDogumYeri, HastaTelefon;
            int HastaCinsiyet;
            HastaTC = dgvguncelle.CurrentRow.Cells["HastaTC"].Value.ToString();
            HastaAd = dgvguncelle.CurrentRow.Cells["HastaAd"].Value.ToString();
            HastaSoyad = dgvguncelle.CurrentRow.Cells["HastaSoyad"].Value.ToString();
            HastaBabaAdi = dgvguncelle.CurrentRow.Cells["HastaBabaAdi"].Value.ToString();
            HastaAnneAdi = dgvguncelle.CurrentRow.Cells["HastaAnneAdi"].Value.ToString();
            HastaDogumTarihi = dgvguncelle.CurrentRow.Cells["HastaDogumTarihi"].Value.ToString();
            HastaDogumYeri = dgvguncelle.CurrentRow.Cells["HastaDogumYeri"].Value.ToString();
            HastaTelefon = dgvguncelle.CurrentRow.Cells["HastaTelefon"].Value.ToString();
            HastaCinsiyet = int.Parse(dgvguncelle.CurrentRow.Cells["HastaCinsiyet"].Value.ToString());
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update hasta1 set HastaTC='"+HastaTC+"', HastaAd='"+HastaAd+"', HastaSoyad='"+HastaSoyad+"', HastaBabaAdi='"+HastaBabaAdi+"', HastaAnneAdi='"+HastaAnneAdi+"', HastaDogumTarihi='"+HastaDogumTarihi+"', HastaDogumYeri='"+HastaDogumYeri+"', HastaTelefon='"+HastaTelefon+"', HastaCinsiyet='"+HastaCinsiyet+"'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            dgvguncelle.DataSource = yenile();
            MessageBox.Show("İşlem Başarılı...");
        }

        private void dgvguncelle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvguncelle.SelectedRows.Count; i++)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from hasta1 where HastaTC='" + dgvguncelle.SelectedRows[i].Cells["HastaTC"].Value.ToString()+"'",baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            MessageBox.Show("Kayıt(lar) Silindi...");
            dgvguncelle.DataSource = yenile();
        }
    }
}
