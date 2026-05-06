namespace Курсовий_проєкт_на_тему_склад
{
	public class Incident	
	{
        public DateTime Date {  get; set; }
		public string WhatHappened { get; set; }
		public int ElementId { get; set; }
        public Incident(DateTime date, string whatHappened, int elementId)
		{
			this.Date = date;
			this.WhatHappened = whatHappened;
			this.ElementId = elementId;
		}
	}
}
