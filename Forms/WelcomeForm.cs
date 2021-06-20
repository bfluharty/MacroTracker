using System;
using System.Windows.Forms;

namespace MacroTracker.Forms
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void getStartedButton_Click(object sender, EventArgs e)
        {
            FormManager.AddForm(FormManager.FormTypes.EnterMacroGoalsForm);
            Close();
        }

        private void WelcomeForm_Shown(object sender, EventArgs e)
        {
            title.Select();
        }

        private void WelcomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.RemoveForm(this);
        }
    }
}
