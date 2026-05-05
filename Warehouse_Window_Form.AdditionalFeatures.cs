namespace Курсовий_проєкт_на_тему_склад
{
    public partial class Warehouse_Window_Form : Form
    {
        public void ExportProductsToFile(List <Product> products)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveDialog.FileName = $"Products.txt";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using StreamWriter writer = new StreamWriter(saveDialog.FileName);
                    writer.WriteLine($"Наявні продукти на {DateTime.Now}");
                    writer.WriteLine(new string('=', 60));
                    foreach (var product in products)
                    {
                        writer.WriteLine($"Id товару на складі: {product.Id}");
                        writer.WriteLine($"Назва: {product.Name}");
                        writer.WriteLine($"Кількість: {product.Quantity}");
                        writer.WriteLine($"Останння ціна: {product.Price}");
                        writer.WriteLine($"Остання зміна кількості: {product.DateAndTime}");
                        writer.WriteLine($"висота: {product.Height}, довжина: {product.Length}, ширина: {product.Width}");
                        writer.WriteLine($"Вага: {product.Weight}");
                        writer.WriteLine($"Примітка: {product.Note}");
                        writer.WriteLine(new string('-', 0));
                        MessageBox.Show("Дані успішно експортовані у файл");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажаль виникла помилка при запису файлу");
                }
            }
        }
        private void daeleteAllData_AdditionalFeatures_Button_Click(object sender, EventArgs e)
        {
            warehouse.ClearWarehouse();
            loadDataToTable("1");
            productInfo_ViewProducts_Panel.Visible = false;
            LoadItemsToInvoiceTable();
            productId_Invoice_TextBox.Text = "";
            LoadItemsToInvoiceTable();
            LoadDataToHistoryTable(1);
            LoaditemsToInvoiceHistoryTable(1);
            invoice_InvoiceHistory_Panel.Visible = false;
            invoiceSearchWithId_InvoiceHistory_TextBox.Text = "";
        }
        private void saveProductsIntxtFile_AdditionalFeatures_Button_Click(object sender, EventArgs e)
        {
            ExportProductsToFile(warehouse.Products);
        }
    }
}
