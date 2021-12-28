using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

