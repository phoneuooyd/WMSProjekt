using WMS___Projekt.Forms;
using WMS___Projekt.Utillities;

namespace WMS___Projekt
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Subscribe to the FormChanged event
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create an instance of the initial form
            LoginForm loginForm = new LoginForm();

            // Run the application loop
            Application.Run(loginForm);
        }
    }
}