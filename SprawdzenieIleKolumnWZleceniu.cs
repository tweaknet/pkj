using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows;

namespace pkj
{
    class SprawdzenieIleKolumnWZleceniu 
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["pkj"].ConnectionString;
        private static string IleKolumnZlecenia;
        private static string IleKolumn;

        public static int Sprawdz(string stanowiskoo, int idZlecenia)
        {
            try
            {
                SqlConnection polaczenie = new SqlConnection(connectionString);
                polaczenie.Open();
                SqlCommand komendaSQL = polaczenie.CreateCommand();
                komendaSQL.CommandText = "SELECT max(nrPomiaru) as nr FROM pkj.konfigZlecenia where idZlecenia = '"
                    + idZlecenia + "' and idStanowiska = (select id from pkj.stanowiska where nazwa = '" + stanowiskoo + "') ";
                SqlDataReader thisReader = komendaSQL.ExecuteReader();

                while (thisReader.Read())
                {
                    IleKolumnZlecenia = thisReader["nr"].ToString();
                }
                thisReader.Close();
                polaczenie.Close();
                return IleKolumnZlecenia == "" ? 0 : Convert.ToInt32(IleKolumnZlecenia);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
        public static int Sprawdz(int idWybranegoWiersza)//sprawdza ile jest kolumn w tabeli kolumny(szablon) do kopiowania
        {
            try
            {
                SqlConnection polaczenie = new SqlConnection(connectionString);
                polaczenie.Open();
                SqlCommand komendaSQL = polaczenie.CreateCommand();
                komendaSQL.CommandText = "SELECT max(nrPomiaru) as nr FROM pkj.kolumny where id_stanowiska = "
                    +"(select id_stanowiska from pkj.kolumny where id = "+ idWybranegoWiersza + ")" +
                    " and id_grupy = (select id_grupy from pkj.kolumny where id = " + idWybranegoWiersza + ") ";
                SqlDataReader thisReader = komendaSQL.ExecuteReader();

                while (thisReader.Read())
                {
                    //if (thisReader["czyAdmin"].ToString() == "True") { pokazTabUstawienia = true; };
                    IleKolumn = thisReader["nr"].ToString();
                }
                thisReader.Close();
                polaczenie.Close();
                return IleKolumn == "" ? 0 : Convert.ToInt32(IleKolumn)+1;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
    }
}
