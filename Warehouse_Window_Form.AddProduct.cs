using System;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Курсовий_проєкт_на_тему_склад
{
    public partial class Warehouse_Window_Form : Form
    {
        private void addProduct_Addproduct_Button_Click(object sender, EventArgs e)/*переробити + додати можливість задати кількість з самого початку*/
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
    }
}