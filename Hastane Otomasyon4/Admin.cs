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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
       
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HastaneOtomasyon;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        SqlCommand cmd;
        SqlDataReader dr;
        private void btngiris_Click(object sender, EventArgs e)
        {
            string ad = txtkullaniciadi.Text;
            string parola = txtsifre.Text;
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT *FROM Admin1 where AdminAdi ='" + ad + "' AND AdminSifre='" + parola + "'";
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                Form2 f1 = new Form2();
                f1.Show();
                this.Hide();
                
            }
            else
            {
                lbl1.Text = "Kullanıcı Adı veya Şifre Hatalı!!!";
            }
            con.Close();
        }
    }
}
