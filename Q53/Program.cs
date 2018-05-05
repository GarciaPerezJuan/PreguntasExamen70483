using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q53
{
    class Program
    {
        static void Main(string[] args)
        {
            // A. Incorrecta. Ni compila
            var starter = new UseStart();
            ((IHome, IOffice)starter).Start();

            //D. Esta es la correcta.
            var starter2 = new UseStart();
            ((IHome)starter2).Start();
            ((IOffice)starter2).Start();
        }
    }

    interface IHome { void Start(); }
    interface IOffice { void Start(); }

    class UseStartPublic: IHome, IOffice // Con public no es válido
    {
        public void IHome.Start() { Console.WriteLine("Public Ihome.start"); }
        public void IOffice.Start() { Console.WriteLine("Public IOffice.start"); }
    }

    class UseStart : IHome, IOffice
    {
        void IHome.Start() { Console.WriteLine("Public Ihome.start"); }
        void IOffice.Start() { Console.WriteLine("Public IOffice.start"); }
    }

}
