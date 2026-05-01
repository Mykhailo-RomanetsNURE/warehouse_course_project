using System;
using Курсовий_проєкт_на_тему_склад;
namespace Курсовий_проєкт_на_тему_склад
{
	public class Invoice
	{
		int InvoiceId { get; set; }
		DateTime Date { get; set; }
		bool IsExpenditureInvoice { get; set; }/*прибуткова чи видаткова накладна*/
		List<ItemOfInvoice> Items { get; set; }


		public Invoice(Warehouse warehouse, bool isExpenditureInvoice, List<ItemOfInvoice> items)
		{
			this.InvoiceId = warehouse.InvoiceLastId;
			this.Date = DateTime.Now;
			this.IsExpenditureInvoice = isExpenditureInvoice;
			Items = new List<ItemOfInvoice>(items);
			for (int i = 0; i < items.Count; i++)
			{
                var item = items[i];
                foreach (var product in warehouse.Products)
				{
					if (item.Id == product.Id)
					{
						if (isExpenditureInvoice == false)
						{
							product.Quantity -= item.Quantity;
						}
						else
						{
							product.Quantity += item.Quantity;
                        }
                        product.DateAndTime = this.Date;
                        break;
					}
				}
			}
		}
	}
}
