using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace MacroTracker.Forms
{
    public partial class SavedFoodsForm : Form
    {
        private List<Food> foods;
        private bool ascending = true;

        public SavedFoodsForm()
        {
            InitializeComponent();
            foods = DatabaseInterface.SelectVisibleFoods();

            foreach (Food food in foods)
            {
                savedFoodsView.Rows.Add(food.Name, food.Calories, food.Fat, food.Carbs, food.Protein);
            }            
            savedFoodsView.RowHeadersVisible = false;
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
                if (e.RowIndex == -1 && e.ColumnIndex != savedFoodsView.ColumnCount - 1)
                {
                    ResetHeaders();
                    HandleSort(savedFoodsView.Columns[e.ColumnIndex]);
                }
                else if (e.ColumnIndex == savedFoodsView.Columns["RemoveFoodColumn"].Index && e.RowIndex >= 0)
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

            for (int i = 0; i < columns.Count - 1; i++)
            {
               columns[i].HeaderText = headerNames[i];
            }
        }
    }
}
