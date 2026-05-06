using System;
using System.IO;
using System.Text.Json;
using Курсовий_проєкт_на_тему_склад;

public class FileSaveLoad
{
	private const string _filePath = "SaveDataWarehouse.json";

    public static void Save(Warehouse warehouse)
	{
		try
		{
			string json = JsonSerializer.Serialize(warehouse);
			File.WriteAllText(_filePath, json);
		}
		catch
		{

		}
	}
	public static Warehouse Load()
    {
        try
        {
            if (File.Exists(_filePath))
            {
                string json = File.ReadAllText(_filePath);
                return JsonSerializer.Deserialize<Warehouse>(json) ?? new Warehouse();
            }
        }
        catch
        {
        }
        return new Warehouse();
    }
}
