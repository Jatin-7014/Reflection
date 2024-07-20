using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocOnReflection.Models
{
    internal class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double AccountNumber {  get; set; }

        public Account(int id,string name,double accountNumber)
        {
            Id = id;
            Name = name;
            AccountNumber = accountNumber;
        }

        static void getDetails()
        {
            Console.WriteLine("These are the details of account holder...");
        }
    }
}
