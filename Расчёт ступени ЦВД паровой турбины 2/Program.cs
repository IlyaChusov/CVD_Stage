using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Расчёт_ступени_ЦВД_паровой_турбины_2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
