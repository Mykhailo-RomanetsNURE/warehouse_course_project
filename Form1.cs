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
                string pageNumber = thisPage_InvoiceHistory_Label.Text.Trim();
                LoadItemsToInvoiceHistoryTable(pageNumber);
            }
        }
        private void Warehouse_Window_Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                var result = MessageBox.Show("Ви впевнені, що хочете вийти з програми (данні будуть збережені)?", "Підтвердження виходу", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    warehouse.ClearNewInvoice();
                    FileSaveLoad.Save(warehouse);
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
        private void saveAndClose_Window_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ви впевнені, що хочете вийти з програми (данні будуть збережені)?", "Підтвердження виходу", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                warehouse.ClearNewInvoice();
                FileSaveLoad.Save(warehouse);
                this.Close();
            }
        }
    }
}
