using System;
using System.Xml.Linq;

namespace Курсовий_проєкт_на_тему_склад
{
	public class Warehouse
	{
		public List<Product> Products { get; set; }
		public int MaxId { get; set; }
		public List<Incident> History { get; set; }

        public Warehouse()
		{
			Products = new List<Product>();
			MaxId = 1;
			History = new List<Incident>();
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
	}
}
