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
            ResetInputs();
            HideArrows();

            map = new MealFoodMap();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new MenuForm().Show();
            Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //Add to list
            if (mealTypeBox.SelectedItem == null)
            {
                confirmationLabel.Text = "Select the meal type!";
                return;
            }
            if (servingsInput.Value == 0)
            {
                confirmationLabel.Text = "Enter a valid servings amount!";
                return;
            }

            //confirmationLabel.Text =  has been added.";
            nextButton.Enabled = true;
            ResetInputs();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            //GOTO review meal addition
        }

        private void ResetInputs()
        {
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
