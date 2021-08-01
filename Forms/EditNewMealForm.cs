using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MacroTracker.Forms
{
    public partial class EditNewMealForm : Form
    {
        public Dictionary<string, double> mealMap { get; set; }
        private ListBox suggestBox;
        private List<string> foods;
        private Tuple<string, double> entry;
        private int initialCount;
        public EditNewMealForm(Dictionary<string, double> map, Tuple<string, double> oldEntry)
        {
            InitializeComponent();
            HideArrows();
            entry = oldEntry;
            mealMap = map;
            initialCount = mealMap.Count;
            mealMap.Remove(entry.Item1);
            foods = DatabaseInterface.SelectFoodNames();

            suggestBox = new ListBox();
            suggestBox.Width = foodBox.Width;
            suggestBox.Sorted = true;

            suggestBox.SelectedIndexChanged += suggestBox_SelectedIndexChanged;

            SetUpAutocompleteCollection();

            SetInputs(entry);
            suggestBox.Visible = false;
        }

        private void SetUpAutocompleteCollection()
        {
            AutoCompleteStringCollection foodCollection = new AutoCompleteStringCollection();
            foodCollection.AddRange(foods.ToArray());
            foreach (KeyValuePair<string, double> pair in mealMap)
            {
                if (foodCollection.Contains(pair.Key))
                {
                    foodCollection.Remove(pair.Key);
                }
            }
            foodBox.AutoCompleteCustomSource = foodCollection;
        }

        private void SetInputs(Tuple<string, double> entry)
        {
            foodBox.Text = entry.Item1;
            servingsInput.Value = (decimal) entry.Item2;
        }

        private void HideArrows()
        {
            servingsInput.Controls[0].Visible = false;
        }

        private void suggestBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foodBox.Text = suggestBox.Text;
            suggestBox.Visible = false;
        }

        private void SetUpListBox(bool doubleClicked)
        {
            suggestBox.Font = foodBox.Font;
            suggestBox.Location = new Point(foodBox.Location.X, foodBox.Location.Y + foodBox.Height);

            suggestBox.Items.Clear();
            int height = 0;

            if (doubleClicked)
            {
                foreach (string item in foods)
                {
                    if (!mealMap.ContainsKey(item))
                    {
                        suggestBox.Items.Add(item);
                        height += 40;
                    }
                }
            }
            else
            {
                foreach (string item in foods)
                {
                    if (item.ToLower().StartsWith(foodBox.Text.ToLower()) && foodBox.Text != string.Empty && !mealMap.ContainsKey(item))
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

        private void servingsInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                confirmButton.Focus();
            }
        }

        private void foodBox_TextChanged(object sender, EventArgs e)
        {
            SetUpListBox(false);
        }

        private void foodBox_DoubleClick(object sender, EventArgs e)
        {
            SetUpListBox(true);
        }

        private void foodBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FormatInput();
                suggestBox.Visible = false;
                servingsInput.Focus();
            }
        }

        private void FormatInput()
        {
            string text = foodBox.Text;
            foreach (string food in foods)
            {
                if (text.ToLower() == food.ToLower())
                {
                    foodBox.Text = food;
                    return;
                }
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string foodChoice = foodBox.Text;

            if (foodChoice == "")
            {
                confirmationLabel.Text = "Select a food!";
                return;
            }


            if (!foods.Contains(foodChoice))
            {
                confirmationLabel.Text = "Select a valid food!";
                return;
            }


            if (servingsInput.Value == 0)
            {
                confirmationLabel.Text = "Enter a valid servings amount!";
                return;
            }


            if (mealMap.ContainsKey(foodChoice))
            {
                confirmationLabel.Text = foodChoice + " has already been added!";
                return;
            }

            double servings = (double)Math.Round(servingsInput.Value, 1);
            mealMap.Add(foodChoice, servings);
            Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditNewMealForm_Shown(object sender, EventArgs e)
        {
            title.Select();
        }

        private void EditNewMealForm_Click(object sender, EventArgs e)
        {
            suggestBox.Visible = false;
        }

        private void EditNewMealForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mealMap.Count != initialCount)
            {
                mealMap.Add(entry.Item1, entry.Item2);
            }
        }
    }
}
