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
            search_ViewProducts_СomboBox.SelectedIndex = search_ViewProducts_СomboBox.FindStringExact("Назва");
            loadDataToTable(1);
            LoadProductDataInvoniceItem();
        }
        private System.Windows.Forms.Timer notificationTimer = new System.Windows.Forms.Timer();

        private void addNewInvoice_Button_Click(object sender, EventArgs e)
        {
        }
    }
}
