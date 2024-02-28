using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SQ20.Net_Week6_Task
{
    public static class StatesInNigeria
    {
        public static void GroupStates()
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
            Console.WriteLine("Enter number of groups required");
            int numberOfGroups = Convert.ToInt32(Console.ReadLine());
            //int numberOfGroups = 5;
            int groupSize = CalculateGroupSize(states.Count, numberOfGroups);

            var groups = states.Select((state, index) => new { state, index })
                .GroupBy(x => x.index / groupSize)
                .Select(group => string.Join(", ", group.Select(x => x.state)));

            Console.WriteLine($"A Group of states in a set of {groupSize}:\n============================");

            foreach (var group in groups)
            {
                Console.WriteLine(group);
                Console.WriteLine("---".PadLeft(35, '='));
                Console.WriteLine("\n\n");
            }
        }

        static int CalculateGroupSize(int totalStates, int numberOfGroups)
        {
            return (int)Math.Ceiling((double)totalStates / numberOfGroups);
        }
    }
    
}



