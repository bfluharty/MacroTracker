using System;
using System.Windows.Forms;

namespace MacroTracker.Forms
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void addFoodButton_Click(object sender, EventArgs e)
        {
            FormManager.AddForm(FormManager.FormTypes.AddNewFoodForm);
            Close();
        }

        private void recordMealButton_Click(object sender, EventArgs e)
        {
            FormManager.AddForm(FormManager.FormTypes.AddNewMealForm);
            Close();
        }

        private void viewRecordsButton_Click(object sender, EventArgs e)
        {
            FormManager.AddForm(FormManager.FormTypes.DailyTotalsForm);
            Close();
        }

        private void viewFoodsButton_Click(object sender, EventArgs e)
        {
            FormManager.AddForm(FormManager.FormTypes.SavedFoodsForm);
            Close();
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.RemoveForm(this);
        }

        private void MenuForm_Shown(object sender, EventArgs e)
        {
            title.Select();
        }
    }
}
