using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.Wpf.Models
{
    public class BudgetRepository
    {
        public static void AddNewBudgetToDb(Budget budget)
        {
            using (BudgetContext db = new BudgetContext())
            {
                db.budgets.Add(budget);
                db.SaveChanges();
            }
        }

        public static void RemoveBudgetFromDb()
        {

        }
        public static List<Budget> GetAllBudget()
        {
            List<Budget> list = new List<Budget>();
            using (BudgetContext db = new BudgetContext())
            {
                list.AddRange(db.budgets);
            }
            return list;
        }
    }
}
