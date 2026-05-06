using System;
using Курсовий_проєкт_на_тему_склад;
namespace Курсовий_проєкт_на_тему_склад
{
	public class Invoice
	{
		public int InvoiceId { get; set; }
		public DateTime Date { get; set; }
		public bool IsExpenditureInvoice { get; set; }/*true прибуткова чи false видаткова накладна*/
		public List<ItemOfInvoice> Items { get; set; }
		public Invoice(Warehouse warehouse, bool isExpenditureInvoice, List<ItemOfInvoice> items)/**/
		{
			this.InvoiceId = warehouse.InvoiceLastId;
			this.Date = DateTime.Now;
			this.IsExpenditureInvoice = isExpenditureInvoice;
			this.Items = new List<ItemOfInvoice>(items);
		}
		public Invoice()
		{
			this.InvoiceId = 0;
            this.Date = DateTime.Now;
			this.IsExpenditureInvoice = true;
            this.Items = new List<ItemOfInvoice>();
        }
        public void ExportInvoiceToFile()
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
                    writer.WriteLine(new string('-', 60));
                    foreach (var item in this.Items)
                    {
                        writer.WriteLine(item.ToString());
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
