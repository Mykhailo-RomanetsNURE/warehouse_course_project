using System;
using System.Drawing.Printing;
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
		public void AddIncident(Incident incident)
		{
            this.History.Insert(0, incident);

            if (this.History.Count > 1000)
            {
                int countToRemove = this.History.Count - 1000;

                this.History.RemoveRange(1000, countToRemove);
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
        public void ClearWarehouse()
        {
            this.Products.Clear();
            this.MaxId = 1;
            this.InvoiceLastId = 1;
            this.History.Clear();
            this.InvoiceList.Clear();
            this.InvoicesHistory.Clear();
        }
        public void AddProduct(Product productLink)
        {
            Product product = new Product(productLink, this);
            this.Products.Add(product);
        }
        public void ChangeInfoOfProduct(Product newProductLink)
        {
            int index = this.Products.FindIndex(p => p.Id == newProductLink.Id);
            if (index != -1)
            {
                this.Products[index] = new Product(newProductLink, this, false);
            }
        }
        public void RemoveProduct(int id)
        {
            int index = this.Products.FindIndex(p => p.Id == id);
            int indexNewInvoice = this.InvoiceList.FindIndex(p => p.Id == id);
            if (index != -1 && indexNewInvoice != -1)
            {
                this.Products.RemoveAt(index);
                this.AddIncident(new Incident(DateTime.Now, "Видалено товар: " + this.Products.FirstOrDefault(p => p.Id == id), id));
            }
            else
            {
                MessageBox.Show("Товар не можна видалити якщо він він приймає участь у створенні нової накладної.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Product TakeProduct(int id)
        {
            return this.Products.FirstOrDefault(p => p.Id == id) ?? new Product();
            
        }
        public void CleanHistoryProduct(int id)
        {
            this.History.RemoveAll(h => h.ElementId == id);
            Product product = this.TakeProduct(id);
            this.AddIncident(new Incident(date: DateTime.Now, "Історію продукта: " + product.Name + ", було видалено", id));
        }
        public (List<Product> itemsForPage, int pageNumber, int totalPages, int totalItems) DataProductTable(int pageNumber, string searchText, string selectedItem, bool isSearchOn)
        {
            List<Product> sourceList = this.Products;
            if (isSearchOn)
            {
                string normalizedDoubleNumber = searchText.Replace(',', '.');
                double doubleNumber = double.TryParse(normalizedDoubleNumber, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double d) ? d : -1;
                int intNumber = int.TryParse(searchText, out int n) ? n : -1;
                Dictionary<string, Func<Product, bool>> filters = new Dictionary<string, Func<Product, bool>>
                {
                    { "Назва", x => x.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase) },
                    { "Вартість",  x => x.Price == doubleNumber },
                    { "ID",    x => x.Id == intNumber },
                    { "Кількість",  x => x.Quantity == intNumber },
                    { "Висота",  x => x.Height == doubleNumber },
                    { "Ширина",  x => x.Width == doubleNumber },
                    { "Довжина",  x => x.Length == doubleNumber },
                    { "Вага",  x => x.Weight == doubleNumber },
                    { "Примітка", x => x.Note.Contains(searchText, StringComparison.OrdinalIgnoreCase) }
                };
                sourceList = this.Products.Where(filters[selectedItem]).ToList();
            }
            int totalItems = sourceList.Count;
            int totalPages = (int)Math.Ceiling((double)totalItems / Constants.PAGE_SIZE);
            if (totalPages == 0) totalPages = 1;
            if (pageNumber > totalPages) pageNumber = totalPages;
            if (pageNumber < 1) pageNumber = 1;

            var itemsForPage = sourceList
                    .Skip((pageNumber - 1) * Constants.PAGE_SIZE)
                    .Take(Constants.PAGE_SIZE)
                    .ToList();
            return (itemsForPage, pageNumber, totalPages, totalItems);
        }
        public (List<Incident> itemsForTable, int pageNumber, int totalPages, int totalItems) ProductHistoryDataTable(int pageNumber, int id)
        {
            List<Incident> incidentsForTable = this.History;
            if (id != 0)
            {
                incidentsForTable = incidentsForTable.Where(p => p.ElementId == id).ToList();
            }
            int totalItems = incidentsForTable.Count;
            int totalPages = (int)Math.Ceiling((double)totalItems / Constants.PAGE_SIZE);
            if (totalPages == 0) totalPages = 1;
            if (pageNumber > totalPages) pageNumber = totalPages;
            if (pageNumber < 1) pageNumber = 1;
            var itemsForTable = incidentsForTable
                    .Skip((pageNumber - 1) * Constants.PAGE_SIZE)
                    .Take(Constants.PAGE_SIZE)
                    .ToList();
            return (itemsForTable, pageNumber, totalPages, totalItems);
        }

    }
}
