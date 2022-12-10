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
    public partial class KayitOlma : Form
    {
        public KayitOlma()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;
                                    initial catalog=HastaneOtomasyonu;integrated security=true");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("Insert Into UyeBilgi(UyeAd,UyeSoyad,UyeNumara," +
                    "UyeTC,UyeBolum,UyeSifre,UyeKullaniciadi) values (@UyeAd,@UyeSoyad,@UyeNumara," +
                    "@UyeTC,@UyeBolum,@UyeSifre,@UyeKullaniciadi)",connection);

                command.Parameters.AddWithValue("@UyeAd",textBox1.Text.ToString());
                command.Parameters.AddWithValue("@UyeSoyad",textBox2.Text.ToString());
                command.Parameters.AddWithValue("@UyeNumara",textBox3.Text.ToString());
                command.Parameters.AddWithValue("@UyeTC",textBox4.Text.ToString());
                command.Parameters.AddWithValue("@UyeBolum",textBox5.Text.ToString());
                command.Parameters.AddWithValue("@UyeKullaniciadi",textBox6.Text.ToString());
                command.Parameters.AddWithValue("@UyeSifre",textBox7.Text.ToString());
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Kayıt eklendi");

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata : " + hata);
            }

        }
    }
}
