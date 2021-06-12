using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MacroTracker.Forms
{
    public partial class ReviewNewMealForm : Form
    {
        private Meal meal;
        private List<string> foods;
        private List<double> servings;

        public ReviewNewMealForm(Meal savedMeal, Dictionary<string, double> map)
        {
            InitializeComponent();

            meal = savedMeal;

            foods = new List<string>(map.Keys);
            servings = new List<double>(map.Values);

            foreach (KeyValuePair<string, double> pair in map)
            {
                mealToAddGrid.Rows.Add(pair.Key, pair.Value);
            }

            mealToAddGrid.RowHeadersVisible = false;
            mealToAddGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            mealToAddGrid.ClearSelection();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new RecordMealForm(meal).Show();
            Hide();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            new MenuForm().Show();
            Hide();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            DatabaseInterface.InsertMeal(meal);

            new MenuForm().Show();
            Hide();
        }

        private void foodsToAddGrid_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void ReviewNewMealForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
