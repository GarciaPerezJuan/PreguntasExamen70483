using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q113
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> customers = new List<int>();

            List<Int32> vaidCustomers = (from c in customers.AsParallel() where ValidateCustomer(c) select c).ToList();
             vaidCustomers = (from c in customers where ValidateCustomer(c) select c).AsParallel().ToList();
        }

        private static bool ValidateCustomer(int c)
        {
           return true;
        }
    }
}
