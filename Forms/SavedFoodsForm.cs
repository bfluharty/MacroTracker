using System;
using System.Windows.Forms;

namespace MacroTracker.Forms
{
    public partial class SavedFoodsForm : Form
    {
        public SavedFoodsForm()
        {
            InitializeComponent();

            this.foodsTableAdapter.Fill(this.macroTrackerDataSet.Foods);
            savedFoodsView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            savedFoodsView.RowHeadersVisible = false;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            new MenuForm().Show();
            Hide();
        }

        private void SavedFoodsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SavedFoodsForm_Shown(object sender, EventArgs e)
        {
            savedFoodsView.ClearSelection();
        }
    }
}
