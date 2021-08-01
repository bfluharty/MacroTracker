using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MacroTracker.Forms
{
    public partial class EditNewFoodForm : Form
    {
        private Food food;
        public List<Food> foodsToAdd { get; set; }
        public EditNewFoodForm(Food currentFood, List<Food> foods)
        {
            InitializeComponent();
            HideArrows();
            food = currentFood;
            SetInputs(food);
            foodsToAdd = foods;

            int index = foodsToAdd.FindIndex(x => x.Name.Equals(food.Name));
            foodsToAdd.RemoveAt(index);
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;

            if (name.Equals(""))
            {
                confirmationLabel.Text = "Enter a name for the food!";
                return;
            }

            if (foodsToAdd.Contains(food) || DatabaseInterface.SelectVisibleFoods().Contains(food))
            {
                confirmationLabel.Text = name + " has already been added!"; 
                return;
            }

            food = new Food(name, (int)caloriesInput.Value, (double)Math.Round(fatInput.Value, 1), (double)Math.Round(carbsInput.Value, 1), (double)Math.Round(proteinInput.Value, 1));
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

        private void EditNewFoodForm_Shown(object sender, EventArgs e)
        {
            title.Select();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditNewFoodForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            foodsToAdd.Add(food);
        }
    }
}
