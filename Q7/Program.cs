#define DEBUG // Esto define un símbolo. Este símbolo siempre será true
using System;
using System.Diagnostics;

namespace Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            Q7 q = new Q7();
            q.RunTestClass();
            Console.ReadKey();

        }
    }

    public class Q7
    {
        [Conditional("DEBUG")] // Esto sólo se ejecuta en modo debug. No tiene nada que ver con el define de arriba
        public void LogData()
        {
            Console.Write("LogData1\n");

        }

        public void RunTestClass()
        {
            this.LogData();

#if (DEBUG) // Como está el define debug arriba esto siempre será true, independientemente
            // de si ejecutamos en modo debug o en modo release
            Console.Write("LogData2");
#endif

        }

        // Preguntas:
        // a -> When RunTestClass executes, LogData1 will be written if the application starts
        //      in DEBUG mode -> SI -> Se ejecuta sólo en modo DEBUG
        // b -> When RunTestClass executes, LogData2 will be written if the application starts
        //      in DEBUG mode -> SI. Esta se va a escribir siempre por el define
        // c -> When RunTestClass executes, LogData2 will be written if the application starts
        //      in RELEASE mode -> SI. Esta se va a escribir siempre por el define

        // CONCLUSION. Todas las opciones son SI.
    }

}
