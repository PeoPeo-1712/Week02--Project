namespace WEEK01
{
    internal static class Program
    {
        // Day la comment cua hloc26
        // Hello
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FHocsinh());
            //Hello, my name is Ho Thanh Dat. I am 20 years old.
        }
    }
}