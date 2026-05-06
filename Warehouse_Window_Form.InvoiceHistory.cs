namespace Курсовий_проєкт_на_тему_склад
{
    public partial class Warehouse_Window_Form : Form
    {
        public void LoadItemsToInvoiceHistoryTable(string pageNumberStr, int num = 0)
        {
            if (int.TryParse(pageNumberStr, out int pageNumber))
            {
                pageNumber+= num;
            }
            else
            {
                pageNumber = 1;
            }
            var result = warehouse.ItemsToInvoiceHistoryTable(pageNumber);

            tableOfInvoiceHistory_InvoiceHistory_DataGridView.AutoGenerateColumns = false;
            tableOfInvoiceHistory_InvoiceHistory_DataGridView.DataSource = null;
            tableOfInvoiceHistory_InvoiceHistory_DataGridView.DataSource = result.itemsForPage;

            thisPage_InvoiceHistory_Label.Text = result.pageNumber.ToString();
            gatePage_InvoiceHistory_TextBox.Text = result.pageNumber.ToString();
            lastPage_InvoiceHistory_Label.Text = result.totalPages.ToString();
        }
        public void LoadInvoiceInInvoiceHistoryPage(int id)
        {
            var invoice = warehouse.TakeInvoice(id);
            if (invoice.InvoiceId != 0)
            {
                invoice_InvoiceHistory_Panel.Visible = true;
                idInvoice_InvoiceHistory_Label.Text = invoice.InvoiceId.ToString();
                if (invoice.IsExpenditureInvoice)
                {
                    typeInvoice_InvoiceHistory_Label.Text = "Прибуткова";

                }
                else
                {
                    typeInvoice_InvoiceHistory_Label.Text = "Видатна";
                }
                timeMakeInvoice_InvoiceHistory_Label.Text = invoice.Date.ToString();

                itemsOfInvoice_InvoiceHistory_DataGridView.AutoGenerateColumns = false;
                itemsOfInvoice_InvoiceHistory_DataGridView.DataSource = null;
                itemsOfInvoice_InvoiceHistory_DataGridView.DataSource = invoice.Items;
            }
        }
        private void PreviousPage_InvoiceHistory_Button_Click(object sender, EventArgs e)
        {
            string pageNumberStr = thisPage_InvoiceHistory_Label.Text.Trim();
            LoadItemsToInvoiceHistoryTable(pageNumberStr, -1);
        }
        private void GatePage_InvoiceHistory_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string pageNumberStr = gatePage_InvoiceHistory_TextBox.Text.Trim();
                LoadItemsToInvoiceHistoryTable(pageNumberStr);

                this.SelectNextControl(this.ActiveControl, true, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void NextPage_InvoiceHistory_Button_Click(object sender, EventArgs e)
        {
            string pageNumberStr = thisPage_InvoiceHistory_Label.Text.Trim();
            LoadItemsToInvoiceHistoryTable(pageNumberStr, 1);
        }
        private void InvoiceSearchWithId_InvoiceHistory_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(invoiceSearchWithId_InvoiceHistory_TextBox.Text.Trim(), out int id))
            {
                LoadInvoiceInInvoiceHistoryPage(id);
            }
        }
        private void TableOfInvoiceHistory_InvoiceHistory_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = tableOfInvoiceHistory_InvoiceHistory_DataGridView.Rows[e.RowIndex];
                int thisId = Convert.ToInt32(row.Cells["invoiceId_InvoiceHistory_DataGridViewTextBoxColumn"].Value);
                LoadInvoiceInInvoiceHistoryPage(thisId);
            }
        }
        private void CloseInvoice_InvoiceHistory_Button_Click(object sender, EventArgs e)
        {
            invoice_InvoiceHistory_Panel.Visible = false;
        }
        private void SaveInvoiceInFile_InvoiceHistory_Button_Click(object sender, EventArgs e)
        {
            if (int.TryParse(idInvoice_InvoiceHistory_Label.Text, out int id))
            {
                Invoice invoice = warehouse.TakeInvoice(id);
                if (invoice.InvoiceId != 0)
                {
                    invoice.ExportInvoiceToFile();
                }
            }
        }    
    }
}
