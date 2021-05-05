using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace pkj
{
    public class Pomiary
    {
        MainForm instancemainForm;
        static readonly string connectionString = ConfigurationManager.ConnectionStrings["pkj"].ConnectionString;
        public int a { get; set; }
        public int b { get; set; }
        public int idWybranegoPomiaru { get; set; }
        public string nazwaWybranejGrupy { get; set; }
        public string nazwaWybranegoStanowiska { get; set; }
        public int nrPomiaru { get; set; }
        public decimal oblicz()
        {
            return a + b;
        }

        public static void Zapisz(int idZlecenia, decimal wartosc, int id_user, int id_stanowiska, int nr_kolumny, int nr_sztuki)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("pkj.ZapiszPomiar", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@idZlecenia", idZlecenia);
                sqlCmd.Parameters.AddWithValue("@wartosc", wartosc);
                sqlCmd.Parameters.AddWithValue("@id_user", id_user);
                sqlCmd.Parameters.AddWithValue("@id_stanowiska", id_stanowiska);
                sqlCmd.Parameters.AddWithValue("@nr_kolumny", nr_kolumny);
                sqlCmd.Parameters.AddWithValue("@nr_sztuki", nr_sztuki);
                sqlCmd.ExecuteNonQuery();
            }
        }
        public void PrzeniesDoGory(MainForm mainForm)
        {
            instancemainForm = mainForm;
            if (nrPomiaru == 1)
            {
                MessageBox.Show("To jest już pierwszy pomiar.");
            }
            else 
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("pkj.PrzeniesDoGory", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@idNrPomiaru", idWybranegoPomiaru);
                    sqlCmd.Parameters.AddWithValue("@nazwaWybranejGrupy", nazwaWybranejGrupy);
                    sqlCmd.Parameters.AddWithValue("@nazwaWybranegoStanowiska", nazwaWybranegoStanowiska);
                    sqlCmd.Parameters.AddWithValue("@nrPomiaru", nrPomiaru);
                    try
                    {
                        sqlCmd.ExecuteNonQuery();
                    }
                    catch (Exception e) { MessageBox.Show(e.ToString()); }
                }
            }
            mainForm.PokazKolumny();

        }
        public void PrzeniesDoDolu(MainForm mainForm) 
        {
            instancemainForm = mainForm;
            var iidd = 0;
            SqlConnection polaczenie = new SqlConnection(connectionString);
            polaczenie.Open();
            SqlCommand komendaSQL = polaczenie.CreateCommand();
            komendaSQL.CommandText = "SELECT max(nrPomiaru) as nrPomiaru FROM pkj.kolumny "+
                " where id_stanowiska =(select id from pkj.stanowiska where nazwa=\'" + nazwaWybranegoStanowiska + "\') and id_grupy = " +
                "(select nr from pkj.grupy where nazwa = \'" + nazwaWybranejGrupy + "\' and id_stanowiska =(select id from pkj.stanowiska where nazwa=\'" + nazwaWybranegoStanowiska + "\'))";
            SqlDataReader thisReader = komendaSQL.ExecuteReader();
            while (thisReader.Read())
            {
                try
                {
                    iidd = (int)thisReader["nrPomiaru"];
                }
                catch { iidd = 0; }
            }
            thisReader.Close();
            polaczenie.Close();
            if (nrPomiaru < iidd)
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("pkj.PrzeniesDoDolu", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@idNrPomiaru", idWybranegoPomiaru);
                    sqlCmd.Parameters.AddWithValue("@nazwaWybranejGrupy", nazwaWybranejGrupy);
                    sqlCmd.Parameters.AddWithValue("@nazwaWybranegoStanowiska", nazwaWybranegoStanowiska);
                    sqlCmd.Parameters.AddWithValue("@nrPomiaru", nrPomiaru);
                    try
                    {
                        sqlCmd.ExecuteNonQuery();
                    }
                    catch (Exception e) { MessageBox.Show(e.ToString()); }
                }
                mainForm.PokazKolumny();
            }
            else
                MessageBox.Show("To jest już ostatni pomiar.");
        }
    }
}
