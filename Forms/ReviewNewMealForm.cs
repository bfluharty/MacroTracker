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

            FillTable();
            mealToAddGrid.RowHeadersVisible = false;
            HandleSort(mealToAddGrid.Columns[0]);
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            FormManager.AddForm(FormManager.FormTypes.MenuForm);
            Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            FormManager.AddForm(FormManager.FormTypes.RecordMealForm, meal, map: mealMap);
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

        private void FillTable()
        {
            mealToAddGrid.Rows.Clear();

            foreach (KeyValuePair<string, double> pair in mealMap)
            {
                mealToAddGrid.Rows.Add(pair.Key, pair.Value);
            }
        }

        private void mealToAddGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (mealToAddGrid.RowCount > 0)
            {
                // Sort column
                if (e.RowIndex == -1 && e.ColumnIndex != mealToAddGrid.ColumnCount - 1)
                {
                    ResetHeaders();
                    HandleSort(mealToAddGrid.Columns[e.ColumnIndex]);
                }
                // Edit entry
                else if (e.ColumnIndex == mealToAddGrid.ColumnCount - 2 && e.RowIndex >= 0)
                {
                    DataGridViewCellCollection group = mealToAddGrid.Rows[e.RowIndex].Cells;
                    string name = group[0].Value.ToString();
                    double servings = double.Parse(group[1].Value.ToString());
                    EditNewMealForm form = new EditNewMealForm(mealMap, new Tuple<string, double>(name, servings));
                    form.ShowDialog();
                    mealMap = form.mealMap;

                    FillTable();
                    ascending = false;
                    HandleSort(mealToAddGrid.Columns[0]);
                    ResetHeaders();
                }
                // Remove entry
                else if (e.ColumnIndex == mealToAddGrid.ColumnCount - 1 && e.RowIndex >= 0)
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

            for (int i = 0; i < columns.Count - 2; i++)
            {
                columns[i].HeaderText = headerNames[i];
            }
        }
    }
}
