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
            // Subscribe to the FormChanged event
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Console.WriteLine("Projekt pokazowy, wykonany przez Przemyslawa Przybyszewskiego");

            // Create an instance of the initial form
            LoginForm loginForm = new LoginForm();
            FormManager.ShowForm(loginForm);

            while(Application.OpenForms.Count > 0)
            {
                Application.Run();
            }
        }
    }
}
