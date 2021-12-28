using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EazyLearn.Collections
{
    public class DisplayArrayList
    {
        public void Display()
        {
            ArrayList obj = new ArrayList()
            {
                " Akhil",
                " Aravind",
                " Amal",
                " Rahul",
                " Shyam",
                " Ragesh",
                " Soman"
            };
            Console.WriteLine($"The nnumber of elements in the ArrayList is :{obj.Count}\n");
            Console.WriteLine("The ArrayList is :");
            foreach (var ch in obj)
            {
                Console.WriteLine($"{ch}");
            }
            Console.ReadLine();
        }
    }
}
