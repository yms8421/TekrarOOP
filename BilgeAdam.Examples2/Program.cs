using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.Examples2
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
            Application.Run(new frmGame());

            var numbers1 = new int[5];
            var numbers2 = new int[2, 5];
            numbers1[0] = 12;

            numbers2[1, 2] = 12;
        }
    }
}
