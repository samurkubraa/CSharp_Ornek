using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class YoneticiGirisi : Form
    {
        public YoneticiGirisi()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;
                                    initial catalog=HastaneOtomasyonu;integrated security=true");
        private void btngiris_Click(object sender, EventArgs e)
        {
            string ykullaniciadi = txtyoneticikullaniciadi.Text;
            string ysifre = txtyoneticisifre.Text;

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Select * from YoneticiBilgi " +
                "where YoneticiKullaniciadi= '" + txtyoneticikullaniciadi.Text.ToString() + "'And YoneticiSifre=" +
                 " '" + txtyoneticisifre.Text.ToString() + "'", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                YoneticiAnaSayfa yoneticiAnaSayfa = new YoneticiAnaSayfa();
                yoneticiAnaSayfa.Show();

            }


            reader.Close();
            connection.Close();
        }
    }
}
