using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EazyLearn.Collections
{
    public class CreateLinkedList
    {
        public void Display()
        {
            LinkedList<string> obj = new LinkedList<string>();
            obj.AddFirst(" Akhil");
            obj.AddFirst(" Amal");
            obj.AddFirst(" Aravind");
            obj.AddFirst(" Rahul");
            obj.AddLast(" Shyam");
            obj.AddLast(" Ragesh");
            obj.AddLast(" Soman");
            obj.AddLast("Binu");
            Console.WriteLine("Elements In The LinkedList are :");

            foreach (string mnb in obj)
            {
                Console.WriteLine($"{mnb}");
            }
            obj.RemoveFirst();
            obj.RemoveLast();
            obj.Remove(" Shyam");
            Console.WriteLine("\nElements after deletion are :");

            foreach(string mnb in obj)
            {
                Console.WriteLine($"{mnb}");
            }
        }
    }
}
