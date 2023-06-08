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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void randevuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menultenkayıtekle_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
        }

        private void menultemkayitduzenle_Click(object sender, EventArgs e)
        {
            frmguncelle f4 = new frmguncelle();
            f4.Show();
            //this.Hide();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void menultemkayit_Click(object sender, EventArgs e)
        {
          
        }

        private void menultemrandevuolustur_Click(object sender, EventArgs e)
        {
            Randevu f5 = new Randevu();
            f5.Show();
        }

        private void menultemrandevuduzenle_Click(object sender, EventArgs e)
        {
            Form4 f6 = new Form4();
            f6.Show();
        }

        private void menultemyonetim_Click(object sender, EventArgs e)
        {

        }
    }
}
