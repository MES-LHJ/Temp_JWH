﻿using NewEmpManagement.Forms;
using System;
using System.Windows.Forms;

namespace NewEmpManagement
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ManageEmpForm());
        }
    }
}
