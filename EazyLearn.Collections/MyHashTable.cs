using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EazyLearn.Collections
{
    public class MyHashTable
    {
        public void Display()
        {
            Hashtable obj = new Hashtable();
            obj.Add(1, "One");
            obj.Add(2, "Two");
            obj.Add(3, "Three");
            obj.Add(4, "Four");
            obj.Add(5, "Five");
            obj.Add(6, "Six");
            obj.Add(7, "Seven");
            Console.WriteLine("Key and value of elements are");
            foreach (DictionaryEntry qwe in obj)
            {
                Console.WriteLine($"key : {qwe.Key} Value : {qwe.Value}");
            }
            Console.ReadLine();
        }
    }
}
