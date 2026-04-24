using System;
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
	
	public Product(string name, double price, double height, double width, double length, double weight, string note, Warehouse warehouseForConstructor)
	{
		this.Id = warehouseForConstructor.MaxId;
		warehouseForConstructor.MaxId ++;	
        this.Name = name;
		this.Quantity = 0;
		this.Price = price;
		this.DateAndTime = DateTime.Now;
		this.Height = height;
		this.Width = width;
		this.Length = length;
		this.Weight = weight;
		this.Note = note;
		warehouseForConstructor.AddIncident(new Incident(DateTime.Now, "Додано новий товар: " + name, this.Id), warehouseForConstructor);
    }

}
