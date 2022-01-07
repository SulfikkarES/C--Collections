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
