using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace MacroTracker.Forms
{
    public partial class SavedFoodsForm : Form
    {
        private bool ascending = true;

        public SavedFoodsForm()
        {
            InitializeComponent();
            FillTable();
            savedFoodsView.RowHeadersVisible = false;
        }

        private void FillTable()
        {
            List<Food> foods = DatabaseInterface.SelectVisibleFoods();

            foreach (Food food in foods)
            {
                savedFoodsView.Rows.Add(food.Name, food.Calories, food.Fat, food.Carbs, food.Protein);
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            FormManager.AddForm(FormManager.FormTypes.MenuForm);
            Close();
        }

        private void SavedFoodsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.RemoveForm(this);
        }

        private void SavedFoodsForm_Shown(object sender, EventArgs e)
        {
            savedFoodsView.ClearSelection();
        }

        private void savedFoodsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (savedFoodsView.RowCount > 0)
            {
                // Sort column
                if (e.RowIndex == -1 && e.ColumnIndex != savedFoodsView.ColumnCount - 1)
                {
                    ResetHeaders();
                    HandleSort(savedFoodsView.Columns[e.ColumnIndex]);
                }
                // Edit entry
                else if (e.ColumnIndex == savedFoodsView.ColumnCount - 2 && e.RowIndex >= 0)
                {
                    DataGridViewCellCollection group = savedFoodsView.Rows[e.RowIndex].Cells;
                    string name = group[0].Value.ToString();
                    int foodID = DatabaseInterface.SelectFoodID(name);

                    EditSavedFoodForm form = new EditSavedFoodForm(foodID, new Food(name, int.Parse(group[1].Value.ToString()), double.Parse(group[2].Value.ToString()), double.Parse(group[3].Value.ToString()), double.Parse(group[4].Value.ToString())));
                    form.ShowDialog();
                    savedFoodsView.Rows.Clear();
                    FillTable();
                }
                // Remove entry
                else if (e.ColumnIndex == savedFoodsView.ColumnCount - 1 && e.RowIndex >= 0)
                {
                    string name = savedFoodsView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    ConfirmDeleteFoodForm form = new ConfirmDeleteFoodForm(name);

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        DatabaseInterface.HideFood(name);
                        savedFoodsView.Rows.RemoveAt(e.RowIndex);
                        ResetHeaders();
                    }
                }
                savedFoodsView.ClearSelection();
            }
        }

        private void HandleSort(DataGridViewColumn column)
        {
            if (ascending)
            {
                savedFoodsView.Sort(column, ListSortDirection.Descending);
                column.HeaderText += " \\/";
                ascending = false;
            }
            else
            {
                savedFoodsView.Sort(column, ListSortDirection.Ascending);
                column.HeaderText += " /\\";
                ascending = true;
            }
        }

        private void ResetHeaders()
        {
            DataGridViewColumnCollection columns = savedFoodsView.Columns;
            List<string> headerNames = new List<string>() { "Name", "Calories", "Fat", "Carbs", "Protein" };

            for (int i = 0; i < columns.Count - 2; i++)
            {
               columns[i].HeaderText = headerNames[i];
            }
        }
    }
}
