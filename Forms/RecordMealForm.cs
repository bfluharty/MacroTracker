using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MacroTracker.Forms
{
    public partial class RecordMealForm : Form
    {
        public RecordMealForm()
        {
            InitializeComponent();
            datePicker.Value = DateTime.Today;
            foodComboBox.DataSource = DatabaseInterface.SelectFoodNames();
            HideArrows();
            mealTypeBox.SelectedItem = null;
            ResetInputs();

            meal = new Meal();
            map = new Dictionary<Food, double>();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new MenuForm().Show();
            Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (mealTypeBox.SelectedItem == null)
            {
                confirmationLabel.Text = "Select the meal type!";
                return;
            }
            if (foodComboBox.SelectedItem == null)
            {
                confirmationLabel.Text = "Select a food!";
                return;
            }
            if (servingsInput.Value == 0)
            {
                confirmationLabel.Text = "Enter a valid servings amount!";
                return;
            }

            string typeString = mealTypeBox.SelectedItem.ToString();
            char type = (char) typeString.ToCharArray().GetValue(0);

            meal.Type = (Meal.MealTypes) type;
            meal.Date = datePicker.Value;

            string foodChoice = foodComboBox.SelectedItem.ToString();
            double servings = (double)Math.Round(servingsInput.Value, 1);

            //Food food = DatabaseInterface.SelectFood(foodChoice);
            map.Add(foodChoice, servings);

            confirmationLabel.Text = foodChoice + " (" + servings + " serving[s]) has been added.";
            nextButton.Enabled = true;
            ResetInputs();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
           // new ReviewNewMealForm(meal, map).Show();
            Hide();
        }

        private void ResetInputs()
        {
            foodComboBox.SelectedItem = null;
            servingsInput.ResetText();
        }

        private void HideArrows()
        {
            servingsInput.Controls[0].Visible = false;
        }

        private void RecordMealForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private Dictionary<string, double> map;
        private Meal meal;
    }
}
