using System;
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

            map = new MealFoodMap();
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

            string foodChoice = foodComboBox.SelectedItem.ToString();
            double servings = (double)Math.Round(servingsInput.Value, 1);

            Food food = DatabaseInterface.SelectFood(foodChoice);
            map.AddFood(food, servings);

            confirmationLabel.Text = foodChoice + " (" + servings + " serving[s]) has been added.";
            nextButton.Enabled = true;
            ResetInputs();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            //new ReviewNewFoodForm(map).Show();
            //Hide();
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

        private MealFoodMap map;
    }
}
