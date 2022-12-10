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
    public partial class YoneticiAnaSayfa : Form
    {
        public YoneticiAnaSayfa()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;
                                    initial catalog=HastaneOtomasyonu;integrated security=true");
        private void button2_Click(object sender, EventArgs e)
        {
            HastaneDal  hastaneDal = new HastaneDal();
            dgwuyegetir.DataSource = hastaneDal.UyeGetir();
            
        }
       
        //private void button1_Click(object sender, EventArgs e)
        //{
            
        
        //}

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("Delete from UyeBilgi where UyeTC=@UyeTC", connection);
                command.Parameters.AddWithValue("@UyeTC", textBoxtc.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Kayıt Silindi");
                textBoxtc.Clear();

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata :" + hata);
            }
        }

        //private void button4_Click(object sender, EventArgs e)
        //{

        //}
    }
}
