using System;
using System.Windows.Forms;

namespace MacroTracker.Forms
{
    public partial class SavedFoodsForm : Form
    {
        public SavedFoodsForm()
        {
            InitializeComponent();
            foodsTableAdapter.Fill(macroTrackerDatabaseDataSet.Foods);

            savedFoodsView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            savedFoodsView.RowHeadersVisible = false;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            FormManager.AddForm(FormManager.FormTypes.MenuForm);
            Close();
        }

        private void SavedFoodsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.RemoveForm(this);
        }

        private void SavedFoodsForm_Shown(object sender, EventArgs e)
        {
            savedFoodsView.ClearSelection();
        }
    }
}
