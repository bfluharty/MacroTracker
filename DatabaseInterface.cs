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

        public static void InsertFoods(List<Food> foods)
        {
            foreach (Food food in foods)
            {
                string sql = "INSERT INTO Foods (Name, Calories, Fat, Carbs, Protein) VALUES " + food.getInsertSQL();
                SqlCommand command = new SqlCommand(sql, connection);
                adapter.InsertCommand = new SqlCommand(sql, connection);
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();
            }
        }

        public static void SelectFoods()
        {
            string output = "Name\tCalories\tFat\tCarbs\tProtein\n";
            string sql = "SELECT Name, Calories, Fat, Carbs, Protein FROM Foods";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                output += reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t" + reader.GetValue(2) +
                    "\t" + reader.GetValue(3) + "\t" + reader.GetValue(4) + "\n";
            }
            Console.WriteLine(output);
            reader.Close();
            command.Dispose();
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

        public static Food SelectFood(string foodName)
        {

            string sql = "SELECT * FROM Foods WHERE Name ='" + foodName + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            Food food = new Food(foodName, int.Parse(reader.GetValue(2).ToString()), double.Parse(reader.GetValue(3).ToString()),
                double.Parse(reader.GetValue(4).ToString()), double.Parse(reader.GetValue(5).ToString()));

            reader.Close();
            command.Dispose();

            return food;
        }

        public static int SelectFoodID(string foodName)
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

        public static void InsertMeal(Meal meal)
        {
            string sql = "INSERT INTO Meals (MealType, MealDate) VALUES " + meal.getInsertSQL();
            Console.WriteLine(sql);
            SqlCommand command = new SqlCommand(sql, connection);
            adapter.InsertCommand = new SqlCommand(sql, connection);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
        }

        private static SqlConnection connection;
        private static SqlDataAdapter adapter;
    }
}
