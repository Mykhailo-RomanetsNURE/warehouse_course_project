using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            idOfInvoice_Invoice_Label.Text = warehouse.InvoiceLastId.ToString();
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
        public void LoadProductDataInvoniceItem()/*є код що бажано винести в окремий метод*/
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
                        panelName_Invoice_Label.Text = "Редагування товару в накладній";

                        productName_Invoice_LabelText.Visible = true;
                        productName_Invoice_Label.Visible = true;
                        productName_Invoice_Label.Text = product.Name;

                        quantityProduct_Invoice_Label.Visible = true;
                        quantityProduct_Invoice_TextBox.Visible = true;
                        quantityProduct_Invoice_TextBox.Text = item.Quantity.ToString();
                        thisQuantityProduct_Invoice_Label.Visible = true;
                        thisQuantityProduct_Invoice_LabelNumber.Visible = true;
                        thisQuantityProduct_Invoice_LabelNumber.Text = product.Quantity.ToString();

                        productPrice_Invoice_Label.Visible = true;
                        productPrice_Invoice_TextBox.Visible = true;
                        productPrice_Invoice_TextBox.Text = item.Price.ToString();
                        thisProductPrice_Invoice_Label.Visible = true;
                        thisProductPrice_Invoice_LabelNumber.Visible = true;
                        thisProductPrice_Invoice_LabelNumber.Text = product.Price.ToString();

                        noProduct_Invoice_Button.Visible = true;
                        noProduct_Invoice_Button.Text = "Видалити";
                        okProduct_Invoice_Button.Visible = true;
                        okProduct_Invoice_Button.Text = "Змінити";
                        return;
                    }
                    panelName_Invoice_Label.Text = "Додавання товару в накладну";

                    productName_Invoice_LabelText.Visible = true;
                    productName_Invoice_Label.Visible = true;
                    productName_Invoice_Label.Text = product.Name;

                    quantityProduct_Invoice_Label.Visible = true;
                    quantityProduct_Invoice_TextBox.Visible = true;
                    thisQuantityProduct_Invoice_Label.Visible = true;
                    thisQuantityProduct_Invoice_LabelNumber.Visible = true;
                    thisQuantityProduct_Invoice_LabelNumber.Text = product.Quantity.ToString();

                    productPrice_Invoice_Label.Visible = true;
                    productPrice_Invoice_TextBox.Visible = true;
                    productPrice_Invoice_TextBox.Text = product.Price.ToString();
                    thisProductPrice_Invoice_Label.Visible = true;
                    thisProductPrice_Invoice_LabelNumber.Visible = true;
                    thisProductPrice_Invoice_LabelNumber.Text = product.Price.ToString();

                    noProduct_Invoice_Button.Visible = true;
                    noProduct_Invoice_Button.Text = "Очистити";
                    okProduct_Invoice_Button.Visible = true;
                    okProduct_Invoice_Button.Text = "Додати товар до накладної";
                    return;
                }
            }
            panelName_Invoice_Label.Text = "Додавання товару в накладну";

            productName_Invoice_LabelText.Visible = false;
            productName_Invoice_Label.Visible = false;
            productName_Invoice_Label.Text = "";

            quantityProduct_Invoice_Label.Visible = false;
            quantityProduct_Invoice_TextBox.Visible = false;
            quantityProduct_Invoice_TextBox.Clear();
            thisQuantityProduct_Invoice_Label.Visible = false;
            thisQuantityProduct_Invoice_LabelNumber.Visible = false;
            thisQuantityProduct_Invoice_LabelNumber.Text = "";

            productPrice_Invoice_Label.Visible = false;
            productPrice_Invoice_TextBox.Visible = false;
            productPrice_Invoice_TextBox.Clear();
            thisProductPrice_Invoice_Label.Visible = false;
            thisProductPrice_Invoice_LabelNumber.Visible = false;
            thisProductPrice_Invoice_LabelNumber.Text = "";

            noProduct_Invoice_Button.Visible = false;
            okProduct_Invoice_Button.Visible = false;
        }
        public void AddNewInvoice()
        {
            bool IsExpenditureInvoice = typeOfInvoice_Invoice_ComboBox.SelectedIndex == 0;
            Invoice invoice = new Invoice(warehouse, IsExpenditureInvoice, warehouse.InvoiceList);
            warehouse.AddInvoice(invoice, warehouse);
            warehouse.InvoiceList.Clear();
            warehouse.InvoiceLastId++;
            LoadItemsToInvoiceTable();
        }
        private void productId_Invoice_TextBox_TextChanged(object sender, EventArgs e)
        {
            LoadProductDataInvoniceItem();
        }
        private void noProduct_Invoice_Button_Click(object sender, EventArgs e)
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
                    warehouse.InvoiceList.RemoveAll(i => i.Id == id);
                    LoadItemsToInvoiceTable();
                    productId_Invoice_TextBox.Clear();
                    LoadProductDataInvoniceItem();
                }
            }
        }
        private void cleanInvoice_Invoice_Button_Click(object sender, EventArgs e)
        {
            warehouse.InvoiceList = new List<ItemOfInvoice>();
            LoadItemsToInvoiceTable();
            LoadProductDataInvoniceItem();
        }
        private void okProduct_Invoice_Button_Click(object sender, EventArgs e)
        {
            string inputId = productId_Invoice_TextBox.Text.Trim();
            string inputQuantity = quantityProduct_Invoice_TextBox.Text.Trim();
            string inputPrice = productPrice_Invoice_TextBox.Text.Trim();

            if (int.TryParse(inputId, out int id) && int.TryParse(inputQuantity, out int quantity) && double.TryParse(inputPrice, out double price))
            {
                if (id > 0 && quantity > 0 && price > 0 && (typeOfInvoice_Invoice_ComboBox.SelectedIndex == 0 || (typeOfInvoice_Invoice_ComboBox.SelectedIndex == 1 && Convert.ToInt32(thisQuantityProduct_Invoice_LabelNumber.Text) >= quantity)))
                {
                    var existingItem = warehouse.InvoiceList.FirstOrDefault(i => i.Id == id);
                    if (existingItem == null)
                    {
                        ItemOfInvoice item = new ItemOfInvoice(id, quantity, (double)price, warehouse);
                        warehouse.InvoiceList.Add(item);
                    }
                    else
                    {
                        existingItem.Quantity = quantity;
                        existingItem.Price = price;
                        for (int i = 0; i < warehouse.InvoiceList.Count; i++)
                        {
                            if (warehouse.InvoiceList[i].Id == id)
                            {
                                warehouse.InvoiceList[i] = existingItem;
                                break;
                            }
                        }
                    }
                    LoadItemsToInvoiceTable();
                    productId_Invoice_TextBox.Clear();
                    LoadProductDataInvoniceItem();
                    return;
                }
            }

            MessageBox.Show("Нажаль введені данні мають помилку.");
        }
        private void addNewInvoice_Button_Click(object sender, EventArgs e)
        {
            if (warehouse.InvoiceList != null && warehouse.InvoiceList.Count() != 0)
            {
                AddNewInvoice();
            }
            else
            {
                MessageBox.Show("Неможливо створити накладну без товарів.");
            }
        }
        private void addNewInvoice_Invoice_Button_Click(object sender, EventArgs e)
        {
            if (warehouse.InvoiceList != null && warehouse.InvoiceList.Count() != 0)
            {
                AddNewInvoice();
                ExportInvoiceToFile(warehouse.InvoicesHistory[0]);
            }
            else
            {
                MessageBox.Show("Неможливо створити накладну без товарів.");
            }
        }

    }
}
