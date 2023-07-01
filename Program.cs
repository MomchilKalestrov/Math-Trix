using System.Windows.Forms;
using System;

namespace MathTrix
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Window());
        }
    }
}