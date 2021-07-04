using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MacroTracker.Forms
{
    public partial class SavedFoodsForm : Form
    {
        private List<Food> foods;
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
            if (e.ColumnIndex == savedFoodsView.Columns["RemoveFoodColumn"].Index && e.RowIndex >= 0)
            {
                string name = savedFoodsView.Rows[e.RowIndex].Cells[0].Value.ToString();
                ConfirmDeleteFoodForm form = new ConfirmDeleteFoodForm(name);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    DatabaseInterface.HideFood(name);
                    savedFoodsView.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}
