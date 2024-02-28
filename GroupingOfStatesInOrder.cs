using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ20.Net_Week6_Task
{
    public class GroupingOfStatesInOrder
    {
        
        public static void StateGrouping()
        {

            List<string> states = new List<string>
            {
                "Abia", "Adamawa", "Akwa-Ibom", "Anambra", "Bauchi", "Bayelsa",
                "Benue", "Borno", "Cross River", "Delta", "Ebonyi", "Edo", "Ekiti",
                "Enugu", "Gombe", "Imo", "Jigawa", "Kaduna", "Kano", "Katsina",
                "Kebbi", "Kogi", "Kwara", "Lagos", "Nasarawa", "Niger", "Ogun",
                "Ondo", "Osun", "Oyo", "Plateau", "Rivers", "Sokoto", "Taraba",
                "Yobe", "Zamfara"
            };
            var groupedStates = from state in states
                group state by state[0] into g
                orderby g.Key
                select new { Letter = g.Key, States = g };


            foreach (var group in groupedStates)
            {
                Console.WriteLine($"States starting with '{group.Letter}':");
                Console.WriteLine("----------------");
                Console.WriteLine($"Count: {group.States.Count()}");
                Console.WriteLine(string.Join(", ", group.States));
                Console.WriteLine();
            }
        }
    }
    
}
