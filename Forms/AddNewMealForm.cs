using System;
using System.Windows.Forms;

namespace MacroTracker.Forms
{
    public partial class AddNewMealForm : Form
    {
        public AddNewMealForm()
        {
            InitializeComponent();
            datePicker.Value = DateTime.Today;
            mealTypeBox.SelectedItem = null;
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

            new RecordMealForm(new Meal(type, datePicker.Value)).Show();
            Hide();
        }

        private void RecordMealForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
