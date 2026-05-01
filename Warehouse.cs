using System;
using System.Xml.Linq;

namespace Курсовий_проєкт_на_тему_склад
{
	public class Warehouse
	{
		public List<Product> Products { get; set; }
		public int MaxId { get; set; }
		public int InvoiceLastId { get; set; }
        public List<Incident> History { get; set; }
        public List<ItemOfInvoice> InvoiceList { get; set; }
        public List<Invoice> InvoicesHistory { get; set; }

        public Warehouse()
		{
			Products = new List<Product>();
			MaxId = 1;
			InvoiceLastId = 1;
			History = new List<Incident>();
            InvoiceList = new List<ItemOfInvoice>();
            InvoicesHistory = new List<Invoice>();
        }
		public void AddIncident(Incident incident, Warehouse warehouseMhetod)
		{
            warehouseMhetod.History.Insert(0, incident);

            if (warehouseMhetod.History.Count > 1000)
            {
                int countToRemove = warehouseMhetod.History.Count - 1000;

                warehouseMhetod.History.RemoveRange(1000, countToRemove);
            }
        }
		public void AddInvoice(Invoice invoice, Warehouse warehouseMhetod)
        {
            warehouseMhetod.InvoicesHistory.Insert(0, invoice);
            if (warehouseMhetod.InvoicesHistory.Count > 1000)
            {
                int countToRemove = warehouseMhetod.InvoicesHistory.Count - 1000;
                warehouseMhetod.InvoicesHistory.RemoveRange(1000, countToRemove);
            }
        }   
    }
}
