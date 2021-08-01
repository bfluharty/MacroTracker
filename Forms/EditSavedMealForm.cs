using System;
using System.Windows.Forms;

namespace MacroTracker.Forms
{
    public partial class EditSavedMealForm : Form
    {
        private Tuple<string, double> entry { get; set; }
        private Meal meal;
        public EditSavedMealForm(Meal providedMeal, Tuple<string, double> item)
        {
            InitializeComponent();
            servingsInput.Controls[0].Visible = false;
            meal = providedMeal;
            entry = item;
            SetInputs(entry);
        }

        private void SetInputs(Tuple<string, double> entry)
        {
            foodBox.Text = entry.Item1;
            servingsInput.Value = (decimal) entry.Item2;
        }

        private void servingsInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                confirmButton.Focus();
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (servingsInput.Value == 0)
            {
                confirmationLabel.Text = "Enter a valid servings amount!";
                return;
            }

            double servings = (double)Math.Round(servingsInput.Value, 1);
            DatabaseInterface.EditMeal(meal, new Tuple<string, double>(entry.Item1, servings));
            Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditNewMealForm_Shown(object sender, EventArgs e)
        {
            title.Select();
        }
    }
}
