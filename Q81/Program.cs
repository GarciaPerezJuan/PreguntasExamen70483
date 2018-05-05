using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Q81
{
    class Program
    {
        static void Main(string[] args)
        {
            var serializer = new DataContractJsonSerializer(); // Error ya que no tiene constructor sin parámetros
            var serializer2 = new DataContractSerializer(); // Error ya que no tiene constructor sin parámetros
            var serializer3 = new JavaScriptSerializer(); // Correcto. Admite constructor sin parámetros.

        }
    }
}
