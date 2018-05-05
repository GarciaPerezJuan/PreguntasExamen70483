using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Q153_Q167
{
    class Program
    {
        static void Main(string[] args)
        {
            TestIfWebSite("http://www.as.com");
        }

        public static List<string> TestIfWebSite(string url)
        {
            const string pattern = @"http://(www\.)?([^\.]+)\.com";
            List<string> result = new List<string>();

            MatchCollection myMatches = Regex.Matches(url, pattern);

            // Q153. A. Incorrecta. Da error de ejecución. typeMismatch
            //result = (List<string>) myMatches.GetEnumerator();

            // Q153. B. Incorrecta. SyncRoot no devuelve los elementos que corresponden con el pattern
            //result = (List<string>)myMatches.SyncRoot;

            // Q153. C. Correcta.
            result = (from Match m in myMatches
                      select m.Value).ToList<string>();

            // Q153. D. Incorrecta. Devuelve justo las que no corresponden con el pattern
            //result = (from Match m in myMatches where !m.Success select m.Value).ToList<string>();

            // Q167. A. Incorrecta. No devuelve el valor.
            foreach (Match c in myMatches)
                result.Add(c.Groups.ToString());

            // Q167. B. Incorrecta.Da error de ejecución. typeMismatch
            //result = (List<string>) myMatches.GetEnumerator();

            // Q167. C. Correcta
            foreach (Match c in myMatches)
                result.Add(c.Value);

            // Q167. D. Incorrecta. SyncRoot no devuelve los elementos que corresponden con el pattern
            //result = (List<string>)myMatches.SyncRoot;
            
            return result;
        }
    }
}
