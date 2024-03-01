using WMS___Projekt.Forms;

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
            LoginForm loginForm = new LoginForm();
            MainForm mainForm = new MainForm();
            Application.Run(mainForm);
            mainForm.Hide();
            loginForm.ShowDialog();

            

            // Run the login form
            // Application.Run(new MainForm()); // Example for running the main form directly
        }
    }
}