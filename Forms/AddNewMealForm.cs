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
        }

        public AddNewMealForm(Meal meal)
        {
            InitializeComponent();
            mealTypeBox.SelectedItem = meal.Type.ToString();
            datePicker.Value = meal.Date;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            FormManager.AddForm(FormManager.FormTypes.MenuForm);
            Close();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (mealTypeBox.SelectedItem == null)
            {
                confirmationLabel.Text = "Select the meal type!";
                return;
            }

            string typeString = mealTypeBox.SelectedItem.ToString();
            char type = Meal.GetCharMealType(typeString);

            Meal meal = new Meal(type, datePicker.Value);
            Tuple<string, string> mealPair = new Tuple<string, string>(meal.GetStringMealType(), datePicker.Value.ToShortDateString());

            if (DatabaseInterface.SelectMeals().Contains(mealPair))
            {
                confirmationLabel.Text = meal + " has already been added!";
                return;
            }
            FormManager.AddForm(FormManager.FormTypes.RecordMealForm, meal);
            Close();
        }

        private void RecordMealForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.RemoveForm(this);
        }

        private void AddNewMealForm_Shown(object sender, EventArgs e)
        {
            title.Select();
        }
    }
}
