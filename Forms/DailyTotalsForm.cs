using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MacroTracker.Forms
{
    public partial class DailyTotalsForm : Form
    {
        private List<Tuple<int, int>> breakfastFoods = new List<Tuple<int, int>>();
        private List<Tuple<int, int>> lunchFoods = new List<Tuple<int, int>>();
        private List<Tuple<int, int>> dinnerFoods = new List<Tuple<int, int>>();
        private List<Tuple<int, int>> snackFoods = new List<Tuple<int, int>>();

        public DailyTotalsForm()
        {
            InitializeComponent();
            datePicker.Value = DateTime.Today;

            LoadMeals();
            FillTables();
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

            foreach (Tuple<int, int> entry in breakfastFoods)
            {
                breakfastFoodsView.Rows.Add(DatabaseInterface.SelectFoodName(entry.Item1) + " (" + entry.Item2 + ")");
                breakfastFoodsView.ClearSelection();
            }

            foreach (Tuple<int, int> entry in lunchFoods)
            {
                lunchFoodsView.Rows.Add(DatabaseInterface.SelectFoodName(entry.Item1) + " (" + entry.Item2 + ")");
                lunchFoodsView.ClearSelection();
            }

            foreach (Tuple<int, int> entry in dinnerFoods)
            {
                dinnerFoodsView.Rows.Add(DatabaseInterface.SelectFoodName(entry.Item1) + " (" + entry.Item2 + ")");
                dinnerFoodsView.ClearSelection();
            }

            foreach (Tuple<int, int> entry in snackFoods)
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
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadMeals();
            FillTables();
        }
    }
}
