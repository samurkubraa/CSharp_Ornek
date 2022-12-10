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
    public partial class UyeGirisi : Form
    {
        public UyeGirisi()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;
                                    initial catalog=HastaneOtomasyonu;integrated security=true");
        private void btngiris_Click(object sender, EventArgs e)
        {
            string ukullaniciadi = txtuyekullaniciadi.Text;
            string usifre = txtuyesifre.Text;

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Select * from UyeBilgi " +
                "where UyeKullaniciadi= '" + txtuyekullaniciadi.Text.ToString() +"'And UyeSifre=" +
                 " '" + txtuyesifre.Text.ToString()+"'" , connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                 UyeAnasayfa uyeAnasayfa = new UyeAnasayfa();
                 uyeAnasayfa.Show();
                
            } 
           
            
            reader.Close();
            connection.Close();

        }
    }
}
