using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Курсовий_проєкт_на_тему_склад
{
	public partial class Warehouse_Window_Form : Form
    {
        /*перегляд списку товарів*/
        private void loadDataToTable(int pageNumber)
        {
            int pageSize = 10;
            List<Product> sourceList = warehouse.Products;
            if (search_Products_CheckBox.Checked)
            {
                string searchText = search_ViewProducts_TextBox.Text.Trim();
                string selectedIItem = search_ViewProducts_СomboBox.Text;
                double doubleNumber = double.TryParse(searchText, out double d) ? d : -1;
                int intNumber = int.TryParse(searchText, out int n) ? n : -1;
                Dictionary<string, Func<Product, bool>> filters = new Dictionary<string, Func<Product, bool>>
                {
                    { "Назва", x => x.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase) },
                    { "Вартість",  x => x.Price == doubleNumber },
                    { "ID",    x => x.Id == intNumber },
                    { "Висота",  x => x.Height == doubleNumber },
                    { "Ширина",  x => x.Width == doubleNumber },
                    { "Довжина",  x => x.Length == doubleNumber },
                    { "Вага",  x => x.Weight == doubleNumber },
                    { "Примітка", x => x.Note.Contains(searchText, StringComparison.OrdinalIgnoreCase) }
                };
                sourceList = warehouse.Products.Where(filters[selectedIItem]).ToList();
            }
            int totalItems = sourceList.Count;
            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);
            if (totalPages == 0) totalPages = 1;
            if (pageNumber > totalPages) pageNumber = totalPages;
            if (pageNumber < 1) pageNumber = 1;

            var itemsForPage = sourceList
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();

            tableOfProducts_ViewProducts_DataGridView.AutoGenerateColumns = false;
            tableOfProducts_ViewProducts_DataGridView.DataSource = null;
            tableOfProducts_ViewProducts_DataGridView.DataSource = itemsForPage;

            thisPage_ViewProductsNumber_Label.Text = pageNumber.ToString();
            allPageNumber_ViewProducts_Label.Text = totalPages.ToString();
            searchCommentNumber_Products_Label.Text = totalItems.ToString();
            getPage_ViewProducts_TextBox.Text = pageNumber.ToString();
        }
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
        }
        private void search_ViewProducts_СomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDataToTable(1);
        }
        private void allProductsGetPage_ViewProducts_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string input = getPage_ViewProducts_TextBox.Text.Trim();
                if (input == "")
                {
                    loadDataToTable(1);
                }
                else
                {
                    if (int.TryParse(input, out int pageNumber))
                    {
                        loadDataToTable(pageNumber);
                    }
                    else
                    {
                        loadDataToTable(1);
                    }
                }
            }
        }
        private void previousPage_ViewProducts_Button_Click(object sender, EventArgs e)
        {
            string input = thisPage_ViewProductsNumber_Label.Text.Trim();
            if (input == "")
            {
                loadDataToTable(1);
            }
            else
            {
                if (int.TryParse(input, out int pageNumber))
                {
                    loadDataToTable(pageNumber - 1);
                }
                else
                {
                    loadDataToTable(1);
                }
            }
        }
        private void nextPage_ViewProducts_Button_Click(object sender, EventArgs e)
        {
            string input = thisPage_ViewProductsNumber_Label.Text.Trim();
            if (input == "")
            {
                loadDataToTable(1);
            }
            else
            {
                if (int.TryParse(input, out int pageNumber))
                {
                    loadDataToTable(pageNumber + 1);
                }
                else
                {
                    loadDataToTable(1);
                }
            }
        }
        private void search_Products_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
             loadDataToTable(1);
        }
        private void searchWithName_ViewProducts_TextBox_TextChanged(object sender, EventArgs e)
        {
            loadDataToTable(1);
        }
        /*перегляд товару*/
        private void allProductTable_ViewProducts_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                productInfo_ViewProducts_Panel.Visible = true;
                var row = tableOfProducts_ViewProducts_DataGridView.Rows[e.RowIndex];
                int thisId = Convert.ToInt32(row.Cells["id_AllProduct_TableColumn"].Value);
                Product thisProduct = warehouse.Products.FirstOrDefault(p => p.Id == thisId);
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
                loadHistoryToTable(1, thisId);
                historyGetPage_ViewSpecificProduct_TextBox.Text = "1";
            }
        }
        private void close_ViewSpecificProduct_Button_Click(object sender, EventArgs e)
        {
            productInfo_ViewProducts_Panel.Visible = false;
            string input = thisPage_ViewProductsNumber_Label.Text.Trim();
            if (input == "")
            {
                loadDataToTable(1);
            }
            else
            {
                if (int.TryParse(input, out int pageNumber))
                {
                    loadDataToTable(pageNumber);
                }
                else
                {
                    loadDataToTable(1);
                }
            }
        }
        private void saveAndClose_ViewSpecificProduct_Button_Click(object sender, EventArgs e)
        {
            bool isAllTrue = true;
            Product newInfoProduct = warehouse.Products.FirstOrDefault(p => p.Id == Convert.ToInt32(id_ViewSpecificProduct_Label.Text));
            string name = name_ViewSpecificProduct_TextBox.Text.Trim();
            bool isNameUnique = true;
            newInfoProduct.Note = note_ViewSpecificProduct_TextBox.Text.Trim();
            // Name
            if (name == "")
            {
                isAllTrue = false;
            }
            else
            {
                foreach (Product controlNameObject in warehouse.Products)
                {
                    if (controlNameObject.Name == name && newInfoProduct.Id != controlNameObject.Id)
                    {
                        isAllTrue = false;
                        isNameUnique = false;
                    }
                }
                if (isNameUnique == true && name != "")
                {
                    newInfoProduct.Name = name;
                }
            }
            // Price
            string input = price_ViewSpecificProduct_TextBox.Text.Trim();
            if (input == "")
            {
                isAllTrue = false;
                goto erorr_end;
            }
            if (double.TryParse(input, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double resultPrice))
            {
                if (resultPrice <= 0)
                {
                    isAllTrue = false;
                }
                else
                {
                    newInfoProduct.Price = resultPrice;
                }
            }
            else
            {
                isAllTrue = false;
                goto erorr_end;
            }
            // Height
            input = height_ViewSpecificProduct_TextBox.Text.Trim();
            if (input == "")
            {
                newInfoProduct.Height = 0;
            }
            else
            {
                if (double.TryParse(input, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double resultHeight))
                {
                    if (resultHeight < 0)
                    {
                        isAllTrue = false;
                    }
                    else
                    {
                        newInfoProduct.Height = resultHeight;
                    }
                }
            }
            //Width
            input = width_ViewSpecificProduct_TextBox.Text.Trim();
            if (input == "")
            {
                newInfoProduct.Width = 0;
            }
            else
            {
                if (double.TryParse(input, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double resultWidth))
                {
                    if (resultWidth < 0)
                    {
                        isAllTrue = false;
                    }
                    else
                    {
                        newInfoProduct.Width = resultWidth;
                    }
                }
            }
            // Length
            input = length_ViewSpecificProduct_TextBox.Text.Trim();
            if (input == "")
            {
                newInfoProduct.Length = 0;
            }
            else
            {
                if (double.TryParse(input, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double resultLength))
                {
                    if (resultLength < 0)
                    {
                        isAllTrue = false;
                    }
                    else
                    {
                        newInfoProduct.Length = resultLength;
                    }
                }
            }
            // Weight
            input = weight_ViewSpecificProduct_TextBox.Text.Trim();
            if (input == "")
            {
                newInfoProduct.Weight = 0;
            }
            else
            {
                if (double.TryParse(input, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double resultWeight))
                {
                    if (resultWeight < 0)
                    {
                        isAllTrue = false;
                    }
                    else
                    {
                        newInfoProduct.Weight = resultWeight;
                    }
                }
            }
        erorr_end:
            if (isAllTrue == true)
            {
                for (int i = 0; i < warehouse.Products.Count; i++)
                {
                    if (warehouse.Products[i].Id == newInfoProduct.Id)
                    {
                        warehouse.Products[i] = newInfoProduct;
                        break;
                    }
                }
                productInfo_ViewProducts_Panel.Visible = false;
                string inputPageNumder = thisPage_ViewProductsNumber_Label.Text.Trim();
                if (inputPageNumder == "")
                {
                    loadDataToTable(1);
                }
                else
                {
                    if (int.TryParse(inputPageNumder, out int pageNumber))
                    {
                        loadDataToTable(pageNumber);
                    }
                    else
                    {
                        loadDataToTable(1);
                    }
                }
                warehouse.AddIncident(new Incident(DateTime.Now, "Змінено інформацію про товар: " + newInfoProduct.Name, newInfoProduct.Id), warehouse);
            }
            else
            {
                MessageBox.Show("Помилка при додаванні товару, перевірте правильність введених даних");
            }
        }
        private void copyId_ViewSpecificProduct_Button_Click(object sender, EventArgs e)
        {
            if (id_ViewSpecificProduct_Label.Text != "" || id_ViewSpecificProduct_Label.Text != null)
            {
                Clipboard.SetText(id_ViewSpecificProduct_Label.Text);
            }
        }
        private void delete_ViewSpecificProduct_Button_Click(object sender, EventArgs e)
        {
            warehouse.AddIncident(new Incident(DateTime.Now, "Видалено товар: " + warehouse.Products.FirstOrDefault(p => p.Id == Convert.ToInt32(id_ViewSpecificProduct_Label.Text)), Convert.ToInt32(id_ViewSpecificProduct_Label.Text)), warehouse);
            warehouse.Products.RemoveAll(p => p.Id == Convert.ToInt32(id_ViewSpecificProduct_Label.Text));
            productInfo_ViewProducts_Panel.Visible = false;
            string inputPageNumder = thisPage_ViewProductsNumber_Label.Text.Trim();
            if (inputPageNumder == "")
            {
                loadDataToTable(1);
            }
            else
            {
                if (int.TryParse(inputPageNumder, out int pageNumber))
                {
                    loadDataToTable(pageNumber);
                }
                else
                {
                    loadDataToTable(1);
                }
            }
        }
        /*Перегляд історії товару*/
        private void loadHistoryToTable(int pageNumber, int id)
        {
            int pageSize = 10;
            List<Incident> incidentsForTable = warehouse.History;
            if(id != 0)
            {
                incidentsForTable = incidentsForTable.Where(p => p.ElementId == id).ToList();
            }
            int totalItems = incidentsForTable.Count;
            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);
            if (totalPages == 0) totalPages = 1;
            if (pageNumber > totalPages) pageNumber = totalPages;
            if (pageNumber < 1) pageNumber = 1;
            var itemsForTable = incidentsForTable
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();
            history_ViewSpecificProduct_DataGridView.AutoGenerateColumns = false;
            history_ViewSpecificProduct_DataGridView.DataSource = null;
            history_ViewSpecificProduct_DataGridView.DataSource = itemsForTable;

            historyLastPage_ViewSpecificProduct_Label.Text = totalPages.ToString();
            historyThisPageNumber_ViewSpecificProduct_Label.Text = pageNumber.ToString();
        }
        private void historyPreviousPage_ViewSpecificProduct_Button_Click(object sender, EventArgs e)
        {
            int thisId = Convert.ToInt32(id_ViewSpecificProduct_Label.Text);
            string input = historyThisPageNumber_ViewSpecificProduct_Label.Text.Trim();
            if (input == "")
            {
                loadHistoryToTable(1, thisId);
            }
            else
            {
                if (int.TryParse(input, out int pageNumber))
                {
                    loadHistoryToTable(pageNumber - 1, thisId);
                }
                else
                {
                    loadHistoryToTable(1, thisId);
                }
            }
        }
        private void historyNextPage_ViewSpecificProduct_Button_Click(object sender, EventArgs e)
        {
            int thisId = Convert.ToInt32(id_ViewSpecificProduct_Label.Text);
            string input = historyThisPageNumber_ViewSpecificProduct_Label.Text.Trim();
            if (input == "")
            {
                loadHistoryToTable(1, thisId);
            }
            else
            {
                if (int.TryParse(input, out int pageNumber))
                {
                    loadHistoryToTable(pageNumber + 1, thisId);
                }
                else
                {
                    loadHistoryToTable(1, thisId);
                }
            }
        }
        private void historyGetPage_ViewSpecificProduct_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string input = historyGetPage_ViewSpecificProduct_TextBox.Text.Trim();
                int thisId = Convert.ToInt32(id_ViewSpecificProduct_Label.Text);
                if (input == "")
                {
                    loadHistoryToTable(1, thisId);
                    historyGetPage_ViewSpecificProduct_TextBox.Text = "1";
                }
                else
                {
                    if (int.TryParse(input, out int pageNumber))
                    {
                        if (pageNumber <= 0 || warehouse.History.Count(p => p.ElementId == thisId) < (pageNumber - 1) * 10)
                        {
                            loadHistoryToTable(1, thisId);
                            historyGetPage_ViewSpecificProduct_TextBox.Text = "1";
                        }
                        else
                        {
                            loadHistoryToTable(pageNumber, thisId);
                        }
                    }
                    else
                    {
                        loadHistoryToTable(1, thisId);
                        historyGetPage_ViewSpecificProduct_TextBox.Text = "1";
                    }
                }
            }
        }
        private void deleteHistory_ViewSpecificProduct_Button_Click(object sender, EventArgs e)
        {
            int thisId = Convert.ToInt32(id_ViewSpecificProduct_Label.Text);
            warehouse.History.RemoveAll(p => p.ElementId == thisId);
            var product = warehouse.Products.FirstOrDefault(p => p.Id == thisId);
            string name;
            if (product != null)
            {
                name = product.Name;
            }
            else
            {
                name = "";
            }
            warehouse.AddIncident(new Incident(date: DateTime.Now, "Історію продукта: " + name + ", було видалено", thisId), warehouse);
            loadHistoryToTable(1, thisId);
        }

    }
}
