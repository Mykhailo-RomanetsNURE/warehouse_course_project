namespace Курсовий_проєкт_на_тему_склад
{
    public partial class Warehouse_Window_Form : Form
    {
        public void LoadItemsToInvoiceTable()
        {
            warehouse.InvoiceList.RemoveAll(x => x == null);
            idOfInvoice_Invoice_Label.Text = warehouse.InvoiceLastId.ToString();
            newInvoice_Invoice_DataGridView.AutoGenerateColumns = false;
            newInvoice_Invoice_DataGridView.DataSource = null;
            newInvoice_Invoice_DataGridView.DataSource = warehouse.InvoiceList;
            newInvoice_Invoice_DataGridView.Enabled = false;
            if (warehouse.InvoiceList == null || warehouse.InvoiceList.Count == 0)
            {
                typeOfInvoice_Invoice_ComboBox.Enabled = true;
            }
            else
            {
                typeOfInvoice_Invoice_ComboBox.Enabled = false;
            }
        }
        public void VisibleInvoiceItemControls(bool visible)
        {
            productName_Invoice_LabelText.Visible = visible;
            productName_Invoice_Label.Visible = visible;
            quantityProduct_Invoice_Label.Visible = visible;
            quantityProduct_Invoice_TextBox.Visible = visible;
            thisQuantityProduct_Invoice_Label.Visible = visible;
            thisQuantityProduct_Invoice_LabelNumber.Visible = visible;
            productPrice_Invoice_Label.Visible = visible;
            productPrice_Invoice_TextBox.Visible = visible;
            thisProductPrice_Invoice_Label.Visible = visible;
            thisProductPrice_Invoice_LabelNumber.Visible = visible;
            noProduct_Invoice_Button.Visible = visible;
            okProduct_Invoice_Button.Visible = visible;
        }
        public void LoadItemData(Product? product)
        {
            if (product != null)
            {
                productName_Invoice_Label.Text = product.Name;
                thisQuantityProduct_Invoice_LabelNumber.Text = product.Quantity.ToString();
                productPrice_Invoice_TextBox.Text = product.Price.ToString();
                thisProductPrice_Invoice_LabelNumber.Text = product.Price.ToString();
            }
            else
            {
                productName_Invoice_Label.Text = "";
                quantityProduct_Invoice_TextBox.Clear();
                thisQuantityProduct_Invoice_LabelNumber.Text = "";
                productPrice_Invoice_TextBox.Clear();
                thisProductPrice_Invoice_LabelNumber.Text = "";
            }
        }
        public void LoadProductDataInvoniceItem()
        {
            string input = productId_Invoice_TextBox.Text.Trim();
            if (int.TryParse(input, out int productId))
            {
                var product = warehouse.Products.FirstOrDefault(p => p.Id == productId);
                if (product != null)
                {
                    var item = warehouse.InvoiceList.FirstOrDefault(i => i.Id == productId);
                    if (item != null)
                    {
                        LoadItemData(product);
                        VisibleInvoiceItemControls(true);
                        panelName_Invoice_Label.Text = "Редагування товару в накладній";
                        quantityProduct_Invoice_TextBox.Text = item.Quantity.ToString();
                        noProduct_Invoice_Button.Text = "Видалити";
                        okProduct_Invoice_Button.Text = "Змінити";
                        return;
                    }
                    LoadItemData(product);
                    VisibleInvoiceItemControls(true);
                    panelName_Invoice_Label.Text = "Додавання товару в накладну";
                    noProduct_Invoice_Button.Text = "Очистити";
                    okProduct_Invoice_Button.Text = "Додати товар до накладної";
                    return;
                }
            }
            LoadItemData(null);
            VisibleInvoiceItemControls(false);
            panelName_Invoice_Label.Text = "Додавання товару в накладну";
        }
        public void AddNewInvoice()
        {
            bool IsExpenditureInvoice = typeOfInvoice_Invoice_ComboBox.SelectedIndex == 0;
            if (productInfo_ViewProducts_Panel.Visible == true)
            {
                if (int.TryParse(id_ViewSpecificProduct_Label.Text.Trim(), out int id))
                {
                    int index = warehouse.InvoiceList.FindIndex(i => i.Id == id);
                    if (index != -1)
                    {
                        productInfo_ViewProducts_Panel.Visible = false;
                    }
                }
            }
            warehouse.AddInvoice(warehouse, IsExpenditureInvoice);
            LoadItemsToInvoiceTable();
        }
        private void ProductId_Invoice_TextBox_TextChanged(object sender, EventArgs e)
        {
            LoadProductDataInvoniceItem();
        }
        private void NoProduct_Invoice_Button_Click(object sender, EventArgs e)
        {
            if (productId_Invoice_TextBox.Text == "Очистити")
            {
                productId_Invoice_TextBox.Clear();
                LoadProductDataInvoniceItem();
            }
            else
            {
                string inputId = productId_Invoice_TextBox.Text.Trim();
                if (int.TryParse(inputId, out int id))
                {
                    warehouse.DeleteItemInNewInvoice(id);
                    LoadItemsToInvoiceTable();
                    productId_Invoice_TextBox.Clear();
                    LoadProductDataInvoniceItem();
                }
            }
        }
        private void CleanInvoice_Invoice_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете очистити нову накладну?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                warehouse.ClearNewInvoice();
                LoadItemsToInvoiceTable();
                LoadProductDataInvoniceItem();
            }
        }
        private void OkProduct_Invoice_Button_Click(object sender, EventArgs e)
        {
            string inputId = productId_Invoice_TextBox.Text.Trim();
            string inputQuantity = quantityProduct_Invoice_TextBox.Text.Trim();
            string inputPrice = productPrice_Invoice_TextBox.Text.Trim();
            string inputOldQuantity = thisQuantityProduct_Invoice_LabelNumber.Text.Trim();
            int comboBoxIndex = typeOfInvoice_Invoice_ComboBox.SelectedIndex;

            if (warehouse.DovloadDataToInvoice(inputId, inputQuantity, inputPrice, inputOldQuantity, comboBoxIndex))
            {
                LoadItemsToInvoiceTable();
                productId_Invoice_TextBox.Clear();
                LoadProductDataInvoniceItem();
            }
            else
            {
                if (comboBoxIndex == 0)
                {
                    MessageBox.Show("Нажаль введені данні містять помилку, перевірте правильність введених даних, кількість повинна бути цілою та не від'ємною, ціна повинна бути більше 0.");
                }
                else
                {
                    MessageBox.Show("Нажаль введені данні містять помилку, перевірте правильність введених даних, кількість повинна бути цілою, не від'ємною та не має перевищувати наявну кільксть на складі, ціна повинна бути більше 0.");
                }
            }
        }
        private void AddNewInvoice_Button_Click(object sender, EventArgs e)
        {
            if (!warehouse.IsNewInvoiceEmpty())
            {
                AddNewInvoice();
            }
            else
            {
                MessageBox.Show("Неможливо створити накладну без товарів.");
            }
        }
        private void AddNewInvoice_Invoice_Button_Click(object sender, EventArgs e)
        {
            if (!warehouse.IsNewInvoiceEmpty())
            {
                AddNewInvoice();
                warehouse.InvoicesHistory[0].ExportInvoiceToFile();
            }
            else
            {
                MessageBox.Show("Неможливо створити накладну без товарів.");
            }
        }

    }
}
