#region Copyright EazyLearn
//
// All rights are reserved. Reproduction or transmission in whole or in part, 
// in any form or by any means, electronic, mechanical or otherwise, is
// prohibited without the prior written consent of the copyright owner.
//
// Filename        : C#Collections.cs
// Purpose         : To practice C# Collections 
// Creation Date   : 20-09-2021
// Author          : Sulfikkar E S
//
// Change History  :
// Changed by      :              
// Date            : 
// Purpose         :
//
#endregion Copyright 

#region Included namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion 

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
