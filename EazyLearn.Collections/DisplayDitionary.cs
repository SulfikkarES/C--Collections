using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EazyLearn.Collections
{
    public class DisplayDitionary
    {
        public void display()
        {
            Dictionary<string, string> countries = new Dictionary<string, string>()
            {
                {"de","Germany"},
                {"sk","Slovakia"},
                {"us","United States"},
                {"ru","Russia"},
                {"hu","Hungary"},
                {"pl","Poland"}
            };

            Console.WriteLine("The <key,value> in the dictionary are : ");
            foreach (KeyValuePair<string, string> element in countries)
            {
                Console.WriteLine(element.Key + " => " + element.Value);
            }

            Console.WriteLine("\nThe count of elements in the dictionary are : ");
            Console.WriteLine(countries.Count());

            Console.WriteLine("\nName of the values with key 'hu' and 'sk' are : ");
            Console.WriteLine(countries["hu"]);
            Console.WriteLine(countries["sk"]);

            Console.WriteLine("\nAll the keys in the dictionary are : ");
            foreach (KeyValuePair<string, string> element in countries)
            {
                Console.WriteLine(element.Key);
            }

            Console.WriteLine("\nAll the values in the dictionary are : ");
            foreach (KeyValuePair<string, string> element in countries)
            {
                Console.WriteLine(element.Value);
            }
        }
    }
}
