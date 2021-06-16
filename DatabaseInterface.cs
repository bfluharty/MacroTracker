using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MacroTracker
{
    public static class DatabaseInterface
    {
        public static void InitiateConnection()
        {
            connection = new SqlConnection(@"Data Source=LAPTOPPC-1\SQLEXPRESS;Initial Catalog=MacroTracker;Integrated Security=True");
            connection.Open();

            adapter = new SqlDataAdapter();
        }

        public static void CloseConnection()
        {
            connection.Close();
        }

        public static List<string> SelectFoodNames()
        {
            List<string> names = new List<string>();

            string sql = "SELECT Name FROM Foods";
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

        public static Food SelectMealTotal(DateTime date)
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
                total.Calories = (reader.GetValue(0).ToString().Equals("")) ? 0 : int.Parse(reader.GetValue(0).ToString());
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

        private static int SelectFoodID(string foodName)
        {
            string sql = "SELECT FoodID FROM Foods WHERE Name ='" + foodName + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            int ID = int.Parse(reader.GetValue(0).ToString());

            reader.Close();
            command.Dispose();

            return ID;
        }

        private static int SelectMealID(Meal meal)
        {
            int ID = -1;
            string sql = "SELECT MealID FROM Meals WHERE MealType='" + meal.GetStringMealType() + "' AND MealDate='" + meal.Date.ToShortDateString() + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                ID = int.Parse(reader.GetValue(0).ToString());
            }


            reader.Close();
            command.Dispose();

            return ID;
        }

        private static SqlConnection connection;
        private static SqlDataAdapter adapter;
    }
}
