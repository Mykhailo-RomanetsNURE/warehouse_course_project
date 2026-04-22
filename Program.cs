namespace Курсовий_проєкт_на_тему_склад
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}