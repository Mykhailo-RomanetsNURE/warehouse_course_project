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
            this.warehouse = warehouse;
            loadDataToTable(1);
        }
        private System.Windows.Forms.Timer notificationTimer = new System.Windows.Forms.Timer();
        private void addProduct_Addproduct_Button_Click(object sender, EventArgs e)
        {
            bool isAllTrue = true;

            string name = name_AddProduct_TextBox.Text.Trim();
            double price = 0;
            double height = 0;
            double width = 0;
            double length = 0;
            double weight = 0;
            string note = note_AddProduct_TextBox.Text.Trim();

            if (name == "")
            {
                isAllTrue = false;
                goto erorr_end;
            }
            foreach (Product controlNameObject in warehouse.Products)
            {
                if (controlNameObject.Name == name)
                {
                    isAllTrue = false;
                    goto erorr_end;
                }
            }

            string input = price_AddProduct_TextBox.Text.Trim();
            if (input == "")
            {
                isAllTrue = false;
                goto erorr_end;
            }
            if (double.TryParse(input, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double result))
            {
                if (result <= 0)
                {
                    isAllTrue = false;
                    goto erorr_end;
                }
                price = result;
            }
            else
            {
                isAllTrue = false;
                goto erorr_end;
            }

            input = height_AddProduct_TextBox.Text.Trim();
            if (input != "")
            {
                if (double.TryParse(input, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out result))
                {
                    if (result < 0)
                    {
                        isAllTrue = false;
                        goto erorr_end;
                    }
                    height = result;
                }
            }

            input = width_AddProduct_TextBox.Text.Trim();
            if (input != "")
            {
                if (double.TryParse(input, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out result))
                {
                    if (result < 0)
                    {
                        isAllTrue = false;
                        goto erorr_end;
                    }
                    width = result;
                }
            }

            input = length_AddProduct_TextBox.Text.Trim();
            if (input != "")
            {
                if (double.TryParse(input, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out result))
                {
                    if (result < 0)
                    {
                        isAllTrue = false;
                        goto erorr_end;
                    }
                    length = result;
                }
            }

            input = weight_AddProduct_TextBox.Text.Trim();
            if (input != "")
            {
                if (double.TryParse(input, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out result))
                {
                    if (result < 0)
                    {
                        isAllTrue = false;
                        goto erorr_end;
                    }
                    weight = result;
                }
            }

        erorr_end:
            if (isAllTrue == true)
            {
                Product product = new Product(name, price, height, width, length, weight, note, warehouse);
                warehouse.Products.Add(product);
                notification_AddProduct("Товар успішно додано, йому приділено ID: " + product.Id, 5000);
                name_AddProduct_TextBox.Clear();
                price_AddProduct_TextBox.Clear();
                height_AddProduct_TextBox.Clear();
                width_AddProduct_TextBox.Clear();
                length_AddProduct_TextBox.Clear();
                weight_AddProduct_TextBox.Clear();
                note_AddProduct_TextBox.Clear();
            }
            else
            {
                notification_AddProduct("Помилка при додаванні товару, перевірте правильність введених даних", 3000);
            }
        }
        private void notification_AddProduct(string message, int time)
        {
            notificationTimer.Stop();
            notification_AddProduct_Label.Text = message;
            notificationTimer.Interval = time;
            notificationTimer.Tick -= timerTick;
            notificationTimer.Tick += timerTick;
            notificationTimer.Start();
        }
        private void timerTick(object sender, EventArgs e)
        {
            notification_AddProduct_Label.Text = "";
            notificationTimer.Stop();
        }
        private void loadDataToTable(int PageNumber)
        {
            int pageSize = 10;
            var itemsForPage = warehouse.Products
                .Skip((PageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();
            allProductTable_ViewProducts_DataGridView.AutoGenerateColumns = false;
            allProductTable_ViewProducts_DataGridView.DataSource = null;
            allProductTable_ViewProducts_DataGridView.DataSource = itemsForPage;
            allProductsThisPage_ViewProducts_Label.Text = $"Поточна сторінка: {PageNumber}";
            allProductsLastPage_ViewProducts_Label.Text = $"Остання сторінка: {Math.Ceiling((double)warehouse.Products.Count / pageSize)}";
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (program_TabControl.SelectedIndex == 0)
            {
                allProductsGetPage_ViewProducts_TextBox.Text = "1";
                loadDataToTable(1);
            }
        }
        private void allProductsGetPage_ViewProducts_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string input = allProductsGetPage_ViewProducts_TextBox.Text.Trim();
                if (input == "")
                {
                    loadDataToTable(1);
                    allProductsGetPage_ViewProducts_TextBox.Text = "1";
                }
                else
                {
                    if (int.TryParse(input, out int pageNumber))
                    {
                        if (pageNumber <= 0 || warehouse.Products.Count < (pageNumber - 1) * 10)
                        {
                            loadDataToTable(1);
                            allProductsGetPage_ViewProducts_TextBox.Text = "1";
                        }
                        else
                        {
                            loadDataToTable(pageNumber);
                        }
                    }
                    else
                    {
                        loadDataToTable(1);
                        allProductsGetPage_ViewProducts_TextBox.Text = "1";
                    }
                }
            }
        }
        private void allProductsPreviousPage_ViewProducts_Button_Click(object sender, EventArgs e)
        {
            string input = allProductsGetPage_ViewProducts_TextBox.Text.Trim();
            if (input == "")
            {
                loadDataToTable(1);
                allProductsGetPage_ViewProducts_TextBox.Text = "1";
            }
            else
            {
                if (int.TryParse(input, out int pageNumber))
                {
                    if ((pageNumber - 1) <= 0 || warehouse.Products.Count < (pageNumber - 2) * 10)
                    {
                        loadDataToTable(1);
                        allProductsGetPage_ViewProducts_TextBox.Text = "1";
                    }
                    else
                    {
                        loadDataToTable(pageNumber - 1);
                        allProductsGetPage_ViewProducts_TextBox.Text = (pageNumber - 1).ToString();
                    }
                }
                else
                {
                    loadDataToTable(1);
                    allProductsGetPage_ViewProducts_TextBox.Text = "1";
                }
            }
        }
        private void allProductsNextPage_ViewProducts_Button_Click(object sender, EventArgs e)
        {
            string input = allProductsGetPage_ViewProducts_TextBox.Text.Trim();
            if (input == "")
            {
                loadDataToTable(1);
                allProductsGetPage_ViewProducts_TextBox.Text = "1";
            }
            else
            {
                if (int.TryParse(input, out int pageNumber))
                {
                    if ((pageNumber + 1) <= 0)
                    {
                        loadDataToTable(1);
                        allProductsGetPage_ViewProducts_TextBox.Text = "1";
                    }
                    else
                    {
                        if (warehouse.Products.Count < pageNumber * 10)
                        {
                            loadDataToTable(warehouse.Products.Count / 10 + 1);
                            allProductsGetPage_ViewProducts_TextBox.Text = (warehouse.Products.Count / 10 + 1).ToString();
                        }
                        else
                        {
                            loadDataToTable(pageNumber + 1);
                            allProductsGetPage_ViewProducts_TextBox.Text = (pageNumber + 1).ToString();
                        }
                    }
                }
                else
                {
                    loadDataToTable(1);
                    allProductsGetPage_ViewProducts_TextBox.Text = "1";
                }
            }
        }
        private void allProductTable_ViewProducts_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                allProductInfo_ViewProducts_Panel.Visible = true;
                var row = allProductTable_ViewProducts_DataGridView.Rows[e.RowIndex];
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
            }
        }
        private void close_ViewSpecificProduct_Button_Click(object sender, EventArgs e)
        {
            allProductInfo_ViewProducts_Panel.Visible = false;
            string input = allProductsGetPage_ViewProducts_TextBox.Text.Trim();
            if (input == "")
            {
                loadDataToTable(1);
                allProductsGetPage_ViewProducts_TextBox.Text = "1";
            }
            else
            {
                if (int.TryParse(input, out int pageNumber))
                {
                    if (pageNumber <= 0 || warehouse.Products.Count < (pageNumber - 1) * 10)
                    {
                        loadDataToTable(1);
                        allProductsGetPage_ViewProducts_TextBox.Text = "1";
                    }
                    else
                    {
                        loadDataToTable(pageNumber);
                    }
                }
                else
                {
                    loadDataToTable(1);
                    allProductsGetPage_ViewProducts_TextBox.Text = "1";
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
                allProductInfo_ViewProducts_Panel.Visible = false;
                string inputPageNumder = allProductsGetPage_ViewProducts_TextBox.Text.Trim();
                if (inputPageNumder == "")
                {
                    loadDataToTable(1);
                    allProductsGetPage_ViewProducts_TextBox.Text = "1";
                }
                else
                {
                    if (int.TryParse(inputPageNumder, out int pageNumber))
                    {
                        if (pageNumber <= 0 || warehouse.Products.Count < (pageNumber - 1) * 10)
                        {
                            loadDataToTable(1);
                            allProductsGetPage_ViewProducts_TextBox.Text = "1";
                        }
                        else
                        {
                            loadDataToTable(pageNumber);
                        }
                    }
                    else
                    {
                        loadDataToTable(1);
                        allProductsGetPage_ViewProducts_TextBox.Text = "1";
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
            allProductInfo_ViewProducts_Panel.Visible = false;
            string inputPageNumder = allProductsGetPage_ViewProducts_TextBox.Text.Trim();
            if (inputPageNumder == "")
            {
                loadDataToTable(1);
                allProductsGetPage_ViewProducts_TextBox.Text = "1";
            }
            else
            {
                if (int.TryParse(inputPageNumder, out int pageNumber))
                {
                    if (pageNumber <= 0 || warehouse.Products.Count < (pageNumber - 1) * 10)
                    {
                        loadDataToTable(1);
                        allProductsGetPage_ViewProducts_TextBox.Text = "1";
                    }
                    else
                    {
                        loadDataToTable(pageNumber);
                    }
                }
                else
                {
                    loadDataToTable(1);
                    allProductsGetPage_ViewProducts_TextBox.Text = "1";
                }
            }
        }
    }
}
