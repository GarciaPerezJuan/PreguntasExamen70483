using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12
{
    class Program
    {
        public class Alert
        {
            public event EventHandler<EventArgs> SendMessage;

            public void Execute()
            {
                SendMessage(this, new EventArgs());
            }

        }

        public class Subscriber
        {
            Alert alert = new Alert();

            public void Subscribe()
            {
                alert.SendMessage += (sender, e) => { Console.WriteLine("First"); };
                alert.SendMessage += (sendeer, e) => { Console.WriteLine("Second"); };
                alert.SendMessage += (sender, e) => { Console.WriteLine("Third"); };
                alert.SendMessage += (sender, e) => { Console.WriteLine("Third"); };
            }

            public void Execute()
            {
                alert.Execute();
            }

        }
        static void Main(string[] args)
        {
            Subscriber s = new Subscriber();
            s.Subscribe();
            s.Execute();
            Console.ReadKey();
        }

        // Para cada una de las siguientes sentencias decir si se cumple o no:
        //
        // a ->If there are no subscribers to the SendMessage event, the Execute method
        //     on the alert class will throw an exception -> YES, porque no se está comprobando
        //     que haya algo asignado a SendMessage.
        //
        // b -> When the application runs, "First" will always appear before "Second" -> NO.
        //      Aquí yo tengo dudas, yo habría dicho que YES ya que creo que lo ejecuta por orden.
        //
        // c -> When the application runs, "Third" will be displayed once -> NO. Ya que tiene asociado
        //      dos métodos que escribe Third cada uno de ellos.
    }
}
