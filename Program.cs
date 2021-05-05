
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pkj
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
//            LoginForm logon = new LoginForm();
  //          Application.Run(logon);
            Application.Run(new LoginForm());
            //Application.Run(new MainForm("test"));
        }
    }
}
