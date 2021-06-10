using System;
using System.Windows.Forms;

namespace MacroTracker.Forms
{
    public partial class RecordMealForm : Form
    {
        public RecordMealForm()
        {
            InitializeComponent();
        }

        private void RecordMealForm_Load(object sender, EventArgs e)
        {
            datePicker.Value = DateTime.Today;
            ResetInputs();
            HideArrows();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new MenuForm().Show();
            Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //Add to list
            
            if (mealTypeBox.SelectedValue == null)
            {
                confirmationLabel.Text = "Select the meal type!";
            }
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
    }
}
