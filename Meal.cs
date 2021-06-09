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

        public override string ToString()
        {
            return "Meal [Type=" + Type +
                ", Date=" + Date.ToShortDateString() + "]";
        }

        public MealTypes Type { get; set; }
        public DateTime Date { get; set; }
    }
}
