using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroTracker
{
    public partial class SavedFoodsForm : Form
    {
        public SavedFoodsForm()
        {
            InitializeComponent();
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

        private void SavedFoodsForm_Load(object sender, EventArgs e)
        {
            this.foodsTableAdapter.Fill(this.macroTrackerDataSet.Foods);
            savedFoodsView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            savedFoodsView.RowHeadersVisible = false;
            savedFoodsView.ClearSelection();
        }
    }
}
