using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MacroTracker.Forms
{
    public partial class AddNewMealForm : Form
    {
        public AddNewMealForm()
        {
            InitializeComponent();
            datePicker.Value = DateTime.Today;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new MenuForm().Show();
            Hide();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (mealTypeBox.SelectedItem == null)
            {
                confirmationLabel.Text = "Select the meal type!";
                return;
            }

            string typeString = mealTypeBox.SelectedItem.ToString();
            char type = (char)typeString.ToCharArray().GetValue(0);

            Meal meal = new Meal(type, datePicker.Value);
            Tuple<string, string> mealPair = new Tuple<string, string>(((char) type).ToString(), datePicker.Value.ToShortDateString());

            if (DatabaseInterface.SelectMeals().Contains(mealPair))
            {
                confirmationLabel.Text = meal + " has already been added!";
                return;
            }
            
            new RecordMealForm(meal).Show();
            Hide();
        }

        private void RecordMealForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AddNewMealForm_Shown(object sender, EventArgs e)
        {
            title.Select();
        }
    }
}
