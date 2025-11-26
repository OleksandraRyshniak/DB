using System.Globalization;

namespace toode
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string lang = Properties.Settings.Default.UserLanguage;
            if (string.IsNullOrWhiteSpace(lang))
            {
                lang = "et-EE";
            }
            try
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
                Thread.CurrentThread.CurrentCulture = new CultureInfo(lang);
            }
            catch (CultureNotFoundException)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("et-EE");
                Thread.CurrentThread.CurrentCulture = new CultureInfo("et-EE");
            }
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}