using System;
using System.Windows.Forms;
using MacroTracker.Forms;

namespace MacroTracker
{
    static class MacroTracker
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseInterface.InitiateConnection();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuForm());

            DatabaseInterface.CloseConnection();
        }
    }
}
