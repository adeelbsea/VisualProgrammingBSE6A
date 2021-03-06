﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    static class Program
    {

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SystemParametersInfo(int uAction, int uParam, int lpvParam, int fuWinIni);

        private const int SPI_SETKEYBOARDCUES = 4107; //100B
        private const int SPIF_SENDWININICHANGE = 2;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // always show accelerator underlines
            SystemParametersInfo(SPI_SETKEYBOARDCUES, 0, 1, 0);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new fmKeyboard("Adeel nawaz ", 5));
            //Application.Run(new fmResult(1,3,4,6,6));
            Application.Run(new fmMain());

            SystemParametersInfo(SPI_SETKEYBOARDCUES, 0, 0, 0);
        }
    }
}
