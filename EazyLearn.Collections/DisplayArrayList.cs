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
