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
    class SprawdzPrzekroczenieGranicy
    {
        static readonly string connectionString = ConfigurationManager.ConnectionStrings["pkj"].ConnectionString;
        MainForm instancemainForm;
        public void Sprawdz(MainForm m, int nrKolumny, int nrPomiaru)
        {
            instancemainForm = m;
            if (nrKolumny == 1)
            {
                if (Convert.ToDouble(m.polePomiaru1.Text) < m.grDolKol1 | Convert.ToDouble(m.polePomiaru1.Text) > m.grGorKol1)
                    Zapisz(m, 1, nrPomiaru);
            }
            if (nrKolumny == 2)
            {
                if (Convert.ToDouble(m.polePomiaru2.Text) < m.grDolKol2 | Convert.ToDouble(m.polePomiaru2.Text) > m.grGorKol2)
                    Zapisz(m, 2, nrPomiaru);
            }
            if (nrKolumny == 3)
            {
                if (Convert.ToDouble(m.polePomiaru3.Text) < m.grDolKol3 | Convert.ToDouble(m.polePomiaru3.Text) > m.grGorKol3)
                    Zapisz(m, 3, nrPomiaru);
            }
            if (nrKolumny == 4)
            {
                if (Convert.ToDouble(m.polePomiaru4.Text) < m.grDolKol4 | Convert.ToDouble(m.polePomiaru4.Text) > m.grGorKol4)
                    Zapisz(m, 4, nrPomiaru);
            }
            if (nrKolumny == 5)
            {
                if (Convert.ToDouble(m.polePomiaru5.Text) < m.grDolKol5 | Convert.ToDouble(m.polePomiaru5.Text) > m.grGorKol5)
                    Zapisz(m, 5, nrPomiaru);
            }
            if (nrKolumny == 6)
            {
                if (Convert.ToDouble(m.polePomiaru6.Text) < m.grDolKol6 | Convert.ToDouble(m.polePomiaru6.Text) > m.grGorKol6)
                    Zapisz(m, 6, nrPomiaru);
            }
            if (nrKolumny == 7)
            {
                if (Convert.ToDouble(m.polePomiaru7.Text) < m.grDolKol7 | Convert.ToDouble(m.polePomiaru7.Text) > m.grGorKol7)
                    Zapisz(m, 7, nrPomiaru);
            }
            if (nrKolumny == 8)
            {
                if (Convert.ToDouble(m.polePomiaru8.Text) < m.grDolKol8 | Convert.ToDouble(m.polePomiaru8.Text) > m.grGorKol8)
                    Zapisz(m, 8, nrPomiaru);
            }
        }
        public void Zapisz(MainForm m, int nrKolumny, int nrPomiaru)
        {
            instancemainForm = m;
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("pkj.ZapiszPrzekroczenieGranicy", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@nazwaStanowiska", m.lbStatusStanowisko.Text);
                sqlCmd.Parameters.AddWithValue("@idZlecenia", m.idWybranegoZlecenia);
                sqlCmd.Parameters.AddWithValue("@nrKolumny", nrKolumny);
                sqlCmd.Parameters.AddWithValue("@idUser", m.DajIdLoginu(m.login));
                sqlCmd.Parameters.AddWithValue("@nr_sztuki", nrPomiaru);
                sqlCmd.ExecuteNonQuery();
            }
        }
    }
}
