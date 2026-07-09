using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using REMS.UI.Customer_Management;
using REMS.UI.Factories;
using REMS.UI.Log_In;

namespace REMS.UI
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin(ServiceFactory.CreateUserService()));
        }
    }
}
