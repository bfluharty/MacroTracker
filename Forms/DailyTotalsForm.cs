using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MacroTracker.Forms
{
    public partial class DailyTotalsForm : Form
    {
        private List<Tuple<int, double>> breakfastFoods = new List<Tuple<int, double>>();
        private List<Tuple<int, double>> lunchFoods = new List<Tuple<int, double>>();
        private List<Tuple<int, double>> dinnerFoods = new List<Tuple<int, double>>();
        private List<Tuple<int, double>> snackFoods = new List<Tuple<int, double>>();
        private Food breakfast = new Food();
        private Food lunch = new Food();
        private Food dinner = new Food();
        private Food snack = new Food();
        private Food total = new Food();

        public DailyTotalsForm()
        {
            InitializeComponent();
            datePicker.Value = DateTime.Today;

            breakfast = DatabaseInterface.SelectMealTotal('B', datePicker.Value);
            lunch = DatabaseInterface.SelectMealTotal('L', datePicker.Value);
            dinner = DatabaseInterface.SelectMealTotal('D', datePicker.Value);
            snack = DatabaseInterface.SelectMealTotal('S', datePicker.Value);
            total = DatabaseInterface.SelectDailyTotal(datePicker.Value);

            LoadMeals();
            UpdateTotals();
        }

        private void LoadMeals()
        {
            breakfastFoods = DatabaseInterface.SelectMealFoods(new Meal('B', datePicker.Value));
            lunchFoods = DatabaseInterface.SelectMealFoods(new Meal('L', datePicker.Value));
            dinnerFoods = DatabaseInterface.SelectMealFoods(new Meal('D', datePicker.Value));
            snackFoods = DatabaseInterface.SelectMealFoods(new Meal('S', datePicker.Value));
        }

        private void FillTables()
        {
            ClearSelections();

            foreach (Tuple<int, double> entry in breakfastFoods)
            {
                breakfastFoodsView.Rows.Add(DatabaseInterface.SelectFoodName(entry.Item1) + " (" + entry.Item2 + ")");
                breakfastFoodsView.ClearSelection();
            }

            foreach (Tuple<int, double> entry in lunchFoods)
            {
                lunchFoodsView.Rows.Add(DatabaseInterface.SelectFoodName(entry.Item1) + " (" + entry.Item2 + ")");
                lunchFoodsView.ClearSelection();
            }

            foreach (Tuple<int, double> entry in dinnerFoods)
            {
                dinnerFoodsView.Rows.Add(DatabaseInterface.SelectFoodName(entry.Item1) + " (" + entry.Item2 + ")");
                dinnerFoodsView.ClearSelection();
            }

            foreach (Tuple<int, double> entry in snackFoods)
            {
                snackFoodsView.Rows.Add(DatabaseInterface.SelectFoodName(entry.Item1) + " (" + entry.Item2 + ")");
                snackFoodsView.ClearSelection();
            }
        }

        private void ClearSelections()
        {
            breakfastFoodsView.Rows.Clear();
            lunchFoodsView.Rows.Clear();
            dinnerFoodsView.Rows.Clear();
            snackFoodsView.Rows.Clear();
        }

        private void UpdateTotals()
        {
            breakfastCaloriesValue.Text = breakfast.Calories.ToString();
            breakfastFatValue.Text = breakfast.Fat.ToString() + " g";
            breakfastCarbsValue.Text = breakfast.Carbs.ToString() + " g";
            breakfastProteinValue.Text = breakfast.Protein.ToString() + " g";

            lunchCaloriesValue.Text = lunch.Calories.ToString();
            lunchFatValue.Text = lunch.Fat.ToString() + " g";
            lunchCarbsValue.Text = lunch.Carbs.ToString() + " g";
            lunchProteinValue.Text = lunch.Protein.ToString() + " g";

            dinnerCaloriesValue.Text = dinner.Calories.ToString();
            dinnerFatValue.Text = dinner.Fat.ToString() + " g";
            dinnerCarbsValue.Text = dinner.Carbs.ToString() + " g";
            dinnerProteinValue.Text = dinner.Protein.ToString() + " g";

            snackCaloriesValue.Text = snack.Calories.ToString();
            snackFatValue.Text = snack.Fat.ToString() + " g";
            snackCarbsValue.Text = snack.Carbs.ToString() + " g";
            snackProteinValue.Text = snack.Protein.ToString() + " g";

            caloriesValue.Text = total.Calories.ToString();
            fatValue.Text = total.Fat.ToString() + " g";
            carbsValue.Text = total.Carbs.ToString() + " g";
            proteinValue.Text = total.Protein.ToString() + " g";
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            new MenuForm().Show();
            Hide();
        }

        private void DailyTotalsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DailyTotalsForm_Shown(object sender, EventArgs e)
        {
            ClearSelections();
            FillTables();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            breakfast = DatabaseInterface.SelectMealTotal('B', datePicker.Value);
            lunch = DatabaseInterface.SelectMealTotal('L', datePicker.Value);
            dinner = DatabaseInterface.SelectMealTotal('D', datePicker.Value);
            snack = DatabaseInterface.SelectMealTotal('S', datePicker.Value);
            total = DatabaseInterface.SelectDailyTotal(datePicker.Value);

            LoadMeals();
            FillTables();
            UpdateTotals();
        }
    }
}
