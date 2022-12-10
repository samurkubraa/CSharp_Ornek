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
    public partial class UyeAnasayfa : Form
    {
        public UyeAnasayfa()
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
                SqlCommand command = new SqlCommand("Insert Into HastaBilgi(HastaAd,HastaSoyad,HastaNumara," +
                    "HastaTC,Hastalik,HastaYatisDurumu,IlgiliDoktor) values (@HastaAd,@HastaSoyad,@HastaNumara," +
                    "@HastaTC,@Hastalik,@HastaYatisDurumu,@IlgiliDoktor)", connection);

                command.Parameters.AddWithValue("@HastaTC", textBox1.Text.ToString());
                command.Parameters.AddWithValue("@HastaAd", textBox2.Text.ToString());
                command.Parameters.AddWithValue("@HastaSoyad", textBox3.Text.ToString());
                command.Parameters.AddWithValue("@HastaNumara", textBox4.Text.ToString());
                command.Parameters.AddWithValue("@Hastalik", textBox5.Text.ToString());
                command.Parameters.AddWithValue("@HastaYatisDurumu", textBox6.Text.ToString());
                command.Parameters.AddWithValue("@IlgiliDoktor", textBox7.Text.ToString());
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Kayıt eklendi");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata : " + hata);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HastaneDal hastaneDal = new HastaneDal();
            dgwuyegetir.DataSource = hastaneDal.HastaGetir();
        }
                                     
        private void button3_Click(object sender, EventArgs e)
        {
           
            try
            { 
                if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
                SqlCommand command = new SqlCommand("Delete from HastaBilgi where HastaTC=@HastaTC",connection);
                command.Parameters.AddWithValue("@HastaTC", textBox1.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Kayıt Silindi");

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata :" + hata);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Update HastaBilgi set HastaAd=@HastaAd," +
                "HastaSoyad=@HastaSoyad,HastaTC=@HastaTC,Hastalik=@Hastalik," +
                "HastaNumara=@HastaNumara,HastaYatisDurumu=@HastaYatisDurumu," +
                "IlgiliDoktor=@IlgiliDoktor WHERE HastaTC=@HastaTC" ,connection);

            command.Parameters.AddWithValue("@HastaTC", textBox1.Text.ToString());
            command.Parameters.AddWithValue("@HastaAd", textBox2.Text.ToString());
            command.Parameters.AddWithValue("@HastaSoyad", textBox3.Text.ToString());
            command.Parameters.AddWithValue("@HastaNumara", textBox4.Text.ToString());
            command.Parameters.AddWithValue("@Hastalik", textBox5.Text.ToString());
            command.Parameters.AddWithValue("@HastaYatisDurumu", textBox6.Text.ToString());
            command.Parameters.AddWithValue("@IlgiliDoktor", textBox7.Text.ToString());

            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kayıt Güncellendi");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();

        }
    }
}
