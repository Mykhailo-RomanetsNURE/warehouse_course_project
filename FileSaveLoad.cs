using System.Text.Json;
using Курсовий_проєкт_на_тему_склад;
public static class FileSaveLoad
{
    private static readonly string _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SaveDataWarehouse.json");
    public static void Save(Warehouse warehouse)
    {
        try
        {
            string json = JsonSerializer.Serialize(warehouse);
            File.WriteAllText(_filePath, json);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Помилка Підчас збереження у файл: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static Warehouse Load()
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
            MessageBox.Show($"Помилка підчас зчитування данних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return new Warehouse();
        }
    }
}
