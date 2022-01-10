using ADonet.Db;
using ADonet.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADonet
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var context = ContextFactory.GetContext();
            DbInitialaizer.Initialaize(context);

            var service = new ItemService(context);

            Application.Run(new Form1(service));
        }
    }
}
