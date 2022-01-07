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
    public class CreateAndDisplayQueue
    {
        public void Display()
        {
            Queue obj = new Queue ();
            obj.Enqueue(1);
            obj.Enqueue(2);
            obj.Enqueue(3);
            obj.Enqueue(4);
            obj.Enqueue(5);
            obj.Enqueue(6);
            obj.Enqueue(7);
            obj.Enqueue(8);
            obj.Enqueue(9);
            obj.Enqueue(10);
            Console.WriteLine("Elementts in the queue are :");

            foreach(var element in obj)
            {
                Console.WriteLine($"{element}");
            }
        }
    }
}
