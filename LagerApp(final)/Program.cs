namespace LagerApp_final_
{
    internal static class Program
    {

        public static Database Database { get; private set; } //Declare database
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            string connectionString = "Server=localhost;Database=ProjectLager;Trusted_Connection=True;TrustServerCertificate=True";
            Database = new Database(connectionString); // Initialize the connection




            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}