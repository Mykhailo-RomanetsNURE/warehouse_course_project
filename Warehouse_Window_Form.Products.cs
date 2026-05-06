namespace Курсовий_проєкт_на_тему_склад
{
	public partial class Warehouse_Window_Form : Form
    {
        /*перегляд списку товарів*/
        private void LoadDataToTable(string pageNumber, int num = 0)
        {
            if (!int.TryParse(pageNumber, out int pageNumberInt))
            {
                pageNumberInt = 1;
            }
            else
            {
                pageNumberInt += num;
            }

            string searchText = search_ViewProducts_TextBox.Text.Trim();
            string selectedItem = search_ViewProducts_СomboBox.Text.Trim();
            bool isSearchOn = search_Products_CheckBox.Checked;

            var result = warehouse.DataProductTable(pageNumberInt, searchText, selectedItem, isSearchOn);

            tableOfProducts_ViewProducts_DataGridView.AutoGenerateColumns = false;
            tableOfProducts_ViewProducts_DataGridView.DataSource = null;
            tableOfProducts_ViewProducts_DataGridView.DataSource = result.itemsForPage;

            thisPage_ViewProductsNumber_Label.Text = result.pageNumber.ToString();
            allPageNumber_ViewProducts_Label.Text = result.totalPages.ToString();
            searchCommentNumber_Products_Label.Text = result.totalItems.ToString();
            getPage_ViewProducts_TextBox.Text = result.pageNumber.ToString();
        }
        private void Search_ViewProducts_СomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataToTable("1");
        }
        private void GetPage_ViewProducts_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string input = getPage_ViewProducts_TextBox.Text.Trim();
                LoadDataToTable(input);

                this.SelectNextControl(this.ActiveControl, true, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void PreviousPage_ViewProducts_Button_Click(object sender, EventArgs e)
        {
            string input = thisPage_ViewProductsNumber_Label.Text.Trim();
            LoadDataToTable(input, -1);
        }
        private void NextPage_ViewProducts_Button_Click(object sender, EventArgs e)
        {
            string input = thisPage_ViewProductsNumber_Label.Text.Trim();
            LoadDataToTable(input, 1);
        }
        private void Search_Products_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
             LoadDataToTable("1");
        }
        private void SearchWithName_ViewProducts_TextBox_TextChanged(object sender, EventArgs e)
        {
            LoadDataToTable("1");
        }
        /*перегляд товару*/
        private void AllProductTable_ViewProducts_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                productInfo_ViewProducts_Panel.Visible = true;
                var row = tableOfProducts_ViewProducts_DataGridView.Rows[e.RowIndex];
                int thisId = Convert.ToInt32(row.Cells["id_AllProduct_TableColumn"].Value);
                Product thisProduct = warehouse.TakeProduct(thisId);
                name_ViewSpecificProduct_TextBox.Clear();
                price_ViewSpecificProduct_TextBox.Clear();
                height_ViewSpecificProduct_TextBox.Clear();
                width_ViewSpecificProduct_TextBox.Clear();
                length_ViewSpecificProduct_TextBox.Clear();
                weight_ViewSpecificProduct_TextBox.Clear();
                note_ViewSpecificProduct_TextBox.Clear();
                name_ViewSpecificProduct_TextBox.Text = thisProduct.Name;
                id_ViewSpecificProduct_Label.Text = Convert.ToString(thisProduct.Id);
                price_ViewSpecificProduct_TextBox.Text = Convert.ToString(thisProduct.Price);
                height_ViewSpecificProduct_TextBox.Text = Convert.ToString(thisProduct.Height);
                width_ViewSpecificProduct_TextBox.Text = Convert.ToString(thisProduct.Width);
                length_ViewSpecificProduct_TextBox.Text = Convert.ToString(thisProduct.Length);
                weight_ViewSpecificProduct_TextBox.Text = Convert.ToString(thisProduct.Weight);
                note_ViewSpecificProduct_TextBox.Text = thisProduct.Note;
                quantity_ViewSpecificProduct_Label.Text = Convert.ToString(thisProduct.Quantity);
                time_ViewSpecificProduct_Label.Text = Convert.ToString(thisProduct.DateAndTime);
                LoadHistoryToTable("1", Convert.ToString(thisId));
                historyGetPage_ViewSpecificProduct_TextBox.Text = "1";
            }
        }
        private void Close_ViewSpecificProduct_Button_Click(object sender, EventArgs e)
        {
            productInfo_ViewProducts_Panel.Visible = false;
            string input = thisPage_ViewProductsNumber_Label.Text.Trim();
            LoadDataToTable(input);
        }
        private void SaveAndClose_ViewSpecificProduct_Button_Click(object sender, EventArgs e)
        {
            if (int.TryParse(id_ViewSpecificProduct_Label.Text.Trim(), out int thisId))
            {
                int index = warehouse.InvoiceList.FindIndex(x => x.Id == thisId);
                if (index == -1)
                {
                    Product newInfoProduct = warehouse.TakeProduct(thisId);
                    string name = name_ViewSpecificProduct_TextBox.Text.Trim();
                    string note = note_ViewSpecificProduct_TextBox.Text.Trim();
                    string price = price_ViewSpecificProduct_TextBox.Text.Trim();
                    string height = height_ViewSpecificProduct_TextBox.Text.Trim();
                    string width = width_ViewSpecificProduct_TextBox.Text.Trim();
                    string length = length_ViewSpecificProduct_TextBox.Text.Trim();
                    string weight = weight_ViewSpecificProduct_TextBox.Text.Trim();
                    bool[] isAllTrue = Product.ChangeProductInfo(newInfoProduct.Id, name, price, newInfoProduct.Quantity.ToString(), height, width, length, weight, note, newInfoProduct, warehouse);
                    if (isAllTrue.All(x => x == true))
                    {
                        productInfo_ViewProducts_Panel.Visible = false;
                        string inputPageNumder = thisPage_ViewProductsNumber_Label.Text.Trim();
                        LoadDataToTable(inputPageNumder);
                    }
                    else
                    {
                        string errorMessage = "";
                        if (isAllTrue[0] == false)
                        {
                            errorMessage += "Назва не може бути порожньою або повторюватись.\n";
                        }
                        if (isAllTrue[1] == false)
                        {
                            errorMessage += "Ціна повинна бути додатним числом і більшою за 0.\n";
                        }
                        if (isAllTrue[3] == false)
                        {
                            errorMessage += "Висота повинна бути невід'ємним числом.\n";
                        }
                        if (isAllTrue[4] == false)
                        {
                            errorMessage += "Ширина повинна бути невід'ємним числом.\n";
                        }
                        if (isAllTrue[5] == false)
                        {
                            errorMessage += "Довжина повинна бути невід'ємним числом.\n";
                        }
                        if (isAllTrue[6] == false)
                        {
                            errorMessage += "Вага повинна бути невід'ємним числом.\n";
                        }
                        MessageBox.Show(errorMessage, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Зміна характеристик товару неможлива підчас того як він приймає участь у створенні нової накладної.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CopyId_ViewSpecificProduct_Button_Click(object sender, EventArgs e)
        {
            if (id_ViewSpecificProduct_Label.Text != "" || id_ViewSpecificProduct_Label.Text != null)
            {
                Clipboard.SetText(id_ViewSpecificProduct_Label.Text);
            }
        }
        private void Delete_ViewSpecificProduct_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Видалений товар не можливо буде повернути, залишаться лише записи в історії. Ви впевнені Що хочете його видалити?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                if (int.TryParse(id_ViewSpecificProduct_Label.Text, out int id))
                {
                    warehouse.RemoveProduct(id);
                    if (int.TryParse(productId_Invoice_TextBox.Text.Trim(), out int productId))
                    {
                        if (productId == id)
                        {
                            productId_Invoice_TextBox.Clear();
                            LoadProductDataInvoniceItem();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Щось пішло не так, незнвйден Id", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                productInfo_ViewProducts_Panel.Visible = false;
                string inputPageNumder = thisPage_ViewProductsNumber_Label.Text.Trim();
                LoadDataToTable(inputPageNumder);
            }
        }
        /*Перегляд історії товару*/
        private void LoadHistoryToTable(string pageNumber, string id, int num = 0)
        {
            if (!int.TryParse(id, out int idInt))
            {
                idInt = 0;
            }
            if (!int.TryParse(pageNumber, out int pageNumberInt))
            {
                pageNumberInt = 1;
            }
            else
            {
                pageNumberInt += num;
            }
            var result = warehouse.HistoryDataTable(pageNumberInt, idInt);
            history_ViewSpecificProduct_DataGridView.AutoGenerateColumns = false;
            history_ViewSpecificProduct_DataGridView.DataSource = null;
            history_ViewSpecificProduct_DataGridView.DataSource = result.itemsForTable;

            historyLastPage_ViewSpecificProduct_Label.Text = result.totalPages.ToString();
            historyThisPageNumber_ViewSpecificProduct_Label.Text = result.pageNumber.ToString();
        }
        private void HistoryPreviousPage_ViewSpecificProduct_Button_Click(object sender, EventArgs e)
        {
            string thisId = id_ViewSpecificProduct_Label.Text.Trim();
            string input = historyThisPageNumber_ViewSpecificProduct_Label.Text.Trim();
            LoadHistoryToTable(input, thisId, -1);
        }
        private void HistoryNextPage_ViewSpecificProduct_Button_Click(object sender, EventArgs e)
        {
            string thisId = id_ViewSpecificProduct_Label.Text.Trim();
            string input = historyThisPageNumber_ViewSpecificProduct_Label.Text.Trim();
            LoadHistoryToTable(input, thisId, 1);
        }
        private void HistoryGetPage_ViewSpecificProduct_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string input = historyGetPage_ViewSpecificProduct_TextBox.Text.Trim();
                string thisId = id_ViewSpecificProduct_Label.Text.Trim();
                LoadHistoryToTable(input, thisId);

                this.SelectNextControl(this.ActiveControl, true, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void DeleteHistory_ViewSpecificProduct_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Якщо ви видалите історію товару, всі записи будуть безповоротно втрачені. Ви впевнені?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string thisId = id_ViewSpecificProduct_Label.Text.Trim();
                warehouse.CleanHistoryProduct(Convert.ToInt32(thisId));
                LoadHistoryToTable("1", thisId);
            }
        }

    }
}
