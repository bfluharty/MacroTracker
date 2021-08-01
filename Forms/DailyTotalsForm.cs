using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace MacroTracker.Forms
{
    public partial class DailyTotalsForm : Form
    {
        private List<Tuple<int, double>> breakfastFoods = new List<Tuple<int, double>>();
        private List<Tuple<int, double>> lunchFoods = new List<Tuple<int, double>>();
        private List<Tuple<int, double>> dinnerFoods = new List<Tuple<int, double>>();
        private List<Tuple<int, double>> snackFoods = new List<Tuple<int, double>>();
        private Food breakfast = new Food();
        private Food lunch = new Food();
        private Food dinner = new Food();
        private Food snack = new Food();
        private Food total = new Food();

        public DailyTotalsForm()
        {
            InitializeComponent();
            datePicker.Value = DateTime.Today;

            breakfast = DatabaseInterface.SelectMealTotal('B', datePicker.Value);
            lunch = DatabaseInterface.SelectMealTotal('L', datePicker.Value);
            dinner = DatabaseInterface.SelectMealTotal('D', datePicker.Value);
            snack = DatabaseInterface.SelectMealTotal('S', datePicker.Value);
            total = DatabaseInterface.SelectDailyTotal(datePicker.Value);

            LoadMeals();
            UpdateTotals();
        }

        private void LoadMeals()
        {
            breakfastFoods = DatabaseInterface.SelectMealFoods(new Meal('B', datePicker.Value));
            lunchFoods = DatabaseInterface.SelectMealFoods(new Meal('L', datePicker.Value));
            dinnerFoods = DatabaseInterface.SelectMealFoods(new Meal('D', datePicker.Value));
            snackFoods = DatabaseInterface.SelectMealFoods(new Meal('S', datePicker.Value));
        }

        private void FillTables()
        {
            ClearRows();

            foreach (Tuple<int, double> entry in breakfastFoods)
            {
                breakfastFoodsView.Rows.Add(DatabaseInterface.SelectFoodName(entry.Item1) + " (" + entry.Item2 + ")");
                breakfastFoodsView.ClearSelection();
            }

            foreach (Tuple<int, double> entry in lunchFoods)
            {
                lunchFoodsView.Rows.Add(DatabaseInterface.SelectFoodName(entry.Item1) + " (" + entry.Item2 + ")");
                lunchFoodsView.ClearSelection();
            }

            foreach (Tuple<int, double> entry in dinnerFoods)
            {
                dinnerFoodsView.Rows.Add(DatabaseInterface.SelectFoodName(entry.Item1) + " (" + entry.Item2 + ")");
                dinnerFoodsView.ClearSelection();
            }

            foreach (Tuple<int, double> entry in snackFoods)
            {
                snackFoodsView.Rows.Add(DatabaseInterface.SelectFoodName(entry.Item1) + " (" + entry.Item2 + ")");
                snackFoodsView.ClearSelection();
            }
        }

        private void ClearRows()
        {
            breakfastFoodsView.Rows.Clear();
            lunchFoodsView.Rows.Clear();
            dinnerFoodsView.Rows.Clear();
            snackFoodsView.Rows.Clear();
        }

        private void UpdateTotals()
        {
            breakfastCaloriesValue.Text = breakfast.Calories.ToString();
            breakfastFatValue.Text = breakfast.Fat.ToString() + " g";
            breakfastCarbsValue.Text = breakfast.Carbs.ToString() + " g";
            breakfastProteinValue.Text = breakfast.Protein.ToString() + " g";

            lunchCaloriesValue.Text = lunch.Calories.ToString();
            lunchFatValue.Text = lunch.Fat.ToString() + " g";
            lunchCarbsValue.Text = lunch.Carbs.ToString() + " g";
            lunchProteinValue.Text = lunch.Protein.ToString() + " g";

            dinnerCaloriesValue.Text = dinner.Calories.ToString();
            dinnerFatValue.Text = dinner.Fat.ToString() + " g";
            dinnerCarbsValue.Text = dinner.Carbs.ToString() + " g";
            dinnerProteinValue.Text = dinner.Protein.ToString() + " g";

            snackCaloriesValue.Text = snack.Calories.ToString();
            snackFatValue.Text = snack.Fat.ToString() + " g";
            snackCarbsValue.Text = snack.Carbs.ToString() + " g";
            snackProteinValue.Text = snack.Protein.ToString() + " g";

            string calories = total.Calories.ToString();
            caloriesValue.Text = calories;
            SetTextColor(caloriesValue, MeetCalorieGoal(calories));

            string fat = total.Fat.ToString();
            fatValue.Text = fat + " g";
            SetTextColor(fatValue, MeetFatGoal(fat));

            string carbs = total.Carbs.ToString();
            carbsValue.Text = carbs + " g";
            SetTextColor(carbsValue, MeetCarbGoal(carbs));

            string protein = total.Protein.ToString();
            proteinValue.Text = protein + " g";
            SetTextColor(proteinValue, MeetProteinGoal(protein));
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            FormManager.AddForm(FormManager.FormTypes.MenuForm);
            Close();
        }

        private void DailyTotalsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.RemoveForm(this);
        }

        private void DailyTotalsForm_Shown(object sender, EventArgs e)
        {
            ClearRows();
            FillTables();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            breakfast = DatabaseInterface.SelectMealTotal('B', datePicker.Value);
            lunch = DatabaseInterface.SelectMealTotal('L', datePicker.Value);
            dinner = DatabaseInterface.SelectMealTotal('D', datePicker.Value);
            snack = DatabaseInterface.SelectMealTotal('S', datePicker.Value);
            total = DatabaseInterface.SelectDailyTotal(datePicker.Value);

            LoadMeals();
            FillTables();
            UpdateTotals();
        }

        private void ResetMeal(string meal)
        {
            if (meal == "Breakfast")
            {
                breakfast = DatabaseInterface.SelectMealTotal('B', datePicker.Value);
                breakfastFoodsView.ClearSelection();
            }
            else if (meal == "Lunch")
            {
                lunch = DatabaseInterface.SelectMealTotal('L', datePicker.Value);
                lunchFoodsView.ClearSelection();
            }
            else if (meal == "Dinner")
            {
                dinner = DatabaseInterface.SelectMealTotal('D', datePicker.Value);
                dinnerFoodsView.ClearSelection();
            }
            else if (meal == "Snack")
            {
                snack = DatabaseInterface.SelectMealTotal('S', datePicker.Value);
                snackFoodsView.ClearSelection();
            }
            total = DatabaseInterface.SelectDailyTotal(datePicker.Value);
            UpdateTotals();
        }

        private void SetTextColor(Label text, bool met)
        {
            if (met)
            {
                text.ForeColor = Color.Green;
            }
            else
            {
                text.ForeColor = Color.Red;
            }

        }

        private bool MeetCalorieGoal(String calories)
        {
            return int.Parse(calories) <= Properties.Settings.Default.calorieGoal;
        }

        private bool MeetFatGoal(String fat)
        {
            return double.Parse(fat) <= Properties.Settings.Default.fatGoal;
        }

        private bool MeetCarbGoal(String carbs)
        {
            return double.Parse(carbs) <= Properties.Settings.Default.carbGoal;
        }

        private bool MeetProteinGoal(String protein)
        {
            return double.Parse(protein) >= Properties.Settings.Default.proteinGoal;
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            datePicker.Value = datePicker.Value.AddDays(-1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datePicker.Value = datePicker.Value.AddDays(1);
        }

        private void breakfastFoodsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (breakfastFoodsView.RowCount > 0)
            {
                // Edit entry
                if (e.ColumnIndex == breakfastFoodsView.ColumnCount - 2 && e.RowIndex >= 0)
                {
                    string entry = breakfastFoodsView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string name = entry.Substring(0, entry.LastIndexOf(" "));

                    int left = entry.LastIndexOf('(') + 1;
                    int end = entry.Length - left - 1;

                    string serving = entry.Substring(left, end);
                    double servingsNum = double.Parse(serving);

                    EditSavedMealForm form = new EditSavedMealForm(new Meal('B', datePicker.Value), new Tuple<string, double>(name, servingsNum));
                    form.ShowDialog();
                    ResetMeal(breakfastFoodsView.Columns[0].HeaderText);
                    LoadMeals();
                    FillTables();
                }
                // Remove entry
                else if (e.ColumnIndex == breakfastFoodsView.ColumnCount - 1 && e.RowIndex >= 0)
                {
                    string entry = breakfastFoodsView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    ConfirmDeleteFoodForm form = new ConfirmDeleteFoodForm(entry);

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        string name = entry.Substring(0, entry.LastIndexOf(" "));
                        DatabaseInterface.DeleteEntry(new Meal('B', datePicker.Value), name);
                        breakfastFoodsView.Rows.RemoveAt(e.RowIndex);

                        ResetMeal(breakfastFoodsView.Columns[0].HeaderText);
                    }
                }
            }
        }

        private void lunchFoodsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lunchFoodsView.RowCount > 0)
            {
                // Edit entry
                if (e.ColumnIndex == lunchFoodsView.ColumnCount - 2 && e.RowIndex >= 0)
                {
                    string entry = lunchFoodsView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string name = entry.Substring(0, entry.LastIndexOf(" "));

                    int left = entry.LastIndexOf('(') + 1;
                    int end = entry.Length - left - 1;

                    string serving = entry.Substring(left, end);
                    double servingsNum = double.Parse(serving);

                    EditSavedMealForm form = new EditSavedMealForm(new Meal('L', datePicker.Value), new Tuple<string, double>(name, servingsNum));
                    form.ShowDialog();
                    ResetMeal(lunchFoodsView.Columns[0].HeaderText);
                    LoadMeals();
                    FillTables();
                }
                // Remove entry
                else if (e.ColumnIndex == lunchFoodsView.ColumnCount - 1 && e.RowIndex >= 0)
                {
                    string entry = lunchFoodsView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    ConfirmDeleteFoodForm form = new ConfirmDeleteFoodForm(entry);

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        string name = entry.Substring(0, entry.LastIndexOf(" "));
                        DatabaseInterface.DeleteEntry(new Meal('L', datePicker.Value), name);
                        lunchFoodsView.Rows.RemoveAt(e.RowIndex);

                        ResetMeal(lunchFoodsView.Columns[0].HeaderText);
                    }
                }
            }
        }

        private void dinnerFoodsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dinnerFoodsView.RowCount > 0)
            {
                // Edit entry
                if (e.ColumnIndex == dinnerFoodsView.ColumnCount - 2 && e.RowIndex >= 0)
                {
                    string entry = dinnerFoodsView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string name = entry.Substring(0, entry.LastIndexOf(" "));

                    int left = entry.LastIndexOf('(') + 1;
                    int end = entry.Length - left - 1;

                    string serving = entry.Substring(left, end);
                    double servingsNum = double.Parse(serving);

                    EditSavedMealForm form = new EditSavedMealForm(new Meal('D', datePicker.Value), new Tuple<string, double>(name, servingsNum));
                    form.ShowDialog();
                    ResetMeal(dinnerFoodsView.Columns[0].HeaderText);
                    LoadMeals();
                    FillTables();
                }
                // Remove entry
                else if (e.ColumnIndex == dinnerFoodsView.ColumnCount - 1 && e.RowIndex >= 0)
                {
                    string entry = dinnerFoodsView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    ConfirmDeleteFoodForm form = new ConfirmDeleteFoodForm(entry);

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        string name = entry.Substring(0, entry.LastIndexOf(" "));
                        DatabaseInterface.DeleteEntry(new Meal('D', datePicker.Value), name);
                        dinnerFoodsView.Rows.RemoveAt(e.RowIndex);

                        ResetMeal(dinnerFoodsView.Columns[0].HeaderText);
                    }
                }
            }
        }

        private void snackFoodsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (snackFoodsView.RowCount > 0)
            {
                // Edit entry
                if (e.ColumnIndex == snackFoodsView.ColumnCount - 2 && e.RowIndex >= 0)
                {
                    string entry = snackFoodsView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string name = entry.Substring(0, entry.LastIndexOf(" "));

                    int left = entry.LastIndexOf('(') + 1;
                    int end = entry.Length - left - 1;

                    string serving = entry.Substring(left, end);
                    double servingsNum = double.Parse(serving);

                    EditSavedMealForm form = new EditSavedMealForm(new Meal('S', datePicker.Value), new Tuple<string, double>(name, servingsNum));
                    form.ShowDialog();
                    ResetMeal(snackFoodsView.Columns[0].HeaderText);
                    LoadMeals();
                    FillTables();
                }
                // Remove entry
                else if (e.ColumnIndex == snackFoodsView.ColumnCount - 1 && e.RowIndex >= 0)
                {
                    string entry = snackFoodsView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    ConfirmDeleteFoodForm form = new ConfirmDeleteFoodForm(entry);

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        string name = entry.Substring(0, entry.LastIndexOf(" "));
                        DatabaseInterface.DeleteEntry(new Meal('S', datePicker.Value), name);
                        snackFoodsView.Rows.RemoveAt(e.RowIndex);

                        ResetMeal(snackFoodsView.Columns[0].HeaderText);
                    }
                }
            }
        }

        private void AddItem(Meal meal)
        {
            List<Tuple<int, double>> items = DatabaseInterface.SelectMealFoods(meal);
            Dictionary<string, double> map = new Dictionary<string, double>();
            foreach (Tuple<int, double> item in items)
            {
                map.Add(DatabaseInterface.SelectFoodName(item.Item1), item.Item2);
            }
            AddMealItemForm form = new AddMealItemForm(meal, map);
            form.ShowDialog();
            ResetMeal(breakfastFoodsView.Columns[0].HeaderText);
            LoadMeals();
            FillTables();
        }

        private void addBreakfastItem_Click(object sender, EventArgs e)
        {
            AddItem(new Meal('B', datePicker.Value));
        }

        private void addLunchItem_Click(object sender, EventArgs e)
        {
            AddItem(new Meal('L', datePicker.Value));
        }

        private void addDinnerItem_Click(object sender, EventArgs e)
        {
            AddItem(new Meal('D', datePicker.Value));
        }

        private void addSnackItem_Click(object sender, EventArgs e)
        {
            AddItem(new Meal('S', datePicker.Value));
        }
    }
}
