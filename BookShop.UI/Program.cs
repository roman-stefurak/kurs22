using BookShop.UI.Forms;
using System;
using System.Windows.Forms;

namespace BookShop.UI
{
    static class Program
    {
        /// <summary>
        /// Головна точка входу для програми
        /// </summary>
        [STAThread]
        static void Main()
        {           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthForm());
        }
    }
}
