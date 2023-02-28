namespace IntNote
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string version = Application.ProductVersion;
            string filePath = args.Length > 0 ? args[0] : "";

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(version, filePath));
        }
    }
}