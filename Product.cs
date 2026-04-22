using System;

public class Product
{
	public int Id { get; set; }/*ідентифікатор*/
    public string Name { get; set; }/*Назва*/
	public int Quantity { get; set; }/*кількість*/
	public double Price { get; set; }/*ціна*/
	public DateTime DateAndTime { get; set; }/*дата і час*/
	public double? Width { get; set; }/*ширина*/
	public double? Height { get; set; }/*висота*/
	public double? Length { get; set; }/*довжина*/
	public double? Weight { get; set; }/*вага*/
	public string? Note { get; set; }/*примітка*/
	
	public Product(string name, int quantity, double price,DateTime dateAndTime, double? width = null, double? height = null, double? length = null, double? weight = null)
	{
		this.Name = name;
		this.Quantity = quantity;
		this.Price = price;
		this.DateAndTime = dateAndTime;
		this.Width = width;
		this.Height = height;
		this.Length = length;
		this.Weight = weight;
    }

}
