namespace Курсовий_проєкт_на_тему_склад
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Warehouse warehouse = FileSaveLoad.Load();
            Application.Run(new Warehouse_Window_Form(warehouse));
        }
    }
}