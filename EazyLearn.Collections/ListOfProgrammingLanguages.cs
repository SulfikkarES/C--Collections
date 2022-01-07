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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion 

namespace EazyLearn.Collections
{
    public class ListOfProgrammingLanguages
    {
        bool check;
        public void Display()
        {
            List<string> obj = new List<string>();
            obj.Add("C");
            obj.Add("C++");
            obj.Add("C#");
            obj.Add("PHP");
            obj.Add("SQL");
            obj.Add("Java");
            obj.Add("Python");
            obj.Add("HTML");
            Console.WriteLine("\n Elements in the list are :");

            foreach(string name in obj)
            {
                Console.WriteLine($"{name}");
            }
            Console.WriteLine("\nCheck whether the list contains the language c# in it ?");
            Console.WriteLine(obj.Contains("C#"));
            Console.WriteLine("\n is there a language C in the list ?");
            if (check == true )
            {
                Console.WriteLine("\n There is a language C in the list ");
                obj.Remove("C");
            }
            else
            {
                Console.WriteLine("\n There is no language C in the list");
            }
            obj.Insert(3, "VB.Net"); //insert VB.Net to 4th position,starting from 0th position, so 3
            Console.WriteLine("Elements in the list before sorting is :");

            foreach(string name in obj)
            {
                Console.WriteLine($"{name}");
            }
            obj.Sort();
            Console.WriteLine("Elements in the list after sorting is :");

            foreach(string name in obj)
            {
                Console.WriteLine($"{name}");
            }

        }
    }
}
