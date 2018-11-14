using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fullNames = { "Dina Ally Dorner", "Brandie Meisner", "Hubert Nickens", "Shaun Dulin", "Leonardo Bowser" };

            foreach (KeyValuePair<string, string> name in sortNames(fullNames))
            {
                Console.WriteLine(name.Value.ToString());
            }

            Console.ReadLine();
        }

        private static SortedList<string, string> sortNames(string[] fullNames)
        {
            SortedList<string, string> sortedListNames = new SortedList<string, string>();

            foreach (string item in fullNames)
            {
                string[] arrayNames = item.Split(' ');

                sortedListNames.Add(arrayNames[arrayNames.Length - 1], item);
            }

            return sortedListNames;
        }
    }
}
