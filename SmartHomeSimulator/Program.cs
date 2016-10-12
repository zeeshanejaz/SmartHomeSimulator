using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SmartHomeSimulator.Model;
using SmartHomeSimulator.Parsing;
using SmartHomeSimulator.Comm;

namespace SmartHomeSimulator
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

            using (ProtocolManager manager = ProtocolManager.Instance)
            {
                Building building = ModelController.Instance.Model;
                ViewForm view = FormFactory.CreateForm(building);

                Application.ThreadException += Application_ThreadException;
                Application.Run(view);
            }
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            ViewForm.Instance.AddLog("Outside");
        }
    }
}
