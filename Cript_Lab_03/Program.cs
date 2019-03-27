using System;
using System.Windows.Forms;

namespace Cript_Lab_03
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new General());
        }
    }
}
