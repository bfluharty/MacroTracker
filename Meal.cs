using System;

namespace MacroTracker
{
    public class Meal
    {
        public enum MealTypes
        {
            Breakfast = 'B',
            Lunch = 'L',
            Dinner = 'D',
            Snack = 'S'
        }

        public Meal()
        {
            Type = MealTypes.Snack;
            Date = DateTime.Now;
        }

        public Meal(char type, DateTime date)
        {
            Type = (MealTypes) type;
            Date = date;
        }

        public string getInsertSQL()
        {
            return "('" + (char) Type + "', '" + Date.ToShortDateString() + "')";
        }

        public override string ToString()
        {
            return Type + " - " + Date.ToShortDateString();
        }

        public MealTypes Type { get; set; }
        public DateTime Date { get; set; }
    }
}
