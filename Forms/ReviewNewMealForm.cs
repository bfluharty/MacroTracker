using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MacroTracker.Forms
{
    public partial class ReviewNewMealForm : Form
    {
        private Meal meal;
        private Dictionary<string, double> mealMap;

        public ReviewNewMealForm(Meal savedMeal, Dictionary<string, double> map)
        {
            InitializeComponent();
            meal = savedMeal;

            mealLabel.Text = meal.ToString();

            mealMap = map;

            foreach (KeyValuePair<string, double> pair in map)
            {
                mealToAddGrid.Rows.Add(pair.Key, pair.Value);
            }

            mealToAddGrid.RowHeadersVisible = false;
            mealToAddGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            FormManager.AddForm(FormManager.FormTypes.MenuForm);
            Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            FormManager.AddForm(FormManager.FormTypes.RecordMealForm, meal);
            Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            DatabaseInterface.InsertMeal(meal);
            DatabaseInterface.InsertMealMap(meal, mealMap);

            FormManager.AddForm(FormManager.FormTypes.MenuForm);
            Close();
        }

        private void foodsToAddGrid_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void ReviewNewMealForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.RemoveForm(this);
        }

        private void ReviewNewMealForm_Shown(object sender, EventArgs e)
        {
            mealToAddGrid.ClearSelection();
            title.Select();
        }
    }
}
