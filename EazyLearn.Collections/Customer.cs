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
    public class Customer
    {
        public int Customerid { get; set; }
        public string Customername { get; set; }

        public Customer(int costo_id, string costo_name)
        {
            Customerid = costo_id;
            Customername = costo_name;
            Console.WriteLine($"The Customerid : {Customerid}");
            Console.WriteLine($"The Customername :{Customername}");
            Console.WriteLine();
        }
    }
}

