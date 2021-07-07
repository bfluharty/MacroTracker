using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MacroTracker.Forms
{
    public partial class AddNewFoodForm : Form
    {
        private List<Food> addedFoods { get; set; }

        public AddNewFoodForm()
        {
            InitializeComponent();
            HideArrows();
            ResetInputs();

            addedFoods = new List<Food>();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            FormManager.AddForm(FormManager.FormTypes.MenuForm);
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;

            if (name.Equals(""))
            {
                confirmationLabel.Text = "Enter a name for the food!";
                return;
            }

            if (DatabaseInterface.SelectFoodNames().Contains(name))
            {
                confirmationLabel.Text = name + " has already been added!";
                return;
            }

            addedFoods.Add(new Food(name, (int)caloriesInput.Value, (double) Math.Round(fatInput.Value, 1), (double) Math.Round(carbsInput.Value, 1), (double) Math.Round(proteinInput.Value, 1)));
            confirmationLabel.Text = name + " has been added.";
            nextButton.Enabled = true;
            ResetInputs();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            FormManager.AddForm(FormManager.FormTypes.ReviewNewFoodForm, foods: addedFoods);
            Close();
        }

        private void ResetInputs()
        {
            nameInput.ResetText();
            caloriesInput.ResetText();
            fatInput.ResetText();
            carbsInput.ResetText();
            proteinInput.ResetText();
        }

        private void HideArrows()
        {
            caloriesInput.Controls[0].Visible = false;
            fatInput.Controls[0].Visible = false;
            carbsInput.Controls[0].Visible = false;
            proteinInput.Controls[0].Visible = false;
        }

        private void AddNewFoodForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.RemoveForm(this);
        }

        private void AddNewFoodForm_Shown(object sender, EventArgs e)
        {
            title.Select();
        }
    }
}
