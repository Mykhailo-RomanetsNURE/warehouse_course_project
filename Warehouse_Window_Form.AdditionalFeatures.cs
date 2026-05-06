namespace Курсовий_проєкт_на_тему_склад
{
    public partial class Warehouse_Window_Form : Form
    {
        private void daeleteAllData_AdditionalFeatures_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевненні що хочете видалити всі данні, повернутись назад буде неможливо","Підтвердження", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                warehouse.ClearWarehouse();
                loadDataToTable("1");
                productInfo_ViewProducts_Panel.Visible = false;
                LoadItemsToInvoiceTable();
                productId_Invoice_TextBox.Text = "";
                LoadItemsToInvoiceTable();
                LoadDataToHistoryTable("1");
                LoadItemsToInvoiceHistoryTable("1");
                invoice_InvoiceHistory_Panel.Visible = false;
                invoiceSearchWithId_InvoiceHistory_TextBox.Text = "";
            }
        }
        private void saveProductsIntxtFile_AdditionalFeatures_Button_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveDialog.FileName = $"Список продуктів на складі станом на {DateTime.Now:yyyy-MM-dd}.txt";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                if (warehouse.ExportProductsToFile(saveDialog))
                {
                    MessageBox.Show("Дані успішно експортовані у файл.");
                }
                else
                {
                    MessageBox.Show("Помилка при експорті даних у файл.");
                }
            }
        }
    }
}
