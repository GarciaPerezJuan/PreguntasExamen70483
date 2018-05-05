using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q125_Q213
{
    class Program
    {
        static void Main(string[] args)
        {
            // A. Creo que INCORRECTA. Escribe sólo en DEBUG
            //Debug.WriteLine("Trace data opción A ...");

            // B. INCORRECTA. No escribe en el visor de eventos
            //Console.SetOut(new StreamWriter("System.Diagnostics.EventLogTraceListener"));
            //Console.WriteLine("Trace data opción B ...");

            // C. Creo que Correcta. Escribe en RELEASE y en DEBUG
            Trace.WriteLine("Trace data opción C ...");

            // D. INCORRECTA. No se especificó source.
            //EventLog log = new EventLog();
            //log.WriteEntry("Trace data opción D ...");

        }
    }
}
