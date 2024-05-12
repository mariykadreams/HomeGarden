using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if(Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware(); //строка щоб не було блюру windows form 1

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignInUser());
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")] //строка щоб не було блюру windows form 2

        private static extern bool SetProcessDPIAware();//строка щоб не було блюру windows form 3

    }
}
