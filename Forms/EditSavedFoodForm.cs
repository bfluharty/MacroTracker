using System;
using System.Windows.Forms;

namespace MacroTracker.Forms
{
    public partial class EditSavedFoodForm : Form
    {
        private int foodID;
        public EditSavedFoodForm(int foodID, Food food)
        {
            InitializeComponent();
            HideArrows();
            SetInputs(food);
            this.foodID = foodID;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;

            if (name.Equals(""))
            {
                confirmationLabel.Text = "Enter a name for the food!";
                return;
            }

            DatabaseInterface.EditFood(foodID, new Food(name, (int)caloriesInput.Value, (double)Math.Round(fatInput.Value, 1), (double)Math.Round(carbsInput.Value, 1), (double)Math.Round(proteinInput.Value, 1)));
            Close();
        }

        private void SetInputs(Food food)
        {
            nameInput.Text = food.Name;
            caloriesInput.Text = food.Calories.ToString();
            fatInput.Text = food.Fat.ToString();
            carbsInput.Text = food.Carbs.ToString();
            proteinInput.Text = food.Protein.ToString();
        }

        private void HideArrows()
        {
            caloriesInput.Controls[0].Visible = false;
            fatInput.Controls[0].Visible = false;
            carbsInput.Controls[0].Visible = false;
            proteinInput.Controls[0].Visible = false;
        }

        private void EditSavedFoodForm_Shown(object sender, EventArgs e)
        {
            title.Select();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
