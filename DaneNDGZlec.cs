using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pkj
{
    class DaneNDGZlec
    {
        static readonly string connectionString = ConfigurationManager.ConnectionStrings["pkj"].ConnectionString;
        MainForm instancemainForm;
        public int idZlecenia { get; set; }
        public string nazwaStanowiska { get; set; }
        public double nominal { get; set; }
        public double dolna { get; set; }
        public double gorna { get; set; }
        public double[,] granice = new double[8, 3];
        int i = 0;
        int nr = 1;
        public void NDG(MainForm m,int ileKolumn)
        {
            instancemainForm = m;
            idZlecenia = Convert.ToInt32(m.idWybranegoZlecenia);
            nazwaStanowiska = m.lbStatusStanowisko.Text;

            SqlConnection polaczenie = new SqlConnection(connectionString);
            polaczenie.Open();
            SqlCommand komendaSQL = polaczenie.CreateCommand();
            komendaSQL.CommandText = "SELECT nominal,dolna_granica,gorna_granica FROM pkj.konfigZlecenia WHERE idZlecenia = " + idZlecenia +
                              " AND idStanowiska = (select id from pkj.stanowiska where nazwa = '" + nazwaStanowiska + "')";
            SqlDataReader thisReader = komendaSQL.ExecuteReader();
            while (thisReader.Read())
            {
                nominal = Convert.ToDouble(thisReader["nominal"]);
                dolna = Convert.ToDouble(thisReader["dolna_granica"]);
                gorna = Convert.ToDouble(thisReader["gorna_granica"]);
                granice[i, 0] = nominal;
                granice[i, 1] = dolna;
                granice[i, 2] = gorna;
                i++;
            }
            thisReader.Close();
            polaczenie.Close();

            if(nr <= ileKolumn)
            {
                m.grDolKol1 = granice[0, 1];
                m.grGorKol1 = granice[0, 2];
                nr++;
            }
            if (nr <= ileKolumn)
            {
                m.grDolKol2 = granice[1, 1];
                m.grGorKol2 = granice[1, 2];
                nr++;
            }
            if (nr <= ileKolumn)
            {
                m.grDolKol3 = granice[2, 1];
                m.grGorKol3 = granice[2, 2];
                nr++;
            }
            if (nr <= ileKolumn)
            {
                m.grDolKol4 = granice[3, 1];
                m.grGorKol4 = granice[3, 2];
                nr++;
            }
            if (nr <= ileKolumn)
            {
                m.grDolKol5 = granice[4, 1];
                m.grGorKol5 = granice[4, 2];
                nr++;
            }
            if (nr <= ileKolumn)
            {
                m.grDolKol6 = granice[5, 1];
                m.grGorKol6 = granice[5, 2];
                nr++;
            }
            if (nr <= ileKolumn)
            {
                m.grDolKol7 = granice[6, 1];
                m.grGorKol7 = granice[6, 2];
                nr++;
            }
            if (nr <= ileKolumn)
            {
                m.grDolKol8 = granice[7, 1];
                m.grGorKol8 = granice[7, 2];
                nr++;
            }
        }
    }
}
