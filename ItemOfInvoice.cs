namespace Курсовий_проєкт_на_тему_склад
{
	public class ItemOfInvoice
	{
		/*Клас що необхідний для створення елементів у нкаладній*/
		public int Id { get; set; }/* Id  товару що додано до накладної*/
        public string Name { get; set; }/* назва товару */
		public int Quantity { get; set; }/*Кількість одиниць цього товару що зареєстрована в накладній*/
		public double Price { get; set; }/*Ціна цього товару що було зареєстровано у накладній*/
		public ItemOfInvoice() /*Цей конструктор було додано для коректного збереження та завантаження программи в/з Json*/
		{ 
			Id = 0;
			Name = "";
			Quantity = 0;
			Price = 0;
		}
		public ItemOfInvoice(int id, int quantity, double price,Warehouse warehouse)/*Стандартний конструктор для звичайного додавання товару*/
		{
			this.Id = id;
			this.Name = warehouse.Products.FirstOrDefault(p => p.Id == id).Name;
            this.Quantity = quantity;
			this.Price = price;
		}
		override public string ToString()/*метод для зручного збереження накладної у текстовий файл для читання користувачем*/
        {
            return $@"Id Товару: {Id}, Назва: {Name}, Кількість: {Quantity}, Ціна: {Price}";
        }
    }
}
