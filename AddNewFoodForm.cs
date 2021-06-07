﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroTracker
{
    public partial class AddNewFoodForm : Form
    {
        public AddNewFoodForm()
        {
            InitializeComponent();
            HideArrows();
            addedFoods = new List<Food>();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new MenuForm().Show();
            Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;

            if (name.Equals(""))
            {
                nameInput.Text = "Name Required!";
                return;
            }

            List<string> takenNames = DatabaseInterface.SelectFoodNames();

            if (takenNames.Contains(name))
            {
                confirmationLabel.Text = name + " has already been added!";
                return;
            }

            addedFoods.Add(new Food(name, (int)caloriesInput.Value, (double) Math.Round(fatInput.Value, 1), (double) Math.Round(carbsInput.Value, 1), (double) Math.Round(proteinInput.Value, 1)));
            confirmationLabel.Text = name + " has been added.";
            nextButton.Enabled = true;
            ResetInputs();
        }

        private void ResetInputs()
        {
            nameInput.ResetText();
            caloriesInput.ResetText();
            fatInput.ResetText();
            carbsInput.ResetText();
            proteinInput.ResetText();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            new ReviewNewFoodForm(addedFoods).Show();
            Hide();
        }

        private void HideArrows()
        {
            caloriesInput.Controls[0].Visible = false;
            fatInput.Controls[0].Visible = false;
            carbsInput.Controls[0].Visible = false;
            proteinInput.Controls[0].Visible = false;
        }

        private List<Food> addedFoods { get; set; }

        private void AddNewFoodForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AddNewFoodForm_Load(object sender, EventArgs e)
        {
            title.Select();
            ResetInputs();
        }
    }
}
