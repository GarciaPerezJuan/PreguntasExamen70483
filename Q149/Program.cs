using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q149
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Comprobacion(a);
            Comprobacion2(a);
        }
        
        public class Customer {
            public int Id { get; set; }
            public string Nombre{ get; set; }
        }

        public static void Comprobacion(Int32 id) {     }

        public static void Comprobacion2(int? id) { }
    }
}
