using MacroTracker.Forms;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MacroTracker
{
    public class FormManager : ApplicationContext
    {
        public enum FormTypes
        {
            AddNewFoodForm,
            AddNewMealForm,
            DailyTotalsForm,
            MenuForm,
            RecordMealForm,
            ReviewNewFoodForm,
            ReviewNewMealForm,
            SavedFoodsForm,
            WelcomeForm,
            EnterMacroGoalsForm
        }

        private static ArrayList forms = new ArrayList();

        public FormManager()
        {
            if (!Properties.Settings.Default.setGoal)
            {
                AddForm(FormTypes.WelcomeForm);
            }
            else
            {
                AddForm(FormTypes.MenuForm);
            }
        }

        public static void AddForm(FormTypes type, Meal meal = null, List<Food> foods = null, Dictionary<string, double> map = null)
        {
            Form form = null;
            if (type == FormTypes.MenuForm)
            {
                form = new MenuForm();
            }
            else if (type == FormTypes.AddNewFoodForm)
            {
                form = new AddNewFoodForm();
            }
            else if (type == FormTypes.AddNewMealForm)
            {
                form = new AddNewMealForm();
            }
            else if (type == FormTypes.DailyTotalsForm)
            {
                form = new DailyTotalsForm();
            }
            else if (type == FormTypes.RecordMealForm)
            {
                form = new RecordMealForm(meal);
            }
            else if (type == FormTypes.ReviewNewFoodForm)
            {
                form = new ReviewNewFoodForm(foods);
            }
            else if (type == FormTypes.ReviewNewMealForm)
            {
                form = new ReviewNewMealForm(meal, map);
            }
            else if (type == FormTypes.SavedFoodsForm)
            {
                form = new SavedFoodsForm();
            }
            else if (type == FormTypes.EnterMacroGoalsForm)
            {
                form = new EnterMacroGoalsForm();
            }
            else if (type == FormTypes.WelcomeForm)
            {
                form = new WelcomeForm();
            }
            form.Show();
            forms.Add(form);
        }

        public static void RemoveForm(Form form)
        {
            forms.Remove(form);
            if (forms.Count == 0)
            {
                Application.Exit();
            }
        }
    }
}