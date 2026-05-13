using System.Text.Json;
using Курсовий_проєкт_на_тему_склад;
public static class FileSaveLoad
{
    /*Клас що повинен надавати методи для збереження та завантаження данних програми у файл*/
    private static readonly string _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SaveDataWarehouse.json");
    public static void Save(Warehouse warehouse)/*Метод для збереження данних програми у файл*/
    {
        try
        {
            string json = JsonSerializer.Serialize(warehouse);
            File.WriteAllText(_filePath, json);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Помилка підчас збереження у файл, спробуйте зберегти знову.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    public static Warehouse Load()/*Метод для читання та повернення данних з файлу у програму*/
    {
        if (!File.Exists(_filePath))
        {
            return new Warehouse();
        }

        try
        {
            string json = File.ReadAllText(_filePath);
            if (string.IsNullOrWhiteSpace(json)) return new Warehouse();
            var result = JsonSerializer.Deserialize<Warehouse>(json);
            return result ?? new Warehouse();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Помилка підчас зчитування данних, нажаль невдалось завантажити збережені данні, можливо данні були видалені або пошкодженні", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return new Warehouse();
        }
    }
}
