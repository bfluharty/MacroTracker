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
        }

        public static void CloseConnection()
        {
            connection.Close();
        }

        public static void InsertFoods(List<Food> foods)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

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

        private static SqlConnection connection;
    }
}
