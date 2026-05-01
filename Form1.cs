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
            loadDataToTable(1);

            LoadItemsToInvoiceTable();
            LoadProductDataInvoniceItem();
            TypeOfInvoice_Invoice_ComboBox.SelectedIndex = 0;

            LoadDataToHistoryTable(1);
        }
        private System.Windows.Forms.Timer notificationTimer = new System.Windows.Forms.Timer();
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (program_TabControl.SelectedIndex == 0)
            {
                if (int.TryParse(historyThisPageNumber_ViewSpecificProduct_Label.Text, out int pageNumber))
                {
                    getPage_ViewProducts_TextBox.Text = historyThisPageNumber_ViewSpecificProduct_Label.Text;
                    loadDataToTable(pageNumber);
                }
                else
                {
                    getPage_ViewProducts_TextBox.Text = "1";
                    loadDataToTable(1);
                }
            }
            if (program_TabControl.SelectedIndex == 3)
            {
                if (int.TryParse(thisPage_History_Label.Text, out int pageNumber))
                {
                    getPage_History_TextBox.Text = thisPage_History_Label.Text;
                    LoadDataToHistoryTable(pageNumber);
                }
                else
                {
                    getPage_History_TextBox.Text = "1";
                    LoadDataToHistoryTable(1);
                }
            }
        }
        
    }
}
