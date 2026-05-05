using System.Data;
using System.Drawing.Printing;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Курсовий_проєкт_на_тему_склад
{
    public partial class Warehouse_Window_Form : Form
    {
        public Warehouse warehouse;
        public Warehouse_Window_Form(Warehouse warehouse)
        {
            this.InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.warehouse = warehouse;

            search_ViewProducts_СomboBox.SelectedIndex = 0;
            loadDataToTable("1");

            LoadItemsToInvoiceTable();
            LoadProductDataInvoniceItem();
            typeOfInvoice_Invoice_ComboBox.SelectedIndex = 0;

            LoadDataToHistoryTable("1");
        }
        private System.Windows.Forms.Timer notificationTimer = new System.Windows.Forms.Timer();
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (program_TabControl.SelectedIndex == 0)
            {
                loadDataToTable(historyThisPageNumber_ViewSpecificProduct_Label.Text);
            }
            if (program_TabControl.SelectedIndex == 3)
            {
                string input = thisPage_History_Label.Text.Trim();
                LoadDataToHistoryTable(input);
            }
            if (program_TabControl.SelectedIndex == 4)
            {
                if (int.TryParse(thisPage_InvoiceHistory_Label.Text, out int pageNumber))
                {
                    LoaditemsToInvoiceHistoryTable(pageNumber);
                }
                else
                {
                    LoaditemsToInvoiceHistoryTable(1);
                }
            }
        }
        private void Warehouse_Window_Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                var result = MessageBox.Show("Ви впевнені, що хочете вийти з програми?", "Підтвердження виходу", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void ExportInvoiceToFile(Invoice invoice)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveDialog.FileName = $"Invoice_{invoice.InvoiceId}.txt";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using StreamWriter writer = new StreamWriter(saveDialog.FileName);
                    writer.WriteLine($"------------------ Id накладної: {invoice.InvoiceId} ------------------");
                    writer.WriteLine($"Дата створення: {invoice.Date}");
                    writer.WriteLine($"Тип накладної: {(invoice.IsExpenditureInvoice ? "Прибуткова" : "Видаткова")}");
                    writer.WriteLine(new string('-', 50));
                    foreach (var item in invoice.Items)
                    {
                        writer.WriteLine(item.ToString());
                    }
                    MessageBox.Show("Накладна успішно експортована!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нажаль виникла помилка при запису файлу");
                }
            }
        }
    }
}
