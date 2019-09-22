using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace YazilimKantar.Classs
{
    class EkleDataClss
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
            SqlDataAdapter adapter = new SqlDataAdapter("select Id,Firma from KaFirma", conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            conn.Close();
            return table;
        }
        public void SatiriSil(string ID)
        {
            sqlcontrol();
            conn.Open();
            SqlCommand kmt = new SqlCommand("DELETE  KaFirma where Id='" + ID + "'", conn);
            kmt.ExecuteNonQuery();
            conn.Close();
        }

        public void SatirGunceleme(string ID, string Firma)
        {
            sqlcontrol();
            conn.Open();
            SqlCommand command = new SqlCommand("UPDATE  KaFirma set Firma='" + Firma + "' where Id='" + ID + "'", conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void YeniSatirEkle(string Firma)
        {
            sqlcontrol();
            conn.Open();
            SqlCommand kmta = new SqlCommand("Insert into  KaFirma (Firma) Values ('" + Firma + "')", conn);
            kmta.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable TabloyuGetirGFirma()
        {
            sqlcontrol();
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select Id,GFirma from KaGFirma", conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            conn.Close();
            return table;
        }
        public void SatiriSilGFirma(string ID)
        {
            sqlcontrol();
            conn.Open();
            SqlCommand kmt = new SqlCommand("DELETE  KaGFirma where Id='" + ID + "'", conn);
            kmt.ExecuteNonQuery();
            conn.Close();
        }

        public void SatirGuncelemeGFirma(string ID, string GFirma)
        {
            sqlcontrol();
            conn.Open();
            SqlCommand command = new SqlCommand("UPDATE  KaGFirma set GFirma='" + GFirma + "' where Id='" + ID + "'", conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void YeniSatirEkleGFirma(string GFirma)
        {
            sqlcontrol();
            conn.Open();
            SqlCommand kmta = new SqlCommand("Insert into  KaGFirma (GFirma) Values ('" + GFirma + "')", conn);
            kmta.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable TabloyuGetirMalzeme()
        {
            sqlcontrol();
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select Id,Malzeme from KaMalzeme", conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            conn.Close();
            return table;
        }
        public void SatiriSilMalzeme(string ID)
        {
            sqlcontrol();
            conn.Open();
            SqlCommand kmt = new SqlCommand("DELETE  KaMalzeme where Id='" + ID + "'", conn);
            kmt.ExecuteNonQuery();
            conn.Close();
        }

        public void SatirGuncelemeMalzeme(string ID, string Malzeme)
        {
            sqlcontrol();
            conn.Open();
            SqlCommand command = new SqlCommand("UPDATE  KaMalzeme set Malzeme='" + Malzeme + "' where Id='" + ID + "'", conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void YeniSatirEkleMalzeme(string Malzeme)
        {
            sqlcontrol();
            conn.Open();
            SqlCommand kmta = new SqlCommand("Insert into  KaMalzeme (Malzeme) Values ('" + Malzeme + "')", conn);
            kmta.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable TabloyuGetirNot()
        {
            sqlcontrol();
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select Id,[Not] from KaNot", conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            conn.Close();
            return table;
        }
        public void SatiriSilNot(string ID)
        {
            sqlcontrol();
            conn.Open();
            SqlCommand kmt = new SqlCommand("DELETE  KaNot where Id='" + ID + "'", conn);
            kmt.ExecuteNonQuery();
            conn.Close();
        }

        public void SatirGuncelemeNot(string ID, string Not)
        {
            sqlcontrol();
            conn.Open();
            SqlCommand command = new SqlCommand("UPDATE  KaNot set [Not]='" + Not + "' where Id='" + ID + "'", conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void YeniSatirEkleNot(string Not)
        {
            sqlcontrol();
            conn.Open();
            SqlCommand kmta = new SqlCommand("Insert into  KaNot ([Not]) Values ('" + Not + "')", conn);
            kmta.ExecuteNonQuery();
            conn.Close();
        }
    }
}
