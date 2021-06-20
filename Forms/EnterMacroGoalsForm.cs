using System;
using System.Windows.Forms;

namespace MacroTracker.Forms
{
    public partial class EnterMacroGoalsForm : Form
    {
        public EnterMacroGoalsForm()
        {
            InitializeComponent();

            if (Properties.Settings.Default.setGoal)
            {
                menuButton.Enabled = true;
            }

            caloriesInput.Value = Properties.Settings.Default.calorieGoal;
            fatInput.Value = (decimal)Properties.Settings.Default.fatGoal;
            carbsInput.Value = (decimal)Properties.Settings.Default.carbGoal;
            proteinInput.Value = (decimal)Properties.Settings.Default.proteinGoal;

            HideArrows();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.calorieGoal = (int) caloriesInput.Value;
            Properties.Settings.Default.fatGoal = (double)Math.Round(fatInput.Value, 1);
            Properties.Settings.Default.carbGoal = (double)Math.Round(carbsInput.Value, 1);
            Properties.Settings.Default.proteinGoal = (double)Math.Round(proteinInput.Value, 1);
            Properties.Settings.Default.setGoal = true;

            Properties.Settings.Default.Save();

            FormManager.AddForm(FormManager.FormTypes.MenuForm);
            Close();
        }

        private void HideArrows()
        {
            caloriesInput.Controls[0].Visible = false;
            fatInput.Controls[0].Visible = false;
            carbsInput.Controls[0].Visible = false;
            proteinInput.Controls[0].Visible = false;
        }

        private void EnterMacroGoalsForm_Shown(object sender, EventArgs e)
        {
            title.Select();
        }

        private void EnterMacroGoalsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.RemoveForm(this);
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            FormManager.AddForm(FormManager.FormTypes.MenuForm);
            Close();
        }
    }
}
