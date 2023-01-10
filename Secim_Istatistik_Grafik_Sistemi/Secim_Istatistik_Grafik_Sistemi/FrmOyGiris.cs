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

namespace Secim_Istatistik_Grafik_Sistemi
{
    public partial class FrmOyGiris : Form
    {
        public FrmOyGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-70RL3KF\\SQLEXPRESS;Initial Catalog=SecimProje;Integrated Security=True");
        private void BtnOyGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TblIlce (IlceAd,AParti,BParti,CPARTİ,DParti,Eparti) values (@P1,@P2,@P3,@P4,@P5,@P6)", baglanti);
            komut.Parameters.AddWithValue("@P1", TxtIlcead.Text);
            komut.Parameters.AddWithValue("@P2", TxtA.Text);
            komut.Parameters.AddWithValue("@P3",TxtB.Text);
            komut.Parameters.AddWithValue("@P4",TxtC.Text);
            komut.Parameters.AddWithValue("@P5",TxtD.Text);
            komut.Parameters.AddWithValue("@P6", TxtE.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oy Girişi Yapıldı","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnGrafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler fr = new FrmGrafikler();
            fr.Show();
        }

        private void BtnCks_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
