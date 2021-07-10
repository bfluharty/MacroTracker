using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MacroTracker.Forms
{
    public partial class RecordMealForm : Form
    {
        private Dictionary<string, double> map;
        private Meal meal;
        private ListBox suggestBox;

        public RecordMealForm(Meal savedMeal)
        {
            InitializeComponent();
            foodComboBox.DataSource = DatabaseInterface.SelectFoodNames();
            HideArrows();
            ResetInputs();

            meal = savedMeal;
            map = new Dictionary<string, double>();
            suggestBox = new ListBox();
            suggestBox.Width = foodComboBox.Width;
            suggestBox.SelectedIndexChanged += suggestBox_SelectedIndexChanged;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            FormManager.AddForm(FormManager.FormTypes.AddNewMealForm);
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (foodComboBox.SelectedItem == null)
            {
                confirmationLabel.Text = "Select a food!";
                return;
            }
            if (servingsInput.Value == 0)
            {
                confirmationLabel.Text = "Enter a valid servings amount!";
                return;
            }

            string foodChoice = foodComboBox.SelectedItem.ToString();

            if (map.ContainsKey(foodChoice))
            {
                confirmationLabel.Text = foodChoice + " has already been added!";
                return;
            }

            double servings = (double)Math.Round(servingsInput.Value, 1);

            map.Add(foodChoice, servings);

            confirmationLabel.Text = foodChoice + " (" + servings + " serving[s]) has been added.";
            nextButton.Enabled = true;
            ResetInputs();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            FormManager.AddForm(FormManager.FormTypes.ReviewNewMealForm, meal: meal, map: map);
            Close();
        }

        private void ResetInputs()
        {
            foodComboBox.SelectedItem = null;
            servingsInput.Value = 0;
            servingsInput.ResetText();
        }

        private void HideArrows()
        {
            servingsInput.Controls[0].Visible = false;
        }

        private void RecordMealForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.RemoveForm(this);
        }

        private void RecordMealForm_Shown(object sender, EventArgs e)
        {
            title.Select();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            FormManager.AddForm(FormManager.FormTypes.MenuForm);
            Close();
        }

        private void suggestBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foodComboBox.Text = suggestBox.Text;
            suggestBox.Visible = false;
        }

        private void SetUpListBox(bool doubleClicked)
        {
            suggestBox.Font = foodComboBox.Font;
            suggestBox.Location = new Point(foodComboBox.Location.X, foodComboBox.Location.Y + foodComboBox.Height);

            suggestBox.Items.Clear();
            int height = 0;

            if (doubleClicked)
            {
                foreach (string item in foodComboBox.Items)
                {
                    suggestBox.Items.Add(item);
                    height += 40;
                }
            }
            else
            {
                foreach (string item in foodComboBox.Items)
                {
                    if (item.StartsWith(foodComboBox.Text) && foodComboBox.Text != string.Empty)
                    {
                        suggestBox.Items.Add(item);
                        height += 40;
                    }
                }
            }

            suggestBox.Height = height > 160 ? 160 : height;

            suggestBox.Visible = suggestBox.Items.Count > 0;
            Controls.Add(suggestBox);
        }

        private void foodComboBox_TextUpdate(object sender, EventArgs e)
        {
            SetUpListBox(false);
        }

        private void RecordMealForm_Click(object sender, EventArgs e)
        {
            suggestBox.Visible = false;
        }

        private void foodComboBox_Click(object sender, EventArgs e)
        {
            SetUpListBox(true);
        }

        private void foodComboBox_Leave(object sender, EventArgs e)
        {
            suggestBox.Visible = false;
        }

        private void foodComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                servingsInput.Focus();
            }
        }

        private void servingsInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addButton.Focus();
            }
        }
    }
}
