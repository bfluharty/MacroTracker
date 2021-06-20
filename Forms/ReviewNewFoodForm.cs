using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MacroTracker.Forms
{
    public partial class ReviewNewFoodForm : Form
    {
        private List<Food> foods;

        public ReviewNewFoodForm(List<Food> addedFoods)
        {
            InitializeComponent();
            foods = addedFoods;

            foodsToAddGrid.DataSource = foods;
            foodsToAddGrid.RowHeadersVisible = false;
            foodsToAddGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
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
    }
}
