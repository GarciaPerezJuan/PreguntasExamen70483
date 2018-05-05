using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q217
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myData = new List<string>();
            myData.Add("string1");
            myData.Add("string2");
            myData.Add("string3");

            // El objetivo de la pregunta es borrar el contenido de la lista. Que trozo de código hay que elegit?

            // A. Incorrecta. No borra todas ya que el count va bajando y la i subiendo. Deja una sin borrar.
            //for (int i = 0; i <= myData.Count; i++)
            //{
            //    myData.RemoveAt(i);
            //}

            // B. Correcta.
            while (myData.Count != 0)
            {
                myData.RemoveAt(0);
            }

            // C. Incorrecta. Al eliminar un elemento considera la colección modificada. Error en tiempo de ejecución.
            //foreach (string c in myData)
            //{
            //    myData.Remove(c);
            //}

            //D. Incorrecta. No borra todas ya que el count va bajando y la i subiendo. Deja una sin borrar.
            //for (int i = 0; i <= myData.Count; i++)
            //{
            //    myData.RemoveAt(0);
            //}

        }
    }
}
