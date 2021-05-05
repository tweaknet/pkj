using LiveCharts.Defaults;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pkj
{
    class WczytajPoprzedniePomiary
    {
        static readonly string connectionString = ConfigurationManager.ConnectionStrings["pkj"].ConnectionString;
        MainForm instancemainForm;
        public decimal pomiar { get; set; }
        public int nr_sztuki { get; set; }
        public void wczytajDoWykresu1(MainForm mainForm)
        {
            int i = 0;
            instancemainForm = mainForm;
            mainForm.wykPomiaru1.Series[1].Values.Clear();
            mainForm.wykPomiaru1.Series[2].Values.Clear();
            SqlConnection polaczenie = new SqlConnection(connectionString);
            polaczenie.Open();
            SqlCommand komendaSQL = polaczenie.CreateCommand();
            komendaSQL.CommandText = "SELECT wartosc,nr_sztuki FROM pkj.pomiary where idZlecenia =" + mainForm.idWybranegoZlecenia +
                " and id_Stanowiska = (select id from pkj.stanowiska where nazwa =\'" + mainForm.lbStatusStanowisko.Text + "\' ) and active=1 and nr_kolumny = 1 order by id";
            SqlDataReader thisReader = komendaSQL.ExecuteReader();
            Console.WriteLine(value: mainForm.formula);
            while (thisReader.Read())
            {
                pomiar = (decimal)thisReader["wartosc"];
                nr_sztuki = (int)thisReader["nr_sztuki"];
                mainForm.wykPomiaru1.Series[0].Values.Add(new ObservablePoint((double)pomiar, nr_sztuki));
                mainForm.listaKol1[i] = (double)pomiar;
                i++;
            }
            thisReader.Close();

            komendaSQL.CommandText = "select gorna_granica,dolna_granica from pkj.konfigZlecenia where idZlecenia = " + mainForm.idWybranegoZlecenia +
                " and idStanowiska = (select id from pkj.stanowiska where nazwa =\'" + mainForm.lbStatusStanowisko.Text + "\' ) and nrPomiaru = 1";
            thisReader = komendaSQL.ExecuteReader();

            while (thisReader.Read()) //ustawienie granic
            {
                var gorna = (decimal)thisReader["gorna_granica"];
                var dolna = (decimal)thisReader["dolna_granica"];
                mainForm.wykPomiaru1.Series[1].Values.Add(new ObservablePoint((double)dolna, 0));
                mainForm.wykPomiaru1.Series[1].Values.Add(new ObservablePoint((double)dolna, nr_sztuki));
                mainForm.wykPomiaru1.Series[2].Values.Add(new ObservablePoint((double)gorna, 0));
                mainForm.wykPomiaru1.Series[2].Values.Add(new ObservablePoint((double)gorna, nr_sztuki));
            }
            thisReader.Close();
            polaczenie.Close();
        }
        public void wczytajDoWykresu2(MainForm mainForm)
        {
            instancemainForm = mainForm;
            mainForm.wykPomiaru2.Series[1].Values.Clear();
            mainForm.wykPomiaru2.Series[2].Values.Clear();
            SqlConnection polaczenie = new SqlConnection(connectionString);
            polaczenie.Open();
            SqlCommand komendaSQL = polaczenie.CreateCommand();
            komendaSQL.CommandText = "SELECT wartosc,nr_sztuki FROM pkj.pomiary where idZlecenia =" + mainForm.idWybranegoZlecenia +
                " and id_Stanowiska = (select id from pkj.stanowiska where nazwa =\'" + mainForm.lbStatusStanowisko.Text + "\' ) and active=1 and nr_kolumny = 2 order by id";
            SqlDataReader thisReader = komendaSQL.ExecuteReader();

            while (thisReader.Read())
            {
                pomiar = (decimal)thisReader["wartosc"];
                nr_sztuki = (int)thisReader["nr_sztuki"];
                mainForm.wykPomiaru2.Series[0].Values.Add(new ObservablePoint((double)pomiar, nr_sztuki));
            }
            thisReader.Close();
            komendaSQL.CommandText = "select gorna_granica,dolna_granica from pkj.konfigZlecenia where idZlecenia = " + mainForm.idWybranegoZlecenia +
                " and idStanowiska = (select id from pkj.stanowiska where nazwa =\'" + mainForm.lbStatusStanowisko.Text + "\' ) and nrPomiaru = 2";
            thisReader = komendaSQL.ExecuteReader();

            while (thisReader.Read())
            {
                var gorna = (decimal)thisReader["gorna_granica"];
                var dolna = (decimal)thisReader["dolna_granica"];
                mainForm.wykPomiaru2.Series[1].Values.Add(new ObservablePoint((double)dolna, 0));
                mainForm.wykPomiaru2.Series[1].Values.Add(new ObservablePoint((double)dolna, nr_sztuki));
                mainForm.wykPomiaru2.Series[2].Values.Add(new ObservablePoint((double)gorna, 0));
                mainForm.wykPomiaru2.Series[2].Values.Add(new ObservablePoint((double)gorna, nr_sztuki));
            }
            thisReader.Close();
            polaczenie.Close();
        }
        public void wczytajDoWykresu3(MainForm mainForm)
        {
            instancemainForm = mainForm;
            mainForm.wykPomiaru3.Series[1].Values.Clear();
            mainForm.wykPomiaru3.Series[2].Values.Clear();
            SqlConnection polaczenie = new SqlConnection(connectionString);
            polaczenie.Open();
            SqlCommand komendaSQL = polaczenie.CreateCommand();
            komendaSQL.CommandText = "SELECT wartosc,nr_sztuki FROM pkj.pomiary where idZlecenia =" + mainForm.idWybranegoZlecenia +
                " and id_Stanowiska = (select id from pkj.stanowiska where nazwa =\'" + mainForm.lbStatusStanowisko.Text + "\' ) and active=1 and nr_kolumny = 3 order by id";
            SqlDataReader thisReader = komendaSQL.ExecuteReader();

            while (thisReader.Read())
            {
                pomiar = (decimal)thisReader["wartosc"];
                nr_sztuki = (int)thisReader["nr_sztuki"];
                mainForm.wykPomiaru3.Series[0].Values.Add(new ObservablePoint((double)pomiar, nr_sztuki));
            }
            thisReader.Close(); 
            komendaSQL.CommandText = "select gorna_granica,dolna_granica from pkj.konfigZlecenia where idZlecenia = " + mainForm.idWybranegoZlecenia +
                 " and idStanowiska = (select id from pkj.stanowiska where nazwa =\'" + mainForm.lbStatusStanowisko.Text + "\' ) and nrPomiaru = 3";
            thisReader = komendaSQL.ExecuteReader();

            while (thisReader.Read())
            {
                var gorna = (decimal)thisReader["gorna_granica"];
                var dolna = (decimal)thisReader["dolna_granica"];
                mainForm.wykPomiaru3.Series[1].Values.Add(new ObservablePoint((double)dolna, 0));
                mainForm.wykPomiaru3.Series[1].Values.Add(new ObservablePoint((double)dolna, nr_sztuki));
                mainForm.wykPomiaru3.Series[2].Values.Add(new ObservablePoint((double)gorna, 0));
                mainForm.wykPomiaru3.Series[2].Values.Add(new ObservablePoint((double)gorna, nr_sztuki));
            }
            thisReader.Close();
            polaczenie.Close();
        }
        public void wczytajDoWykresu4(MainForm mainForm)
        {
            instancemainForm = mainForm;
            mainForm.wykPomiaru4.Series[1].Values.Clear();
            mainForm.wykPomiaru4.Series[2].Values.Clear();
            SqlConnection polaczenie = new SqlConnection(connectionString);
            polaczenie.Open();
            SqlCommand komendaSQL = polaczenie.CreateCommand();
            komendaSQL.CommandText = "SELECT wartosc,nr_sztuki FROM pkj.pomiary where idZlecenia =" + mainForm.idWybranegoZlecenia +
                " and id_Stanowiska = (select id from pkj.stanowiska where nazwa =\'" + mainForm.lbStatusStanowisko.Text + "\' ) and active=1 and nr_kolumny = 4 order by id";
            SqlDataReader thisReader = komendaSQL.ExecuteReader();

            while (thisReader.Read())
            {
                pomiar = (decimal)thisReader["wartosc"];
                nr_sztuki = (int)thisReader["nr_sztuki"];
                mainForm.wykPomiaru4.Series[0].Values.Add(new ObservablePoint((double)pomiar, nr_sztuki));
            }
            thisReader.Close();
            komendaSQL.CommandText = "select gorna_granica,dolna_granica from pkj.konfigZlecenia where idZlecenia = " + mainForm.idWybranegoZlecenia +
                 " and idStanowiska = (select id from pkj.stanowiska where nazwa =\'" + mainForm.lbStatusStanowisko.Text + "\' ) and nrPomiaru = 4";
            thisReader = komendaSQL.ExecuteReader();

            while (thisReader.Read())
            {
                if (thisReader["gorna_granica"].ToString() == "0")
                {
                    Console.WriteLine("działa");
                }
                var gorna = (decimal)thisReader["gorna_granica"];
                var dolna = (decimal)thisReader["dolna_granica"];
                mainForm.wykPomiaru4.Series[1].Values.Add(new ObservablePoint((double)dolna, 0));
                mainForm.wykPomiaru4.Series[1].Values.Add(new ObservablePoint((double)dolna, nr_sztuki));
                mainForm.wykPomiaru4.Series[2].Values.Add(new ObservablePoint((double)gorna, 0));
                mainForm.wykPomiaru4.Series[2].Values.Add(new ObservablePoint((double)gorna, nr_sztuki));
            }
            thisReader.Close();
            polaczenie.Close();
        }
        public void wczytajDoWykresu5(MainForm mainForm)
        {
            instancemainForm = mainForm;
            mainForm.wykPomiaru5.Series[1].Values.Clear();
            mainForm.wykPomiaru5.Series[2].Values.Clear();
            SqlConnection polaczenie = new SqlConnection(connectionString);
            polaczenie.Open();
            SqlCommand komendaSQL = polaczenie.CreateCommand();
            komendaSQL.CommandText = "SELECT wartosc,nr_sztuki FROM pkj.pomiary where idZlecenia =" + mainForm.idWybranegoZlecenia +
                " and id_Stanowiska = (select id from pkj.stanowiska where nazwa =\'" + mainForm.lbStatusStanowisko.Text + "\' ) and active=1 and nr_kolumny = 5 order by id";
            SqlDataReader thisReader = komendaSQL.ExecuteReader();

            while (thisReader.Read())
            {
                pomiar = (decimal)thisReader["wartosc"];
                nr_sztuki = (int)thisReader["nr_sztuki"];
                mainForm.wykPomiaru5.Series[0].Values.Add(new ObservablePoint((double)pomiar, nr_sztuki));
            }
            thisReader.Close();
            komendaSQL.CommandText = "select gorna_granica,dolna_granica from pkj.konfigZlecenia where idZlecenia = " + mainForm.idWybranegoZlecenia +
                 " and idStanowiska = (select id from pkj.stanowiska where nazwa =\'" + mainForm.lbStatusStanowisko.Text + "\' ) and nrPomiaru = 5";
            thisReader = komendaSQL.ExecuteReader();

            while (thisReader.Read())
            {
                var gorna = (decimal)thisReader["gorna_granica"];
                var dolna = (decimal)thisReader["dolna_granica"];
                mainForm.wykPomiaru5.Series[1].Values.Clear();
                mainForm.wykPomiaru5.Series[2].Values.Clear();
                mainForm.wykPomiaru5.Series[1].Values.Add(new ObservablePoint((double)dolna, 0));
                mainForm.wykPomiaru5.Series[1].Values.Add(new ObservablePoint((double)dolna, nr_sztuki));
                mainForm.wykPomiaru5.Series[2].Values.Add(new ObservablePoint((double)gorna, 0));
                mainForm.wykPomiaru5.Series[2].Values.Add(new ObservablePoint((double)gorna, nr_sztuki));
            }
            thisReader.Close();
            polaczenie.Close();
        }
        public void wczytajDoWykresu6(MainForm mainForm)
        {
            instancemainForm = mainForm;
            mainForm.wykPomiaru6.Series[1].Values.Clear();
            mainForm.wykPomiaru6.Series[2].Values.Clear();
            SqlConnection polaczenie = new SqlConnection(connectionString);
            polaczenie.Open();
            SqlCommand komendaSQL = polaczenie.CreateCommand();
            komendaSQL.CommandText = "SELECT wartosc,nr_sztuki FROM pkj.pomiary where idZlecenia =" + mainForm.idWybranegoZlecenia +
                " and id_Stanowiska = (select id from pkj.stanowiska where nazwa =\'" + mainForm.lbStatusStanowisko.Text + "\' ) and active=1 and nr_kolumny = 6 order by id";
            SqlDataReader thisReader = komendaSQL.ExecuteReader();

            while (thisReader.Read())
            {
                pomiar = (decimal)thisReader["wartosc"];
                nr_sztuki = (int)thisReader["nr_sztuki"];
                mainForm.wykPomiaru6.Series[0].Values.Add(new ObservablePoint((double)pomiar, nr_sztuki));
            }
            thisReader.Close();
            komendaSQL.CommandText = "select gorna_granica,dolna_granica from pkj.konfigZlecenia where idZlecenia = " + mainForm.idWybranegoZlecenia +
                 " and idStanowiska = (select id from pkj.stanowiska where nazwa =\'" + mainForm.lbStatusStanowisko.Text + "\' ) and nrPomiaru = 6";
            thisReader = komendaSQL.ExecuteReader();

            while (thisReader.Read())
            {
                var gorna = (decimal)thisReader["gorna_granica"];
                var dolna = (decimal)thisReader["dolna_granica"];
                mainForm.wykPomiaru6.Series[1].Values.Add(new ObservablePoint((double)dolna, 0));
                mainForm.wykPomiaru6.Series[1].Values.Add(new ObservablePoint((double)dolna, nr_sztuki));
                mainForm.wykPomiaru6.Series[2].Values.Add(new ObservablePoint((double)gorna, 0));
                mainForm.wykPomiaru6.Series[2].Values.Add(new ObservablePoint((double)gorna, nr_sztuki));
            }
            thisReader.Close();
            polaczenie.Close();
        }
        public void wczytajDoWykresu7(MainForm mainForm)
        {
            instancemainForm = mainForm;
            mainForm.wykPomiaru7.Series[1].Values.Clear();
            mainForm.wykPomiaru7.Series[2].Values.Clear();
            SqlConnection polaczenie = new SqlConnection(connectionString);
            polaczenie.Open();
            SqlCommand komendaSQL = polaczenie.CreateCommand();
            komendaSQL.CommandText = "SELECT wartosc,nr_sztuki FROM pkj.pomiary where idZlecenia =" + mainForm.idWybranegoZlecenia +
                " and id_Stanowiska = (select id from pkj.stanowiska where nazwa =\'" + mainForm.lbStatusStanowisko.Text + "\' ) and active=1 and nr_kolumny = 7 order by id";
            SqlDataReader thisReader = komendaSQL.ExecuteReader();

            while (thisReader.Read())
            {
                pomiar = (decimal)thisReader["wartosc"];
                nr_sztuki = (int)thisReader["nr_sztuki"];
                mainForm.wykPomiaru7.Series[0].Values.Add(new ObservablePoint((double)pomiar, nr_sztuki));
            }
            thisReader.Close();
            komendaSQL.CommandText = "select gorna_granica,dolna_granica from pkj.konfigZlecenia where idZlecenia = " + mainForm.idWybranegoZlecenia +
                 " and idStanowiska = (select id from pkj.stanowiska where nazwa =\'" + mainForm.lbStatusStanowisko.Text + "\' ) and nrPomiaru = 7";
            thisReader = komendaSQL.ExecuteReader();

            while (thisReader.Read())
            {
                var gorna = (decimal)thisReader["gorna_granica"];
                var dolna = (decimal)thisReader["dolna_granica"];
                mainForm.wykPomiaru7.Series[1].Values.Add(new ObservablePoint((double)dolna, 0));
                mainForm.wykPomiaru7.Series[1].Values.Add(new ObservablePoint((double)dolna, nr_sztuki));
                mainForm.wykPomiaru7.Series[2].Values.Add(new ObservablePoint((double)gorna, 0));
                mainForm.wykPomiaru7.Series[2].Values.Add(new ObservablePoint((double)gorna, nr_sztuki));
            }
            thisReader.Close();
            polaczenie.Close();
        }
        public void wczytajDoWykresu8(MainForm mainForm)
        {
            instancemainForm = mainForm;
            mainForm.wykPomiaru8.Series[1].Values.Clear();
            mainForm.wykPomiaru8.Series[2].Values.Clear();
            SqlConnection polaczenie = new SqlConnection(connectionString);
            polaczenie.Open();
            SqlCommand komendaSQL = polaczenie.CreateCommand();
            komendaSQL.CommandText = "SELECT wartosc,nr_sztuki FROM pkj.pomiary where idZlecenia =" + mainForm.idWybranegoZlecenia +
                " and id_Stanowiska = (select id from pkj.stanowiska where nazwa =\'" + mainForm.lbStatusStanowisko.Text + "\' ) and active=1 and nr_kolumny = 8 order by id";
            SqlDataReader thisReader = komendaSQL.ExecuteReader();

            while (thisReader.Read())
            {
                pomiar = (decimal)thisReader["wartosc"];
                nr_sztuki = (int)thisReader["nr_sztuki"];
                mainForm.wykPomiaru8.Series[0].Values.Add(new ObservablePoint((double)pomiar, nr_sztuki));
            }
            thisReader.Close();
            komendaSQL.CommandText = "select gorna_granica,dolna_granica from pkj.konfigZlecenia where idZlecenia = " + mainForm.idWybranegoZlecenia +
                 " and idStanowiska = (select id from pkj.stanowiska where nazwa =\'" + mainForm.lbStatusStanowisko.Text + "\' ) and nrPomiaru = 8";
            thisReader = komendaSQL.ExecuteReader();

            while (thisReader.Read())
            {
                var gorna = (decimal)thisReader["gorna_granica"];
                var dolna = (decimal)thisReader["dolna_granica"];
                mainForm.wykPomiaru8.Series[1].Values.Add(new ObservablePoint((double)dolna, 0));
                mainForm.wykPomiaru8.Series[1].Values.Add(new ObservablePoint((double)dolna, nr_sztuki));
                mainForm.wykPomiaru8.Series[2].Values.Add(new ObservablePoint((double)gorna, 0));
                mainForm.wykPomiaru8.Series[2].Values.Add(new ObservablePoint((double)gorna, nr_sztuki));
            }
            thisReader.Close();
            polaczenie.Close();
        }

    }
}
