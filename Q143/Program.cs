using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q143
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> data = CreateDataTest();
            var a = data.Contains(new KeyValuePair<string, int>("Finance",0));
            var b = data.Contains(new KeyValuePair<string, int>("Accounting", 1));
            var c = data.Contains(new KeyValuePair<string, int>("Acccounting", 2));
        }

        private static Dictionary<string, int> CreateDataTest()
        {
            return new Dictionary<string, int>() { { "Accounting", 1 }, { "Marketing", 2 }, { "Operations", 3 } };
        }
    }
}
