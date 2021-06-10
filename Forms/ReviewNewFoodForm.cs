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
            foodsToAddGrid.ClearSelection();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new AddNewFoodForm().Show();
            Hide();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            new MenuForm().Show();
            Hide();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            DatabaseInterface.InsertFoods(foods);

            new MenuForm().Show();
            Hide();
        }

        private void foodsToAddGrid_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void ReviewNewFoodForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
