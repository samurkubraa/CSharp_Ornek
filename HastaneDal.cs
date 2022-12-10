using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu
{
    public class HastaneDal
    {
        public List<Uye> UyeGetir()
        {
            SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;
                                    initial catalog=HastaneOtomasyonu;integrated security=true");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Select * from UyeBilgi",connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Uye> uyeler = new List<Uye>();
            while (reader.Read())
            {
                Uye uye = new Uye
                {
                    UyeAd = reader["UyeAd"].ToString(),
                    UyeSoyad = reader["UyeSoyad"].ToString(),
                    UyeNumara = reader["UyeNumara"].ToString(),
                    UyeTC = reader["UyeTC"].ToString(),
                    UyeBolum = reader["UyeBolum"].ToString(),
                    UyeSifre = reader["UyeSifre"].ToString(),
                    UyeKullaniciadi = reader["UyeSoyad"].ToString()
                };
                uyeler.Add(uye);
            }
            reader.Close();
            connection.Close();
            return uyeler;

        }
        public List<Hasta> HastaGetir()
        {
            SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;
                                    initial catalog=HastaneOtomasyonu;integrated security=true");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Select * from HastaBilgi", connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Hasta> hastalar = new List<Hasta>();
            while (reader.Read())
            {
                Hasta hasta = new Hasta
                {
                    HastaAd = reader["HastaAd"].ToString(),
                    HastaSoyad = reader["HastaSoyad"].ToString(),
                    HastaNumara = reader["HastaNumara"].ToString(),
                    HastaTC = reader["HastaTC"].ToString(),
                    Hastalik = reader["Hastalik"].ToString(),
                    HastaYatisDurumu = reader["HastaYatisDurumu"].ToString(),
                    IlgiliDoktor = reader["IlgiliDoktor"].ToString()
                };
                hastalar.Add(hasta);
            }
            reader.Close();
            connection.Close();
            return hastalar;

        }
    }
}
