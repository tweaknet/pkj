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
    class DodajDoWykresuGranice
    {
        int skok = 5;
        public void DodajDoWykresu1(MainForm m, int nrPomiaru)
        {
            if (m.nrPomiaruLicznik == nrPomiaru)
            {
                nrPomiaru += skok;
                m.wykPomiaru1.Series[1].Values.Clear();
                m.wykPomiaru1.Series[1].Values.Add(new ObservablePoint(m.grDolKol1, 1));
                m.wykPomiaru1.Series[1].Values.Add(new ObservablePoint(m.grDolKol1, nrPomiaru));
                m.wykPomiaru1.Series[2].Values.Clear();
                m.wykPomiaru1.Series[2].Values.Add(new ObservablePoint(m.grGorKol1, 1));
                m.wykPomiaru1.Series[2].Values.Add(new ObservablePoint(m.grGorKol1, nrPomiaru));
                m.nrPomiaruLicznik += skok;
            }
        }
        public void DodajDoWykresu2(MainForm m, int nrPomiaru)
        {
            if (m.nrPomiaruLicznik - skok == nrPomiaru)
            {
                nrPomiaru += skok;
                m.wykPomiaru2.Series[1].Values.Clear();
                m.wykPomiaru2.Series[1].Values.Add(new ObservablePoint(m.grDolKol2, 1));
                m.wykPomiaru2.Series[1].Values.Add(new ObservablePoint(m.grDolKol2, nrPomiaru));
                m.wykPomiaru2.Series[2].Values.Clear();
                m.wykPomiaru2.Series[2].Values.Add(new ObservablePoint(m.grGorKol2, 1));
                m.wykPomiaru2.Series[2].Values.Add(new ObservablePoint(m.grGorKol2, nrPomiaru));
            }
        }
        public void DodajDoWykresu3(MainForm m, int nrPomiaru)
        {
            if (m.nrPomiaruLicznik - skok == nrPomiaru)
            {
                nrPomiaru += skok;
                m.wykPomiaru3.Series[1].Values.Clear();
                m.wykPomiaru3.Series[1].Values.Add(new ObservablePoint(m.grDolKol3, 1));
                m.wykPomiaru3.Series[1].Values.Add(new ObservablePoint(m.grDolKol3, nrPomiaru));
                m.wykPomiaru3.Series[2].Values.Clear();
                m.wykPomiaru3.Series[2].Values.Add(new ObservablePoint(m.grGorKol3, 1));
                m.wykPomiaru3.Series[2].Values.Add(new ObservablePoint(m.grGorKol3, nrPomiaru));
            }
        }
        public void DodajDoWykresu4(MainForm m, int nrPomiaru)
        {
            if (m.nrPomiaruLicznik - skok == nrPomiaru)
            {
                nrPomiaru += skok;
                m.wykPomiaru4.Series[1].Values.Clear();
                m.wykPomiaru4.Series[1].Values.Add(new ObservablePoint(m.grDolKol4, 1));
                m.wykPomiaru4.Series[1].Values.Add(new ObservablePoint(m.grDolKol4, nrPomiaru));
                m.wykPomiaru4.Series[2].Values.Clear();
                m.wykPomiaru4.Series[2].Values.Add(new ObservablePoint(m.grGorKol4, 1));
                m.wykPomiaru4.Series[2].Values.Add(new ObservablePoint(m.grGorKol4, nrPomiaru));
            }
        }
        public void DodajDoWykresu5(MainForm m, int nrPomiaru)
        {
            if (m.nrPomiaruLicznik - skok == nrPomiaru)
            {
                nrPomiaru += skok;
                m.wykPomiaru5.Series[1].Values.Clear();
                m.wykPomiaru5.Series[1].Values.Add(new ObservablePoint(m.grDolKol5, 1));
                m.wykPomiaru5.Series[1].Values.Add(new ObservablePoint(m.grDolKol5, nrPomiaru));
                m.wykPomiaru5.Series[2].Values.Clear();
                m.wykPomiaru5.Series[2].Values.Add(new ObservablePoint(m.grGorKol5, 1));
                m.wykPomiaru5.Series[2].Values.Add(new ObservablePoint(m.grGorKol5, nrPomiaru));
            }
        }
        public void DodajDoWykresu6(MainForm m, int nrPomiaru)
        {
            if (m.nrPomiaruLicznik - skok == nrPomiaru)
            {
                nrPomiaru += skok;
                m.wykPomiaru6.Series[1].Values.Clear();
                m.wykPomiaru6.Series[1].Values.Add(new ObservablePoint(m.grDolKol6, 1));
                m.wykPomiaru6.Series[1].Values.Add(new ObservablePoint(m.grDolKol6, nrPomiaru));
                m.wykPomiaru6.Series[2].Values.Clear();
                m.wykPomiaru6.Series[2].Values.Add(new ObservablePoint(m.grGorKol6, 1));
                m.wykPomiaru6.Series[2].Values.Add(new ObservablePoint(m.grGorKol6, nrPomiaru));
            }
        }
        public void DodajDoWykresu7(MainForm m, int nrPomiaru)
        {
            if (m.nrPomiaruLicznik - skok == nrPomiaru)
            {
                nrPomiaru += skok;
                m.wykPomiaru7.Series[1].Values.Clear();
                m.wykPomiaru7.Series[1].Values.Add(new ObservablePoint(m.grDolKol7, 1));
                m.wykPomiaru7.Series[1].Values.Add(new ObservablePoint(m.grDolKol7, nrPomiaru));
                m.wykPomiaru7.Series[2].Values.Clear();
                m.wykPomiaru7.Series[2].Values.Add(new ObservablePoint(m.grGorKol7, 1));
                m.wykPomiaru7.Series[2].Values.Add(new ObservablePoint(m.grGorKol7, nrPomiaru));
            }
        }
        public void DodajDoWykresu8(MainForm m, int nrPomiaru)
        {
            if (m.nrPomiaruLicznik - skok == nrPomiaru)
            {
                nrPomiaru += skok;
                m.wykPomiaru8.Series[1].Values.Clear();
                m.wykPomiaru8.Series[1].Values.Add(new ObservablePoint(m.grDolKol8, 1));
                m.wykPomiaru8.Series[1].Values.Add(new ObservablePoint(m.grDolKol8, nrPomiaru));
                m.wykPomiaru8.Series[2].Values.Clear();
                m.wykPomiaru8.Series[2].Values.Add(new ObservablePoint(m.grGorKol8, 1));
                m.wykPomiaru8.Series[2].Values.Add(new ObservablePoint(m.grGorKol8, nrPomiaru));
            }
        }
    }
}
