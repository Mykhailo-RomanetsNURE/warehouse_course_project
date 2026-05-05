using System;

namespace Курсовий_проєкт_на_тему_склад
{
    public partial class Warehouse_Window_Form : Form
    {
        public void LoadDataToHistoryTable(string pageNumber,int num = 0)
        {
            if (!int.TryParse(pageNumber, out int pageNumberInt))
            {
                pageNumberInt = 1;
            }
            else
            {
                pageNumberInt += num;
            }
                var result = warehouse.HistoryDataTable(pageNumberInt);

            historyTable_History_DataGridView.AutoGenerateColumns = false;
            historyTable_History_DataGridView.DataSource = null;
            historyTable_History_DataGridView.DataSource = result.itemsForTable;

            thisPage_History_Label.Text = result.pageNumber.ToString();
            getPage_History_TextBox.Text = result.pageNumber.ToString();
            lastPage_History_Label.Text = result.totalPages.ToString();
        }
        private void PreviousPage_History_Button_Click(object sender, EventArgs e)
        {
            string input = thisPage_History_Label.Text.Trim();
            LoadDataToHistoryTable(input, -1);
        }
        private void NextPage_History_Button_Click(object sender, EventArgs e)
        {
            string input = thisPage_History_Label.Text.Trim();
            LoadDataToHistoryTable(input, 1);
        }
        private void GetPage_History_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string input = getPage_History_TextBox.Text.Trim();
                LoadDataToHistoryTable(input);
            }
        }
    }
}
