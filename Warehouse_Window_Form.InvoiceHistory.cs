using System.Data;
using System.Drawing.Printing;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Курсовий_проєкт_на_тему_склад
{
    public partial class Warehouse_Window_Form : Form
    {
        public void LoaditemsToInvoiceHistoryTable(int pageNumber)
        {
            int pageSize = 10;

            int totalItems = warehouse.InvoicesHistory.Count;
            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);
            if (totalPages == 0) totalPages = 1;
            if (pageNumber > totalPages) pageNumber = totalPages;
            if (pageNumber < 1) pageNumber = 1;

            var itemsForPage = warehouse.InvoicesHistory
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();

            tableOfInvoiceHistory_InvoiceHistory_DataGridView.AutoGenerateColumns = false;
            tableOfInvoiceHistory_InvoiceHistory_DataGridView.DataSource = null;
            tableOfInvoiceHistory_InvoiceHistory_DataGridView.DataSource = itemsForPage;

            thisPage_InvoiceHistory_Label.Text = pageNumber.ToString();
            gatePage_InvoiceHistory_TextBox.Text = pageNumber.ToString();
            lastPage_InvoiceHistory_Label.Text = pageNumber.ToString();
        }
        public void LoadInvoiceInInvoiceHistoryPage(int id)
        {
            Invoice invoice = warehouse.InvoicesHistory.FirstOrDefault(inv => inv.InvoiceId == id);
            if (invoice != null)
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
        private void previousPage_InvoiceHistory_Button_Click(object sender, EventArgs e)
        {
            string pageNumberStr = thisPage_InvoiceHistory_Label.Text.Trim();
            if (int.TryParse(pageNumberStr, out int pageNumber))
            {
                LoaditemsToInvoiceHistoryTable(pageNumber - 1);
            }
            else
            {
                LoaditemsToInvoiceHistoryTable(1);
            }
        }
        private void gatePage_InvoiceHistory_TextBox_TextChanged(object sender, EventArgs e)
        {
            string pageNumberStr = gatePage_InvoiceHistory_TextBox.Text.Trim();
            if (int.TryParse(pageNumberStr, out int pageNumber))
            {
                LoaditemsToInvoiceHistoryTable(pageNumber);
            }
            else
            {
                LoaditemsToInvoiceHistoryTable(1);
            }
        }
        private void nextPage_InvoiceHistory_Button_Click(object sender, EventArgs e)
        {
            string pageNumberStr = thisPage_InvoiceHistory_Label.Text.Trim();
            if (int.TryParse(pageNumberStr, out int pageNumber))
            {
                LoaditemsToInvoiceHistoryTable(pageNumber + 1);
            }
            else
            {
                LoaditemsToInvoiceHistoryTable(1);
            }
        }
        private void invoiceSearchWithId_InvoiceHistory_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(invoiceSearchWithId_InvoiceHistory_TextBox.Text.Trim(), out int id))
            {
                LoadInvoiceInInvoiceHistoryPage(id);
            }
        }
        private void tableOfInvoiceHistory_InvoiceHistory_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = tableOfInvoiceHistory_InvoiceHistory_DataGridView.Rows[e.RowIndex];
                int thisId = Convert.ToInt32(row.Cells["invoiceId_InvoiceHistory_DataGridViewTextBoxColumn"].Value);
                LoadInvoiceInInvoiceHistoryPage(thisId);
            }
        }
        private void closeInvoice_InvoiceHistory_Button_Click(object sender, EventArgs e)
        {
            invoice_InvoiceHistory_Panel.Visible = false;
        }
        private void saveInvoiceInFile_InvoiceHistory_Button_Click(object sender, EventArgs e)
        {
            Invoice invoice = warehouse.InvoicesHistory.FirstOrDefault(inv => inv.InvoiceId.ToString() == idInvoice_InvoiceHistory_Label.Text);
            ExportInvoiceToFile(invoice);
        }    
    }
}
