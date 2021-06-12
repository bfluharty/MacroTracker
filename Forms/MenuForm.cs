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
            new AddNewFoodForm().Show();
            Hide();
        }

        private void recordMealButton_Click(object sender, EventArgs e)
        {
            new AddNewMealForm().Show();
            Hide();
        }

        private void viewRecordsButton_Click(object sender, EventArgs e)
        {
            //Form for viewing records of meals
        }

        private void viewFoodsButton_Click(object sender, EventArgs e)
        {
            new SavedFoodsForm().Show();
            Hide();
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MenuForm_Shown(object sender, EventArgs e)
        {
            title.Select();
        }
    }
}
