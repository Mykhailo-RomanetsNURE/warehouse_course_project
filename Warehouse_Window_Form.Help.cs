namespace Курсовий_проєкт_на_тему_склад
{
    public partial class Warehouse_Window_Form : Form
    {
        private void HelpHide_Help_Button_Click(object sender, EventArgs e)
        {
            program_TabControl.SelectedIndex = 0;
            program_TabControl.TabPages.Remove(Help_TabPage);
        }
    }
}
