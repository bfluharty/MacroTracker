using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MacroTracker.Forms
{
    public partial class RecordMealForm : Form
    {
        private Dictionary<string, double> map;
        private Meal meal;

        public RecordMealForm(Meal savedMeal)
        {
            InitializeComponent();
            foodComboBox.DataSource = DatabaseInterface.SelectFoodNames();
            HideArrows();
            ResetInputs();

            meal = savedMeal;
            map = new Dictionary<string, double>();

            mealLabel.Text = meal.ToString();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            FormManager.AddForm(FormManager.FormTypes.AddNewMealForm);
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
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

            string foodChoice = foodComboBox.SelectedItem.ToString();
            
            if (map.ContainsKey(foodChoice))
            {
                confirmationLabel.Text = foodChoice + " has already been added!";
                return;
            }

            double servings = (double)Math.Round(servingsInput.Value, 1);

            map.Add(foodChoice, servings);

            confirmationLabel.Text = foodChoice + " (" + servings + " serving[s]) has been added.";
            nextButton.Enabled = true;
            ResetInputs();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            FormManager.AddForm(FormManager.FormTypes.ReviewNewMealForm, meal: meal, map: map);
            Close();
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
            FormManager.RemoveForm(this);
        }

        private void RecordMealForm_Shown(object sender, EventArgs e)
        {
            title.Select();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            FormManager.AddForm(FormManager.FormTypes.MenuForm);
            Close();
        }
    }
}
