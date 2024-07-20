using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocOnReflection.Models
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double AccountNumber { get; set; }

        public Customer() { }

        static void getCustomerDetails()
        {
            Console.WriteLine("These are the details of customer...");
        }
    }
}
