using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace MacroTracker.Forms
{
    public partial class ReviewNewMealForm : Form
    {
        private Meal meal;
        private Dictionary<string, double> mealMap;
        private bool ascending = false;

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
            HandleSort(mealToAddGrid.Columns[0]);
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

        private void mealToAddGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (mealToAddGrid.RowCount > 0)
            {
                if (e.RowIndex == -1 && e.ColumnIndex != mealToAddGrid.ColumnCount - 1)
                {
                    ResetHeaders();
                    HandleSort(mealToAddGrid.Columns[e.ColumnIndex]);
                }
                else if (e.ColumnIndex == mealToAddGrid.Columns["removeMealColumn"].Index && e.RowIndex >= 0)
                {
                    string food = mealToAddGrid.Rows[e.RowIndex].Cells[0].Value.ToString();

                    foreach (KeyValuePair<string, double> pair in mealMap)
                    {
                        if (pair.Key == food)
                        {
                            mealMap.Remove(food);
                            break;
                        }
                    }

                    if (mealMap.Count == 0)
                    {
                        submitButton.Enabled = false;
                    }

                    mealToAddGrid.Rows.RemoveAt(e.RowIndex);
                    ResetHeaders();
                }
                mealToAddGrid.ClearSelection();
            }
        }

        private void HandleSort(DataGridViewColumn column)
        {
            if (ascending)
            {
                mealToAddGrid.Sort(column, ListSortDirection.Descending);
                column.HeaderText += " \\/";
                ascending = false;
            }
            else
            {
                mealToAddGrid.Sort(column, ListSortDirection.Ascending);
                column.HeaderText += " /\\";
                ascending = true;
            }
        }

        private void ResetHeaders()
        {
            DataGridViewColumnCollection columns = mealToAddGrid.Columns;
            List<string> headerNames = new List<string>() { "Food", "Servings" };

            for (int i = 0; i < columns.Count - 1; i++)
            {
                columns[i].HeaderText = headerNames[i];
            }
        }
    }
}
