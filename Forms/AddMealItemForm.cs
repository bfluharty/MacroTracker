using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MacroTracker.Forms
{
    public partial class AddMealItemForm : Form
    {
        private Dictionary<string, double> map;
        private Dictionary<string, double> newMap;

        private Meal meal;
        private ListBox suggestBox;
        private List<string> foods;

        public AddMealItemForm(Meal savedMeal, Dictionary<string, double> map)
        {
            InitializeComponent();
            HideArrows();
            ResetInputs();

            meal = savedMeal;
            this.map = map;
            newMap = new Dictionary<string, double>();
            foods = DatabaseInterface.SelectFoodNames();

            suggestBox = new ListBox();
            suggestBox.Width = foodBox.Width;
            suggestBox.Sorted = true;

            suggestBox.SelectedIndexChanged += suggestBox_SelectedIndexChanged;
            SetUpAutocompleteCollection();
        }

        private void SetUpAutocompleteCollection()
        {
            AutoCompleteStringCollection foodCollection = new AutoCompleteStringCollection();
            foodCollection.AddRange(foods.ToArray());
            foreach (KeyValuePair<string, double> pair in map)
            {
                if (foodCollection.Contains(pair.Key))
                {
                    foodCollection.Remove(pair.Key);
                }
            }
            foodBox.AutoCompleteCustomSource = foodCollection;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
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


            if (map.ContainsKey(foodChoice))
            {
                confirmationLabel.Text = foodChoice + " has already been added!";
                return;
            }

            double servings = (double)Math.Round(servingsInput.Value, 1);

            map.Add(foodChoice, servings);
            newMap.Add(foodChoice, servings);

            confirmationLabel.Text = foodChoice + " (" + servings + " serving[s]) has been added.";
            nextButton.Enabled = true;
            ResetInputs();
            SetUpAutocompleteCollection();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (!DatabaseInterface.MealExists(meal))
            {
                DatabaseInterface.InsertMeal(meal);
            }
            DatabaseInterface.InsertMealMap(meal, newMap);
            Close();
        }

        private void ResetInputs()
        {
            servingsInput.Value = 0;
            servingsInput.ResetText();
        }

        private void HideArrows()
        {
            servingsInput.Controls[0].Visible = false;
        }

        private void RecordMealForm_Shown(object sender, EventArgs e)
        {
            title.Select();
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
                    if (!map.ContainsKey(item))
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
                    if (item.ToLower().StartsWith(foodBox.Text.ToLower()) && foodBox.Text != string.Empty && !map.ContainsKey(item))
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

        private void RecordMealForm_Click(object sender, EventArgs e)
        {
            suggestBox.Visible = false;
        }

        private void servingsInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addButton.Focus();
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
    }
}
