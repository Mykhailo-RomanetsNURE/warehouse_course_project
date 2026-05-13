namespace Курсовий_проєкт_на_тему_склад
{
	public class Invoice
	{
        /*клас для створення накладної що буде збережена в історію*/
		public int InvoiceId { get; set; }/*Id накладної для пошуку в історії накладних*/
		public DateTime Date { get; set; }/*дата створення накладної*/
        public string Type {  get; set; }/*тип накладної для відображення у таблиці*/
		public bool IsExpenditureInvoice { get; set; }/*визначення типу накладної для використанння в коді true прибуткова чи false видаткова накладна*/
		public List<ItemOfInvoice> Items { get; set; }/*Список товарів що містились у накладній*/
		public Invoice(Warehouse warehouse, bool isExpenditureInvoice, List<ItemOfInvoice> items)/*Стандартний конструктор для створення накладної заповненої товарами*/
		{
			this.InvoiceId = warehouse.InvoiceLastId;
			this.Date = DateTime.Now;
			this.IsExpenditureInvoice = isExpenditureInvoice;
            if (isExpenditureInvoice)
            {
                this.Type = "Прибуткова";
            }
            else
            {
                this.Type = "Видаткова";
            }
			this.Items = new List<ItemOfInvoice>(items);
		}
		public Invoice()/*конструктор для створення порожньої накладної*/
		{
			this.InvoiceId = 0;
            this.Date = DateTime.Now;
			this.IsExpenditureInvoice = true;
            this.Type = "Прибуткова";
            this.Items = new List<ItemOfInvoice>();
        }
        public void ExportInvoiceToFile()/*метод для збереження накладної у текстовий файл для читання користувачем*/
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveDialog.FileName = $"Накладна з ID {this.InvoiceId}.txt";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using StreamWriter writer = new StreamWriter(saveDialog.FileName);
                    writer.WriteLine($"Id накладної: {this.InvoiceId}");
                    writer.WriteLine($"Дата створення: {this.Date}");
                    writer.WriteLine($"Тип накладної: {(this.IsExpenditureInvoice ? "Прибуткова" : "Видаткова")}");
                    writer.WriteLine(new string('=', 60));
                    foreach (var item in this.Items)
                    {
                        writer.WriteLine(item.ToString());
                        writer.WriteLine(new string('-', 60));
                    }
                    MessageBox.Show("Накладна успішно експортована!");
                }
                catch
                {
                    MessageBox.Show("Нажаль виникла помилка при запису файлу");
                }
            }
        }
    }
}
