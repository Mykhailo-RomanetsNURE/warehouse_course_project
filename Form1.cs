using System.Data;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Курсовий_проєкт_на_тему_склад
{
    public partial class Form1 : Form
    {
        public Warehouse warehouse;
        public Form1(Warehouse warehouse)
        {
            this.InitializeComponent();
            this.warehouse = warehouse;
            LoadDataToTable(1);
        }
        private System.Windows.Forms.Timer notificationTimer = new System.Windows.Forms.Timer();
        private void Name_AddProduct_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void AddProduct_Addproduct_Button_Click(object sender, EventArgs e)
        {
            bool isAllTrue = true;

            string name = Name_AddProduct_TextBox.Text.Trim();
            double price = 0;
            double height = 0;
            double width = 0;
            double length = 0;
            double weight = 0;
            string note = Note_AddProduct_TextBox.Text.Trim();

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

            string input = Price_AddProduct_TextBox.Text.Trim();
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

            input = Height_AddProduct_TextBox.Text.Trim();
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

            input = Width_AddProduct_TextBox.Text.Trim();
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

            input = Length_AddProduct_TextBox.Text.Trim();
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

            input = Weight_AddProduct_TextBox.Text.Trim();
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
                Notification_AddProduct("Товар успішно додано, йому приділено ID: " + product.Id, 10000);
                Name_AddProduct_TextBox.Clear();
                Price_AddProduct_TextBox.Clear();
                Height_AddProduct_TextBox.Clear();
                Width_AddProduct_TextBox.Clear();
                Length_AddProduct_TextBox.Clear();
                Weight_AddProduct_TextBox.Clear();
                Note_AddProduct_TextBox.Clear();
            }
            else
            {
                Notification_AddProduct("Помилка при додаванні товару, перевірте правильність введених даних", 5000);
            }
        }
        private void Notification_AddProduct(string message, int time)
        {
            notificationTimer.Stop();
            Notification_AddProduct_Label.Text = message;
            notificationTimer.Interval = time;
            notificationTimer.Tick -= Timer_tick;
            notificationTimer.Tick += Timer_tick;
            notificationTimer.Start();
        }
        private void Timer_tick(object sender, EventArgs e)
        {
            Notification_AddProduct_Label.Text = "";
            notificationTimer.Stop();
        }
        private void LoadDataToTable(int PageNumber)
        {
            int pageSize = 10;
            var itemsForPage = warehouse.Products
                .Skip((PageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();
            AllProductTable_ViewProducts_DataGridView.AutoGenerateColumns = false;
            AllProductTable_ViewProducts_DataGridView.DataSource = null;
            AllProductTable_ViewProducts_DataGridView.DataSource = itemsForPage;
            AllProductsThisPage_ViewProducts_Label.Text = $"Поточна сторінка: {PageNumber}";
            AllProductsLastPage_ViewProducts_Label.Text = $"Остання сторінка: {Math.Ceiling((double)warehouse.Products.Count / pageSize)}";
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                AllProductsGetPage_ViewProducts_TextBox.Text = "1";
                LoadDataToTable(1);
            }
        }
        private void AllProductsGetPage_ViewProducts_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string input = AllProductsGetPage_ViewProducts_TextBox.Text.Trim();
                if (input == "")
                {
                    LoadDataToTable(1);
                    AllProductsGetPage_ViewProducts_TextBox.Text = "1";
                }
                else
                {
                    if (int.TryParse(input, out int pageNumber))
                    {
                        if (pageNumber <= 0 || warehouse.Products.Count < (pageNumber - 1) * 10)
                        {
                            LoadDataToTable(1);
                            AllProductsGetPage_ViewProducts_TextBox.Text = "1";
                        }
                        else
                        {
                            LoadDataToTable(pageNumber);
                        }
                    }
                    else
                    {
                        LoadDataToTable(1);
                        AllProductsGetPage_ViewProducts_TextBox.Text = "1";
                    }
                }
            }
        }
        private void AllProductsPreviousPage_ViewProducts_Button_Click(object sender, EventArgs e)
        {
            string input = AllProductsGetPage_ViewProducts_TextBox.Text.Trim();
            if (input == "")
            {
                LoadDataToTable(1);
                AllProductsGetPage_ViewProducts_TextBox.Text = "1";
            }
            else
            {
                if (int.TryParse(input, out int pageNumber))
                {
                    if ((pageNumber - 1) <= 0 || warehouse.Products.Count < (pageNumber - 2) * 10)
                    {
                        LoadDataToTable(1);
                        AllProductsGetPage_ViewProducts_TextBox.Text = "1";
                    }
                    else
                    {
                        LoadDataToTable(pageNumber - 1);
                        AllProductsGetPage_ViewProducts_TextBox.Text = (pageNumber - 1).ToString();
                    }
                }
                else
                {
                    LoadDataToTable(1);
                    AllProductsGetPage_ViewProducts_TextBox.Text = "1";
                }
            }
        }
        private void AllProductsNextPage_ViewProducts_Button_Click(object sender, EventArgs e)
        {
            string input = AllProductsGetPage_ViewProducts_TextBox.Text.Trim();
            if (input == "")
            {
                LoadDataToTable(1);
                AllProductsGetPage_ViewProducts_TextBox.Text = "1";
            }
            else
            {
                if (int.TryParse(input, out int pageNumber))
                {
                    if ((pageNumber + 1) <= 0)
                    {
                        LoadDataToTable(1);
                        AllProductsGetPage_ViewProducts_TextBox.Text = "1";
                    }
                    else
                    {
                        if (warehouse.Products.Count < pageNumber * 10)
                        {
                            LoadDataToTable(warehouse.Products.Count / 10 + 1);
                            AllProductsGetPage_ViewProducts_TextBox.Text = (warehouse.Products.Count / 10 + 1).ToString();
                        }
                        else
                        {
                            LoadDataToTable(pageNumber + 1);
                            AllProductsGetPage_ViewProducts_TextBox.Text = (pageNumber + 1).ToString();
                        }
                    }
                }
                else
                {
                    LoadDataToTable(1);
                    AllProductsGetPage_ViewProducts_TextBox.Text = "1";
                }
            }
        }
        private void AllProductTable_ViewProducts_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                AllProductInfo_ViewProducts_Panel.Visible = true;
                var row = AllProductTable_ViewProducts_DataGridView.Rows[e.RowIndex];
                int thisId = Convert.ToInt32(row.Cells["Id"].Value);
                Product thisProduct = warehouse.Products.FirstOrDefault(p => p.Id == thisId);
                Name_ViewSpecificProduct_TextBox.Clear();
                Price_ViewSpecificProduct_TextBox.Clear();
                Height_ViewSpecificProduct_TextBox.Clear();
                Width_ViewSpecificProduct_TextBox.Clear();
                Length_ViewSpecificProduct_TextBox.Clear();
                Weight_ViewSpecificProduct_TextBox.Clear();
                Note_ViewSpecificProduct_TextBox.Clear();
                Name_ViewSpecificProduct_TextBox.Text = thisProduct.Name;
                Id_ViewSpecificProduct_Label.Text = Convert.ToString(thisProduct.Id);
                Price_ViewSpecificProduct_TextBox.Text = Convert.ToString(thisProduct.Price);
                Height_ViewSpecificProduct_TextBox.Text = Convert.ToString(thisProduct.Height);
                Width_ViewSpecificProduct_TextBox.Text = Convert.ToString(thisProduct.Width);
                Length_ViewSpecificProduct_TextBox.Text = Convert.ToString(thisProduct.Length);
                Weight_ViewSpecificProduct_TextBox.Text = Convert.ToString(thisProduct.Weight);
                Note_ViewSpecificProduct_TextBox.Text = thisProduct.Note;
                Quantity_ViewSpecificProduct_Lable.Text = Convert.ToString(thisProduct.Quantity);
                Time_ViewSpecificProduct_Label.Text = Convert.ToString(thisProduct.DateAndTime);
            }
        }
        private void Close_ViewSpecificProduct_Button_Click(object sender, EventArgs e)
        {
            AllProductInfo_ViewProducts_Panel.Visible = false;
            string input = AllProductsGetPage_ViewProducts_TextBox.Text.Trim();
            if (input == "")
            {
                LoadDataToTable(1);
                AllProductsGetPage_ViewProducts_TextBox.Text = "1";
            }
            else
            {
                if (int.TryParse(input, out int pageNumber))
                {
                    if (pageNumber <= 0 || warehouse.Products.Count < (pageNumber - 1) * 10)
                    {
                        LoadDataToTable(1);
                        AllProductsGetPage_ViewProducts_TextBox.Text = "1";
                    }
                    else
                    {
                        LoadDataToTable(pageNumber);
                    }
                }
                else
                {
                    LoadDataToTable(1);
                    AllProductsGetPage_ViewProducts_TextBox.Text = "1";
                }
            }
        }
        private void SaveAndClose_ViewSpecificProduct_Button_Click(object sender, EventArgs e)
        {
            bool isAllTrue = true;
            Product newInfoProduct = warehouse.Products.FirstOrDefault(p => p.Id == Convert.ToInt32(Id_ViewSpecificProduct_Label.Text));
            string name = Name_ViewSpecificProduct_TextBox.Text.Trim();
            bool isNameUnique = true;
            newInfoProduct.Note = Note_ViewSpecificProduct_TextBox.Text.Trim();
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
            string input = Price_ViewSpecificProduct_TextBox.Text.Trim();
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
            input = Height_ViewSpecificProduct_TextBox.Text.Trim();
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
            input = Width_ViewSpecificProduct_TextBox.Text.Trim();
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
            input = Length_ViewSpecificProduct_TextBox.Text.Trim();
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
            input = Weight_ViewSpecificProduct_TextBox.Text.Trim();
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
                AllProductInfo_ViewProducts_Panel.Visible = false;
                string inputPageNumder = AllProductsGetPage_ViewProducts_TextBox.Text.Trim();
                if (inputPageNumder == "")
                {
                    LoadDataToTable(1);
                    AllProductsGetPage_ViewProducts_TextBox.Text = "1";
                }
                else
                {
                    if (int.TryParse(inputPageNumder, out int pageNumber))
                    {
                        if (pageNumber <= 0 || warehouse.Products.Count < (pageNumber - 1) * 10)
                        {
                            LoadDataToTable(1);
                            AllProductsGetPage_ViewProducts_TextBox.Text = "1";
                        }
                        else
                        {
                            LoadDataToTable(pageNumber);
                        }
                    }
                    else
                    {
                        LoadDataToTable(1);
                        AllProductsGetPage_ViewProducts_TextBox.Text = "1";
                    }
                }
                warehouse.AddIncident(new Incident(DateTime.Now, "Змінено інформацію про товар: " + newInfoProduct.Name, newInfoProduct.Id), warehouse);
            }
            else
            {
                MessageBox.Show("Помилка при додаванні товару, перевірте правильність введених даних");
            }
        }
    
    }
}
