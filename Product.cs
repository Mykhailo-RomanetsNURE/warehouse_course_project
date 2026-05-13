using Курсовий_проєкт_на_тему_склад;

public class Product
{
    /*клас для товару що міститься на складі*/
	public int Id { get; set; }/*Id товару, для зручнішого встановлення звязку з товаром у списку, та користуванням данними товару користувачем*/
    public string Name { get; set; }/*Назва товару*/
	public int Quantity { get; set; }/*Кількість товару що мітиться на складі*/
	public double Price { get; set; }/*Ціна яка була визначена користувачем або використана підчас останнього відправлення або отримання цього товару */
	public DateTime DateAndTime { get; set; }/*Дата та час останьої зміни кількості товару (коли додано насклад або коли його завезли або відправили)*/
	public double Height { get; set; }/*висота товару*/
	public double Width { get; set; }/*ширина товару*/
	public double Length { get; set; }/*висота товару*/
	public double Weight { get; set; }/*вага товару*/
	public string Note { get; set; }/*примітка що залишив користувач к цьому товару*/
    public Product(Product product, Warehouse warehouseForConstructor, bool isAdd = true)/*конструктор що додає створює та додає товар на склад*/
    {
        if (isAdd)
        {
            this.Id = warehouseForConstructor.MaxId;
            warehouseForConstructor.MaxId++;
        }
        else
        {
            this.Id = product.Id;
        }
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
        if (isAdd)
        {
            warehouseForConstructor.AddIncident(new Incident(DateTime.Now, "Додано новий товар: " + product.Name, this.Id));
        }
    }
    public Product()/*порожній конструктор для створення товару без характеристик*/
    {
        this.Id = 0;
        this.Name = "";
        this.Quantity = 0;
        this.Price = 0;
        this.DateAndTime = DateTime.Now;
        this.Height = 0;
        this.Width = 0;
        this.Length = 0;
        this.Weight = 0;
        this.Note = "";
    }
    public static (Product product, bool[] isAllTrue) CreateProduct(bool isItAdd, int id, string name, string price, string quantity, string height, string width, string length, string weight, string note, Warehouse warehouse)/*метод для створення нового товару або зміни характеристик старого*/
    {
        bool[] isAllTrue = new bool[7];
        Array.Fill(isAllTrue, true);
        Product emptyProduct = new Product();
        emptyProduct.Id = id;

        if (name == "")
        {
            isAllTrue[0] = false;
        }
        else
        {
            foreach (Product controlNameObject in warehouse.Products)
            {
                if ((controlNameObject.Name == name && isItAdd) || (controlNameObject.Name == name && controlNameObject.Id != emptyProduct.Id && !isItAdd))
                {
                    isAllTrue[0] = false;
                    break;
                }
            }
            if (isAllTrue[0] == true)
            {
                emptyProduct.Name = name;
            }
        }

        string normalizedPrice = price.Replace(',', '.');
        if (double.TryParse(normalizedPrice, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double inputPrice))
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
        else
        {
            if (double.TryParse(quantity, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double inputQuantityDouble))
            {
                isAllTrue[2] = false;
            }
        }

        if (height != "")
        {
            string normalizedHeight = height.Replace(',', '.');
            if (double.TryParse(normalizedHeight, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double inputHeight))
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

        if (width != "")
        {
            string normalizedWidth = width.Replace(',', '.');
            if (double.TryParse(normalizedWidth, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double inputWidth))
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

        if (length != "")
        {
            string normalizedLength = length.Replace(',', '.');
            if (double.TryParse(normalizedLength, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double inputLength))
            {
                if (inputLength < 0)
                {
                    isAllTrue[5] = false;
                }
                else
                {
                    isAllTrue[5] = true;
                    emptyProduct.Length = inputLength;
                }
            }
        }

        if (weight != "")
        {
            string normalizedWeight = weight.Replace(',', '.');
            if (double.TryParse(normalizedWeight, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double inputWeight))
            {
                if (inputWeight < 0)
                {
                    isAllTrue[6] = false;
                }
                else
                {
                    isAllTrue[6] = true;
                    emptyProduct.Weight = inputWeight;
                }
            }
        }

        emptyProduct.Note = note;

        return (emptyProduct, isAllTrue);
    }
	public static bool[] AddNewProduct (string name, string price, string quantity, string height, string width, string length, string weight, string note, Warehouse warehouse)/*метод для додання нового товару до складу*/
	{
        var result = Product.CreateProduct(true, 0, name, price, quantity, height, width, length, weight, note, warehouse);
        bool[] isAllTrue = result.isAllTrue;
        Product emptyProduct = result.product;
        if (isAllTrue.All(x => x == true))
        {
            warehouse.AddProduct(emptyProduct);
        }
        return isAllTrue;
    }
    public static bool[] ChangeProductInfo (int id,string name, string price, string quantity, string height, string width, string length, string weight, string note,Product product, Warehouse warehouse)/*метод для зміни інформації о товарі*/
    {
        var result = Product.CreateProduct(false, id, name, price, quantity, height, width, length, weight, note, warehouse);
        bool[] isAllTrue = result.isAllTrue;
        Product emptyProduct = result.product;
        if (isAllTrue.All(x => x == true))
        {
            if (Product.AreProductsEqual(emptyProduct, product) == false)
            {
                warehouse.ChangeInfoOfProduct(emptyProduct);
                warehouse.AddIncident(new Incident(DateTime.Now, "Змінено інформацію про товар: " + product.Name, id));
            }
        }
        return isAllTrue;

    }
    public static bool AreProductsEqual(Product p1, Product p2)/*метод що порівнює поля двох товарів*/
    {
        return (p1.Id, p1.Name, p1.Price, p1.Quantity, p1.Height, p1.Width, p1.Length, p1.Weight, p1.Note) == (p2.Id, p2.Name, p2.Price, p2.Quantity, p2.Height, p2.Width, p2.Length, p2.Weight, p2.Note);
    }
}
