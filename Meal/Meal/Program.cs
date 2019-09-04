using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meal
{
    class Program
    {
        public static string WhenToEatMeal(string meal)
        {
            string hourOfTheDay;
            if (String.Equals(meal, "breakfast")) hourOfTheDay = "7:00 AM";
            else if (String.Equals(meal, "lunch")) hourOfTheDay = "12:00 PM";
            else if (String.Equals(meal, "snack")) hourOfTheDay = "3:00 PM";
            else if (String.Equals(meal, "brunch")) hourOfTheDay = "7:00 pM";
            else Console.WriteLine("Meal not recognized, enter a valid meal");
            return hourOfTheDay;
        }
    static void Main(string[] args)
        {
            
                Console.WriteLine("Please enter a valid meal:");
                string meal = Console.ReadLine();
            if(String.Equals(meal, "breakfast"))||(String.Equals(meal,"lunch"))|| (String.Equals(meal, "snack")||(String.Equals(meal, "brunch"))
              string timeOfMeal = WhenToEatMeal(meal);
              Console.WriteLine("This {0} should be eaten at {0}",meal, timeOfMeal);
            else
                Console.WriteLine("Please enter a valid meal:");
        }
    }
}
