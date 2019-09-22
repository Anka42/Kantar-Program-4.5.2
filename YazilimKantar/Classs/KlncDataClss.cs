using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace YazilimKantar.Classs
{
    class KlncDataClss
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-69RIK68\SQLEXPRESS;initial Catalog=YazilimKantar;Integrated Security=True");
        protected void sqlcontrol()
        {
            try { conn.Close(); }
            catch { }
        }
        public DataTable TabloyuGetir()
        {
            sqlcontrol();
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select Id,KullncAdi,Sifre from Kullanici", conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            conn.Close();
            return table;
        }
        public void SatiriSil(string ID)
        {
            sqlcontrol();
            conn.Open();
            SqlCommand kmt = new SqlCommand("DELETE  Kullanici where Id='" + ID + "'", conn);
            kmt.ExecuteNonQuery();
            conn.Close();
        }

        public void SatirGunceleme(string ID, string KullncAdi,string Sifre)
        {
            sqlcontrol();
            conn.Open();
            SqlCommand command = new SqlCommand("UPDATE  Kullanici set KullncAdi='" + KullncAdi + "',Sifre='"+ Sifre +"' where Id='" + ID + "'", conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void YeniSatirEkle(string KullncAdi,string Sifre)
        {
            sqlcontrol();
            conn.Open();
            SqlCommand kmta = new SqlCommand("Insert into  Kullanici (KullncAdi,Sifre) Values ('" + KullncAdi + "','"+ Sifre +"')", conn);
            kmta.ExecuteNonQuery();
            conn.Close();
        }
    }
}
