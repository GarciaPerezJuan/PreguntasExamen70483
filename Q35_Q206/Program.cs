using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q35_Q206
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature t = new Temperature();
            t.Fahrenheit = 15;
            Temperature t2 = new Temperature();
            t2.Fahrenheit = 15;

            if (t.CompareTo(t2) == 0)
                Console.WriteLine("Iguales");
            else
                Console.WriteLine("Diferentes");
            Console.ReadKey();
        }

        public class Temperature : IComparable {

            public double Fahrenheit { get; set; }

            public int CompareTo(object obj) {

                if (obj == null) return 1;
                var otherTemperature = obj as Temperature;
                if (otherTemperature != null) { 
                    //return this.Fahrenheit.CompareTo(otherTemperature.Fahrenheit);
                    return otherTemperature.Fahrenheit.CompareTo(this.Fahrenheit);
                }
                throw new ArgumentException("Object is not a Temperature");
            }
        }
    }
}
