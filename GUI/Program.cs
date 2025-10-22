namespace GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new frmLogin());
            while (true)
            {
                using (frmLogin log = new frmLogin())
                {
                    DialogResult result = log.ShowDialog();
                    if (result == DialogResult.OK && log.NextForm != null)
                    {
                        Application.Run(log.NextForm);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        
            
        
    }
    }
}