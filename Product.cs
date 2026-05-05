using System;
using System.Xml.Linq;
using Курсовий_проєкт_на_тему_склад;

public class Product
{
	public int Id { get; set; }/*ідентифікатор*/
    public string Name { get; set; }/*Назва*/
	public int Quantity { get; set; }/*кількість*/
	public double Price { get; set; }/*ціна*/
	public DateTime DateAndTime { get; set; }/*дата і час останнього завезення товару*/
	public double Height { get; set; }/*висота*/
	public double Width { get; set; }/*ширина*/
	public double Length { get; set; }/*довжина*/
	public double Weight { get; set; }/*вага*/
	public string Note { get; set; }/*примітка*/
	
	public Product(string name,int quantity, double price, double height, double width, double length, double weight, string note, Warehouse warehouseForConstructor)
	{
		this.Id = warehouseForConstructor.MaxId;
		warehouseForConstructor.MaxId ++;	
        this.Name = name;
		this.Quantity = quantity;
		this.Price = price;
		this.DateAndTime = DateTime.Now;
		this.Height = height;
		this.Width = width;
		this.Length = length;
		this.Weight = weight;
		this.Note = note;
		warehouseForConstructor.AddIncident(new Incident(DateTime.Now, "Додано новий товар: " + name, this.Id), warehouseForConstructor);
    }
    public Product(Product product, Warehouse warehouseForConstructor)
    {
        this.Id = warehouseForConstructor.MaxId;
        warehouseForConstructor.MaxId++;
        this.Name = product.Name;
        this.Quantity = product.Quantity;
        this.Price = product.Price;
        this.DateAndTime = DateTime.Now;
        this.DateAndTime = product.DateAndTime;
        this.Height = product.Height;
        this.Width = product.Width;
        this.Length = product.Length;
        this.Weight = product.Weight;
        this.Note = product.Note;
        warehouseForConstructor.AddIncident(new Incident(DateTime.Now, "Додано новий товар: " + product.Name, this.Id), warehouseForConstructor);
    }
    public Product(int id, string name, int quantity, double price, DateTime dateAndTime, double height, double width, double length, double weight, string note)
    {
        this.Id = id;
        this.Name = name;
        this.Quantity = quantity;
        this.Price = price;
        this.DateAndTime = dateAndTime;
        this.Height = height;
        this.Width = width;
        this.Length = length;
        this.Weight = weight;
        this.Note = note;
    }
    public static (Product product, bool[] isAllTrue) CreateProduct(string name, string price, string quantity, string height, string width, string length, string weight, string note, Warehouse warehouse)
    {
        bool[] isAllTrue = new bool[8];
        Array.Fill(isAllTrue, true);
        Product emptyProduct = new Product(0, "", 0, 0, DateTime.Now, 0, 0, 0, 0, "");

        if (name == "")
        {
            isAllTrue[0] = false;
        }
        else
        {
            foreach (Product controlNameObject in warehouse.Products)
            {
                if (controlNameObject.Name == name)
                {
                    isAllTrue[0] = false;
                    break;
                }
                else
                {
                    isAllTrue[0] = true;
                }
            }
            if (isAllTrue[0] == true)
            {
                emptyProduct.Name = name;
            }
        }
        if (double.TryParse(price, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double inputPrice))
        {
            if (inputPrice <= 0)
            {
                isAllTrue[1] = false;
            }
            else
            {
                isAllTrue[1] = true;
                emptyProduct.Price = inputPrice;
            }
        }
        else
        {
            isAllTrue[1] = false;
        }
        if (int.TryParse(quantity, out int inputQuantity))
        {
            if (inputQuantity < 0)
            {
                isAllTrue[2] = false;
            }
            else
            {
                isAllTrue[2] = true;
                emptyProduct.Quantity = inputQuantity;
            }
        }
        if (height != "")
        {
            if (double.TryParse(height, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double inputHeight))
            {
                if (inputHeight < 0)
                {
                    isAllTrue[3] = false;
                }
                else
                {
                    isAllTrue[3] = true;
                    emptyProduct.Height = inputHeight;
                }
            }
        }
        if (length != "")
        {
            if (double.TryParse(length, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double inputLength))
            {
                if (inputLength < 0)
                {
                    isAllTrue[6] = false;
                }
                else
                {
                    isAllTrue[6] = true;
                    emptyProduct.Length = inputLength;
                }
            }
        }
        if (width != "")
        {
            if (double.TryParse(width, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double inputWidth))
            {
                if (inputWidth < 0)
                {
                    isAllTrue[4] = false;
                }
                else
                {
                    isAllTrue[4] = true;
                    emptyProduct.Width = inputWidth;
                }
            }
        }
        if (weight != "")
        {
            if (double.TryParse(weight, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double inputWeight))
            {
                if (inputWeight < 0)
                {
                    isAllTrue[7] = false;
                }
                else
                {
                    isAllTrue[7] = true;
                    emptyProduct.Weight = inputWeight;
                }
            }
        }
        emptyProduct.Note = note;
        return (emptyProduct, isAllTrue);
    }
	public static bool[] AddNewProduct (string name, string price, string quantity, string height, string width, string length, string weight, string note, Warehouse warehouse)
	{
        var result = Product.CreateProduct(name, price, quantity, height, width, length, weight, note, warehouse);
        bool[] isAllTrue = result.isAllTrue;
        Product emptyProduct = result.product;
        if (isAllTrue.All(x => x == true))
        {
            warehouse.AddProduct(emptyProduct);
        }
        return isAllTrue;
    }

}
