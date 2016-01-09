using Pizzaria.View.UI.ViewMenu;
using System;
using System.Windows.Forms;

namespace Pizzaria.View
{
    static class Program
    {
      
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new frmMenu());
        }
    }
}
