using System;
using Курсовий_проєкт_на_тему_склад;
namespace Курсовий_проєкт_на_тему_склад
{
	public class Invoice
	{
		int InvoiceId { get; set; }
		DateTime Date { get; set; }
		bool IsExpenditureInvoice { get; set; }
		List<ItemOfInvoice> Items { get; set; }


		public Invoice(Warehouse warehouse, bool isExpenditureInvoice, List<ItemOfInvoice> items)
		{
			this.InvoiceId = warehouse.InvoiceLastId;
			this.Date = DateTime.Now;
			this.IsExpenditureInvoice = isExpenditureInvoice;
			Items = new List<ItemOfInvoice>(items);
		}
	}
}
