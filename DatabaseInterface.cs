using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MacroTracker
{
    public static class DatabaseInterface
    {
        private static SqlConnection connection;
        private static SqlDataAdapter adapter;

        public static void InitiateConnection()
        {
            connection = new SqlConnection(Properties.Settings.Default.MacroTrackerDatabaseConnectionString);
            connection.Open();
            adapter = new SqlDataAdapter();
        }

        public static void CloseConnection()
        {
            connection.Close();
        }

        public static int SelectFoodID(string foodName)
        {
            string sql = "SELECT FoodID FROM Foods WHERE Name ='" + SanitizeName(foodName) + "' AND Visible = 1";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            int ID = int.Parse(reader.GetValue(0).ToString());

            reader.Close();
            command.Dispose();

            return ID;
        }

        public static List<string> SelectFoodNames()
        {
            List<string> names = new List<string>();

            string sql = "SELECT Name FROM Foods WHERE Visible = 1";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                names.Add(reader.GetValue(0).ToString());
            }

            reader.Close();
            command.Dispose();

            return names;
        }

        public static List<Food> SelectVisibleFoods()
        {
            List<Food> foods = new List<Food>();

            string sql = "SELECT Name, Calories, Fat, Carbs, Protein FROM Foods WHERE Visible = 1";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Food food = new Food();
                food.Name = reader.GetValue(0).ToString();
                food.Calories = (reader.GetValue(1).ToString().Equals("")) ? 0 : int.Parse(reader.GetValue(1).ToString());
                food.Fat = (reader.GetValue(2).ToString().Equals("")) ? 0 : double.Parse(reader.GetValue(2).ToString());
                food.Carbs = (reader.GetValue(3).ToString().Equals("")) ? 0 : double.Parse(reader.GetValue(3).ToString());
                food.Protein = (reader.GetValue(4).ToString().Equals("")) ? 0 : double.Parse(reader.GetValue(4).ToString());
                foods.Add(food);
            }
            reader.Close();
            command.Dispose();

            return foods;
        }

        public static List<Tuple<string, string>> SelectMeals()
        {
            List<Tuple<string, string>> meals = new List<Tuple<string, string>>();

            string sql = "SELECT MealType, MealDate FROM Meals";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string type = reader.GetValue(0).ToString();
                string dateTime = reader.GetValue(1).ToString();

                string date = dateTime.Substring(0, dateTime.IndexOf(" "));

                meals.Add(new Tuple<string, string>(type, date));
            }

            reader.Close();
            command.Dispose();

            return meals;
        }

        public static List<Tuple<int, double>> SelectMealFoods(Meal meal)
        {
            int mealID = SelectMealID(meal);
            List<Tuple<int, double>> foods = new List<Tuple<int, double>>();

            string sql = "SELECT FoodID, Servings FROM MealContents WHERE MealID = " + mealID;
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int foodID = int.Parse(reader.GetValue(0).ToString());
                double servings = double.Parse(reader.GetValue(1).ToString());

                foods.Add(new Tuple<int, double>(foodID, servings));
            }


            reader.Close();
            command.Dispose();

            return foods;
        }

        public static bool MealExists(Meal meal)
        {
            int mealID = SelectMealID(meal);
            return mealID != -1;
        }

        public static Food SelectMealTotal(char type, DateTime date)
        {
            Food total = new Food();

            string sql = "SELECT SUM(Foods.Calories * MealContents.Servings), SUM(Foods.Fat * MealContents.Servings), " +
                "SUM(Foods.Carbs * MealContents.Servings), SUM(Foods.Protein * MealContents.Servings) " +
                "FROM MealContents INNER JOIN Foods ON MealContents.FoodID = Foods.FoodID " +
                "INNER JOIN Meals ON MealContents.MealID = Meals.MealID WHERE Meals.MealType = '" + type + "' AND Meals.MealDate = '" + date.ToShortDateString() + "'";

            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                total.Calories = (reader.GetValue(0).ToString().Equals("")) ? 0 : (int) double.Parse(reader.GetValue(0).ToString());
                total.Fat = (reader.GetValue(1).ToString().Equals("")) ? 0 : double.Parse(reader.GetValue(1).ToString());
                total.Carbs = (reader.GetValue(2).ToString().Equals("")) ? 0 : double.Parse(reader.GetValue(2).ToString());
                total.Protein = (reader.GetValue(3).ToString().Equals("")) ? 0 : double.Parse(reader.GetValue(3).ToString());
            }

            reader.Close();
            command.Dispose();

            return total;
        }

        public static string SelectFoodName(int foodID)
        {
            string name;
            string sql = "SELECT Name FROM Foods WHERE FoodID = " + foodID;
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            name = (reader.GetValue(0).ToString());

            reader.Close();
            command.Dispose();

            return name;
        }

        public static Food SelectDailyTotal(DateTime date)
        {
            Food total = new Food();

            string sql = "SELECT SUM(Foods.Calories * MealContents.Servings), SUM(Foods.Fat * MealContents.Servings), " +
                "SUM(Foods.Carbs * MealContents.Servings), SUM(Foods.Protein * MealContents.Servings) " +
                "FROM MealContents INNER JOIN Foods ON MealContents.FoodID = Foods.FoodID " +
                "INNER JOIN Meals ON MealContents.MealID = Meals.MealID WHERE Meals.MealDate = '" + date.ToShortDateString() + "'";

            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                total.Calories = (reader.GetValue(0).ToString().Equals("")) ? 0 : (int) double.Parse(reader.GetValue(0).ToString());
                total.Fat = (reader.GetValue(1).ToString().Equals("")) ? 0 : double.Parse(reader.GetValue(1).ToString());
                total.Carbs = (reader.GetValue(2).ToString().Equals("")) ? 0 : double.Parse(reader.GetValue(2).ToString());
                total.Protein = (reader.GetValue(3).ToString().Equals("")) ? 0 : double.Parse(reader.GetValue(3).ToString());
            }

            reader.Close();
            command.Dispose();

            return total;
        }

        public static void InsertFoods(List<Food> foods)
        {
            foreach (Food food in foods)
            {
                string sql = "INSERT INTO Foods (Name, Calories, Fat, Carbs, Protein) VALUES " + food.GetInsertSQL();
                SqlCommand command = new SqlCommand(sql, connection);
                adapter.InsertCommand = new SqlCommand(sql, connection);
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();
            }
        }

        public static void InsertMeal(Meal meal)
        {
            string sql = "INSERT INTO Meals (MealType, MealDate) VALUES " + meal.GetInsertSQL();
            SqlCommand command = new SqlCommand(sql, connection);
            adapter.InsertCommand = new SqlCommand(sql, connection);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
        }

        public static void InsertMealMap(Meal meal, Dictionary<string, double> map)
        {
            int mealID = SelectMealID(meal);
            foreach (KeyValuePair<string, double> pair in map)
            {
                string sql = "INSERT INTO MealContents (MealID, FoodID, Servings) VALUES (" + mealID + ", " + SelectFoodID(pair.Key) + ", " + pair.Value + ")";
                SqlCommand command = new SqlCommand(sql, connection);
                adapter.InsertCommand = new SqlCommand(sql, connection);
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();
            }
        }

        public static void EditFood(int foodID, Food food)
        {
            UpdateFood(foodID, food);
        }

        public static void EditMeal(Meal meal, Tuple<string, double> entry)
        {
            int mealID = SelectMealID(meal);
            int foodID = SelectFoodID(entry.Item1);
            double servings = entry.Item2;
            UpdateMeal(mealID, foodID, servings);
        }

        public static void HideFood(string name)
        {
            string sql = "UPDATE Foods SET Visible = 0 WHERE Name = '" + name + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            adapter.UpdateCommand = new SqlCommand(sql, connection);
            adapter.UpdateCommand.ExecuteNonQuery();
            command.Dispose();
        }

        public static void DeleteEntry(Meal meal, string name)
        {
            int mealID = SelectMealID(meal);
            int foodID = SelectFoodID(name);

            string sql = "DELETE FROM MealContents WHERE MealID = " + mealID + "AND FoodID = " + foodID;
            SqlCommand command = new SqlCommand(sql, connection);
            adapter.DeleteCommand = new SqlCommand(sql, connection);
            adapter.DeleteCommand.ExecuteNonQuery();
            command.Dispose();

            CleanupMealTable(mealID);
        }

        public static string SanitizeName(string input)
        {
            string rest = input;
            string complete = "";

            while (rest.Contains("'"))
            {
                int loc = rest.IndexOf('\'') + 1;

                string temp = rest.Substring(0, loc);
                rest = rest.Substring(loc, rest.Length - loc);

                temp = temp.Insert(temp.Length, "'");
                complete += temp;
            }
            return complete + rest;
        }

        private static void CleanupMealTable(int mealID)
        {
            bool entriesRemain = false;
            string sql = "SELECT MealID FROM MealContents WHERE MealID = " + mealID;
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                entriesRemain = true;
                break;
            }

            reader.Close();
            command.Dispose();

            if (!entriesRemain)
            {
                DeleteMeal(mealID);
            }
        }

        private static int SelectMealID(Meal meal)
        {
            int ID = -1;
            string sql = "SELECT MealID FROM Meals WHERE MealType='" + meal.GetStringMealType() + "' AND MealDate='" + meal.Date.ToShortDateString() + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ID = int.Parse(reader.GetValue(0).ToString());
            }

            reader.Close();
            command.Dispose();

            return ID;
        }

        private static void UpdateFood(int foodID, Food food)
        {
            string sql = "UPDATE Foods SET " + food.GetUpdateSQL() + " WHERE FoodID = " + foodID;
            SqlCommand command = new SqlCommand(sql, connection);
            adapter.UpdateCommand = new SqlCommand(sql, connection);
            adapter.UpdateCommand.ExecuteNonQuery();
            command.Dispose();
        }

        private static void UpdateMeal(int mealID, int foodID, double servings)
        {
            string sql = "UPDATE MealContents SET servings = " + servings + " WHERE MealID = " + mealID + " AND FoodID = " + foodID;
            SqlCommand command = new SqlCommand(sql, connection);
            adapter.UpdateCommand = new SqlCommand(sql, connection);
            adapter.UpdateCommand.ExecuteNonQuery();
            command.Dispose();
        }

        private static void DeleteMeal(int mealID)
        {
            string sql = "DELETE FROM Meals WHERE MealID = " + mealID;
            SqlCommand command = new SqlCommand(sql, connection);
            adapter.DeleteCommand = new SqlCommand(sql, connection);
            adapter.DeleteCommand.ExecuteNonQuery();
            command.Dispose();
        }
    }
}
