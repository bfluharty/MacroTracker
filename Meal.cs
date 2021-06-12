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

        public static char GetCharMealType(string input)
        {
            return (char)input.ToCharArray().GetValue(0);
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

        public string GetStringMealType()
        {
            return ((char)Type).ToString();
        }

        public string GetInsertSQL()
        {
            return "('" + GetStringMealType() + "', '" + Date.ToShortDateString() + "')";
        }

        public override string ToString()
        {
            return Type + " - " + Date.ToShortDateString();
        }

        public MealTypes Type { get; set; }
        public DateTime Date { get; set; }
    }
}
