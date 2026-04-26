using System.Data;
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
            loadDataToTable(1);
        }
        private System.Windows.Forms.Timer notificationTimer = new System.Windows.Forms.Timer();

        private void allProductsPreviousPage_ViewProducts_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
