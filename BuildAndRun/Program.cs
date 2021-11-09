using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildAndRun {
    static class Program {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlAppDomain)]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
