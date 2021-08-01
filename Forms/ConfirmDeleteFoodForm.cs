using System.Windows.Forms;

namespace MacroTracker.Forms
{
    public partial class ConfirmDeleteFoodForm : Form
    {
        public ConfirmDeleteFoodForm(string name)
        {
            InitializeComponent();
            foodNameLabel.Text = name + "?";
        }

        private void backButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void confirmButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ConfirmDeleteFoodForm_Shown(object sender, System.EventArgs e)
        {
            title.Select();
        }
    }
}
