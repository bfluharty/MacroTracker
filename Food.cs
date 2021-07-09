namespace MacroTracker
{
    public class Food
    {
        public Food()
        {
            Name = "";
            Calories = 0;
            Fat = 0;
            Carbs = 0;
            Protein = 0;
        }

        public Food(string name, int calories, double fat, double carbs, double protein)
        {
            Name = name;
            Calories = calories;
            Fat = fat;
            Carbs = carbs;
            Protein = protein;
        }

        public string GetInsertSQL()
        {
            return "('" + DatabaseInterface.SanitizeName(Name) + "', " + Calories + ", " + Fat + ", " + Carbs + ", " + Protein + ")";
        }

        public string GetUpdateSQL()
        {
            return "Name = '" + DatabaseInterface.SanitizeName(Name) + "', Calories = " + Calories + ", Fat = " + Fat + ", Carbs = " + Carbs + ", Protein = " + Protein;
        }

        public override string ToString()
        {
            return "Food [Name=" + Name +
                ", Calories=" + Calories +
                ", Fat=" + Fat +
                ", Carbs=" + Carbs +
                ", Protein=" + Protein + "]";
        }

        public string Name { get; set; }
        public int Calories { get; set; }
        public double Fat { get; set; }
        public double Carbs { get; set; }
        public double Protein { get; set; }
    }
}
