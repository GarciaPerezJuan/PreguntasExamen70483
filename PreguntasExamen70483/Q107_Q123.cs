using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreguntasExamen70483
{
    public class Q107_Q123
    {
        public void Method()
        {
            ArrayList array1 = new ArrayList();
            int var1 = 10;
            int var2;
            array1.Add(var1);

            // La pregunta es sobre esta línea. Dice que, dejada así, da un error de compilación ya que hay que hacer un cast
            // al elemento del array, ya que arrayList guarda objects genéricos.
            var2 = array1[0];

            // Las soluciones que se proponen son las siguientes.
            // Q107:
            var2 = ((List <int>) array1)[0]; // a -> Erronea. Error de compilación. No se puede convertir ArrayList en List<int>
            var2 = array1[0].Equals(typeof(int)); // b -> Erronea. Al equals habría que pasarle otro objeto para comparar
            var2 = Convert.ToInt32(array1[0]); // c -> Esta sería correcta
            var2 = ((int[])array1)[0]; // d -> Erronea. Error de compilación. No se puede convertir ArrayList en int[]

            // Q123:
            var2 = ((List<int>)array1)[0]; // a -> Erronea. Error de compilación. No se puede convertir ArrayList en List<int>
            var2 = (int) array1[0]; // b -> Esta sería correcta
            var2 = int.Parse(array1[0]); // c -> Erronea. Parse espera un string y no se puede pasar así object a string
            var2 = array1[0] as int // d -> Erronea. Para usar as se debe usar con un tipo por referencia y que acepte nulos. Int no los acepta

        }
    }
}
