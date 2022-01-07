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
