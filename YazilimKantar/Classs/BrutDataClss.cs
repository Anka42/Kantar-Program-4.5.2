using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace YazilimKantar.Classs
{
    class BrutDataClss
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
            SqlDataAdapter adapter = new SqlDataAdapter("select Id,TartimNo,PlakaNo,GiTarih,CiTarih,GiSaat,CiSaat,FirmAdi,GiFirmAdi,Malzeme,Operator,Gelil,Gitil,Aciklama,Tartim,Brut,Kg from Brut", conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            conn.Close();
            return table;
        }
        public void SatiriSil(string ID)
        {
            sqlcontrol();
            conn.Open();
            SqlCommand kmt = new SqlCommand("DELETE  Brut where Id='" + ID + "'", conn);
            kmt.ExecuteNonQuery();
            conn.Close();
        }

        public void SatirGunceleme(string ID, string TartimNo, string PlakaNo, string GiTarih, string CiTarih, string GiSaat, string CiSaat, string FirmAdi, string GiFirmAdi, string Malzeme, string Operator, string Gelil, string Gitil, string Aciklama, string Tartim, string Brut, string Kg)
        {
            sqlcontrol();
            conn.Open();
            SqlCommand command = new SqlCommand("UPDATE  Brut set TartimNo='" + TartimNo + "',PlakaNo='" + PlakaNo + "',GiTarih='" + GiTarih + "',CiTarih='" + CiTarih + "',GiSaat='" + GiSaat + "',CiSaat='" + CiSaat + "',FirmAdi='" + FirmAdi + "',GiFirmAdi='" + GiFirmAdi + "',Malzeme='" + Malzeme + "',Operator='" + Operator + "',Gelil='" + Gelil + "',Gitil='" + Gitil + "',Aciklama='" + Aciklama + "',Tartim='" + Tartim + "',Brut='" + Brut + "',Kg='" + Kg + "' where Id='" + ID + "'", conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void YeniSatirEkle(string TartimNo, string PlakaNo, string GiTarih, string CiTarih, string GiSaat, string CiSaat, string FirmAdi, string GiFirmAdi, string Malzeme, string Operator, string Gelil, string Gitil, string Aciklama, string Tartim, string Brut, string Kg)
        {
            sqlcontrol();
            conn.Open();
            SqlCommand kmta = new SqlCommand("Insert into  Brut (TartimNo,PlakaNo,GiTarih,CiTarih,GiSaat,CiSaat,FirmAdi,GiFirmAdi,Malzeme,Operator,Gelil,Gitil,Aciklama,Tartim,Brut,Kg) Values ('" + TartimNo + "','" + PlakaNo + "','" + GiTarih + "','" + CiTarih + "','" + GiSaat + "','" + CiSaat + "','" + FirmAdi + "','" + GiFirmAdi + "','" + Malzeme + "','" + Operator + "','" + Gelil + "','" + Gitil + "','" + Aciklama + "','" + Tartim + "','" + Brut + "','" + Kg + "')", conn);
            kmta.ExecuteNonQuery();
            conn.Close();
        }
    }
}
