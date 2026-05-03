using System;

namespace Курсовий_проєкт_на_тему_склад
{
    public partial class Warehouse_Window_Form : Form
    {
        public void LoadDataToHistoryTable(int pageNumber)
        {
            int pageSize = 10;

            int totalItems = warehouse.History.Count;
            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);
            if (totalPages == 0) totalPages = 1;
            if (pageNumber > totalPages) pageNumber = totalPages;
            if (pageNumber < 1) pageNumber = 1;

            var itemsForPage = warehouse.History
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();

            historyTable_History_DataGridView.AutoGenerateColumns = false;
            historyTable_History_DataGridView.DataSource = null;
            historyTable_History_DataGridView.DataSource = itemsForPage;

            thisPage_History_Label.Text = pageNumber.ToString();
            getPage_History_TextBox.Text = pageNumber.ToString();
            lastPage_History_Label.Text = totalPages.ToString();
        }
        private void PreviousPage_History_Button_Click(object sender, EventArgs e)
        {
            string input = thisPage_History_Label.Text.Trim();
            if (input == "")
            {
                LoadDataToHistoryTable(1);
            }
            else
            {
                if (int.TryParse(input, out int pageNumber))
                {
                    LoadDataToHistoryTable(pageNumber - 1);
                }
                else
                {
                    LoadDataToHistoryTable(1);
                }
            }
        }
        private void NextPage_History_Button_Click(object sender, EventArgs e)
        {
            string input = thisPage_History_Label.Text.Trim();
            if (input == "")
            {
                LoadDataToHistoryTable(1);
            }
            else
            {
                if (int.TryParse(input, out int pageNumber))
                {
                    LoadDataToHistoryTable(pageNumber + 1);
                }
                else
                {
                    LoadDataToHistoryTable(1);
                }
            }
        }
        private void GetPage_History_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string input = getPage_History_TextBox.Text.Trim();
                if (input == "")
                {
                    LoadDataToHistoryTable(1);
                }
                else
                {
                    if (int.TryParse(input, out int pageNumber))
                    {
                        LoadDataToHistoryTable(pageNumber);
                    }
                    else
                    {
                        LoadDataToHistoryTable(1);
                    }
                }
            }
        }
    }
}
