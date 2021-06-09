using System;

namespace MacroTracker
{
    public class Meal
    {
        public Meal()
        {
            Type = 'S';
            Date = new DateTime();
        }

        public Meal(char type, DateTime date)
        {
            Type = type;
            Date = date;
        }

        public override string ToString()
        {
            return "Meal [Type=" + Type +
                ", Date=" + Date.Date + "]";
        }

        public char Type { get; set; }
        public DateTime Date { get; set; }
    }
}
