using REMS.UI.Composition;
using REMS.UI.Customer_Management;
using REMS.UI.Factories;
using REMS.UI.Log_In;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            IFormFactory formFactory = CompositionRoot.CreateFormFactory();

            Application.Run(new frmLogin(
                ServiceFactory.CreateUserService(),
                formFactory));
        }
    }
}
