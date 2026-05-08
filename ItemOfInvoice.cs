namespace Курсовий_проєкт_на_тему_склад
{
	public class ItemOfInvoice
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Quantity { get; set; }
		public double Price { get; set; }
		public ItemOfInvoice() /*Цей конструктор було додано для коректного збереження та завантаження программи в/з Json*/
		{ 
			Id = 0;
			Name = "";
			Quantity = 0;
			Price = 0;
		}
		public ItemOfInvoice(int id, int quantity, double price,Warehouse warehouse)
		{
			this.Id = id;
			this.Name = warehouse.Products.FirstOrDefault(p => p.Id == id).Name;
            this.Quantity = quantity;
			this.Price = price;
		}
		override public string ToString()
        {
            return $@"Id Товару: {Id}, Назва: {Name}, Кількість: {Quantity}, Ціна: {Price}";
        }
    }
}
