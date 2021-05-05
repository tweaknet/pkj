using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pkj
{
    class DaneObrazZlec
    {
        static readonly string connectionString = ConfigurationManager.ConnectionStrings["pkj"].ConnectionString;
        MainForm instancemainForm;
        public int idZlecenia { get; set; }
        public string nazwaStanowiska { get; set; }
        public string obraz { get; set; }
        public string[] obrazy = new string[8]; //albo 25
        int i = 0;
        int nr = 1;
        public void Obraz(MainForm m, int ileKolumn)
        {
            instancemainForm = m;
            idZlecenia = Convert.ToInt32(m.idWybranegoZlecenia);
            nazwaStanowiska = m.lbStatusStanowisko.Text;

            SqlConnection polaczenie = new SqlConnection(connectionString);
            polaczenie.Open();
            SqlCommand komendaSQL = polaczenie.CreateCommand();
            komendaSQL.CommandText = "SELECT obraz FROM pkj.konfigZlecenia WHERE idZlecenia = " + idZlecenia +
                              " AND idStanowiska = (select id from pkj.stanowiska where nazwa = '" + nazwaStanowiska + "')";
            SqlDataReader thisReader = komendaSQL.ExecuteReader();
            while (thisReader.Read())
            {
                obraz = thisReader["obraz"].ToString();
                obrazy[i] = obraz;
                i++;
            }
            thisReader.Close();
            polaczenie.Close();

            if (nr <= ileKolumn)
            {
                m.obrazKol1 = obrazy[0];
                nr++;
            }
            if (nr <= ileKolumn)
            {
                m.obrazKol2 = obrazy[1];
                nr++;
            }
            if (nr <= ileKolumn)
            {
                m.obrazKol3 = obrazy[2];
                nr++;
            }
            if (nr <= ileKolumn)
            {
                m.obrazKol4 = obrazy[3];
                nr++;
            }
            if (nr <= ileKolumn)
            {
                m.obrazKol5 = obrazy[4];
                nr++;
            }
            if (nr <= ileKolumn)
            {
                m.obrazKol6 = obrazy[5];
                nr++;
            }
            if (nr <= ileKolumn)
            {
                m.obrazKol7 = obrazy[6];
                nr++;
            }
            if (nr <= ileKolumn)
            {
                m.obrazKol8 = obrazy[7];
                nr++;
            }
        }
    }
}
