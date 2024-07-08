using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_22521030_TranTienNhat
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Lab2_Bai1());
            //Application.Run(new Lab2_Bai2());
            //Application.Run(new Lab2_Bai3());
            //Application.Run(new Lab2_Bai4());
            //Application.Run(new Lab2_Bai5());
            Application.Run(new Menu());
        }
    }
}
