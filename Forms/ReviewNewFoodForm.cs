using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace MacroTracker.Forms
{
    public partial class ReviewNewFoodForm : Form
    {
        private List<Food> foods;
        private bool ascending = true;

        public ReviewNewFoodForm(List<Food> addedFoods)
        {
            InitializeComponent();
            foods = addedFoods;

            foreach (Food food in foods)
            {
                foodsToAddGrid.Rows.Add(food.Name, food.Calories, food.Fat, food.Carbs, food.Protein);
            }

            foodsToAddGrid.RowHeadersVisible = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            FormManager.AddForm(FormManager.FormTypes.AddNewFoodForm);
            Close();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            FormManager.AddForm(FormManager.FormTypes.MenuForm);
            Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            DatabaseInterface.InsertFoods(foods);

            FormManager.AddForm(FormManager.FormTypes.MenuForm);
            Close();
        }

        private void foodsToAddGrid_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void ReviewNewFoodForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.RemoveForm(this);
        }

        private void ReviewNewFoodForm_Shown(object sender, EventArgs e)
        {
            foodsToAddGrid.ClearSelection();
            title.Select();
        }

        private void foodsToAddGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (foodsToAddGrid.RowCount > 0)
            {
                if (e.RowIndex == -1 && e.ColumnIndex != foodsToAddGrid.ColumnCount - 1)
                {
                    ResetHeaders();
                    HandleSort(foodsToAddGrid.Columns[e.ColumnIndex]);
                }
                else if (e.ColumnIndex == foodsToAddGrid.Columns["removeFoodColumn"].Index && e.RowIndex >= 0)
                {
                    string food = foodsToAddGrid.Rows[e.RowIndex].Cells[0].Value.ToString();

                    foreach (Food item in foods)
                    {
                        if (item.Name == food)
                        {
                            foods.Remove(item);
                            break;
                        }
                    }

                    if (foods.Count == 0)
                    {
                        submitButton.Enabled = false;
                    }

                    foodsToAddGrid.Rows.RemoveAt(e.RowIndex);
                    ResetHeaders();
                }
                foodsToAddGrid.ClearSelection();
            }
            
        }

        private void HandleSort(DataGridViewColumn column)
        {
            if (ascending)
            {
                foodsToAddGrid.Sort(column, ListSortDirection.Descending);
                column.HeaderText += " \\/";
                ascending = false;
            }
            else
            {
                foodsToAddGrid.Sort(column, ListSortDirection.Ascending);
                column.HeaderText += " /\\";
                ascending = true;
            }
        }

        private void ResetHeaders()
        {
            DataGridViewColumnCollection columns = foodsToAddGrid.Columns;
            List<string> headerNames = new List<string>() { "Name", "Calories", "Fat", "Carbs", "Protein" };

            for (int i = 0; i < columns.Count - 1; i++)
            {
                columns[i].HeaderText = headerNames[i];
            }
        }
    }
}
