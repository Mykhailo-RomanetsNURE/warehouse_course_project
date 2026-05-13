using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Курсовий_проєкт_на_тему_склад
{
	public class Incident	
	{
		/*клас що створює обєкти події які виникли на складі і будуть відображені в історії*/
        public DateTime Date {  get; set; }/*час реєстрації події*/
		public string WhatHappened { get; set; }/*текст події*/
		public int ElementId { get; set; }/*Id товару з яким була повязана подія*/
		public Incident()/*порожній конструктор що може знадобитися при читанні файлу збереження*/ 
		{
            this.Date = DateTime.Now;
            this.WhatHappened = "";
            this.ElementId = 0;
        }
        public Incident(DateTime date, string whatHappened, int elementId)/*конструктор що створить обєкт подія за вказівкою інших класів*/
		{
			this.Date = date;
			this.WhatHappened = whatHappened;
			this.ElementId = elementId;
		}
	}
}
