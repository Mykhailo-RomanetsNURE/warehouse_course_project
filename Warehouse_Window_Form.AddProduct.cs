using System;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Курсовий_проєкт_на_тему_склад
{
    public partial class Warehouse_Window_Form : Form
    {
        private void addProduct_Addproduct_Button_Click(object sender, EventArgs e)
        {
            string inputName = name_AddProduct_TextBox.Text.Trim();
            string inputNote = note_AddProduct_TextBox.Text.Trim();
            string inputPrice = price_AddProduct_TextBox.Text.Trim();
            string inputQuantity = quantity_AddProduct_TextBox.Text.Trim();
            string inputHeight = height_AddProduct_TextBox.Text.Trim();
            string inputWidth = width_AddProduct_TextBox.Text.Trim();
            string inputLength = length_AddProduct_TextBox.Text.Trim();
            string inputWeight = weight_AddProduct_TextBox.Text.Trim();
            bool[] isAllTrue = Product.AddNewProduct(inputName, inputPrice, inputQuantity, inputHeight, inputWidth, inputLength, inputWeight, inputNote, warehouse);

            if (isAllTrue.All(x => x == true))
            {
                notification_AddProduct("Товар успішно додано, йому приділено ID: " + (warehouse.MaxId - 1), 5000);
                name_AddProduct_TextBox.Clear();
                price_AddProduct_TextBox.Clear();
                quantity_AddProduct_TextBox.Clear();
                height_AddProduct_TextBox.Clear();
                width_AddProduct_TextBox.Clear();
                length_AddProduct_TextBox.Clear();
                weight_AddProduct_TextBox.Clear();
                note_AddProduct_TextBox.Clear();
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
                if (isAllTrue[2] == false)
                {
                    errorMessage += "Кількість повинна бути невід'ємним та цілим числом.\n";
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