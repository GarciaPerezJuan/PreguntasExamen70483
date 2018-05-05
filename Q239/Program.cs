using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q239
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pregunta 1. User can be a member of more than one of the groups?? La respuesta es SI
            User u = new User();

            // https://stackoverflow.com/questions/8447/what-does-the-flags-enum-attribute-mean-in-c
            // Al tener el flags attributes nos deja asignar varios valores. Para poder hacer esto, los valores
            // del enum deben estar numerados. Ejemplo con enum con atributo Flags y otro sin atributo
            u.UserGroup = Group.Administrators | Group.Managers;
            Console.WriteLine("1 - " + u.UserGroup.ToString()); // Deja tener varios valores

            u.UserGroupSinFlags = GroupSinFlags.Administrators | GroupSinFlags.Managers;
            Console.WriteLine("2 - " + u.UserGroupSinFlags.ToString()); // Resultado 12. Suma los valores

            // Pregunta 2. If the user belongs to only the Administrators group, the following code will return a value of true
            // Respuesta SI
            u.UserGroup = Group.Administrators;
            if (u.UserGroup == Group.Administrators)
                Console.WriteLine("Pregunta 2 - SI");
            else
                Console.WriteLine("PreguntA 2 - NO");


            // Pregunta 3. If the usr belongs to only the Supervisors group, the following code will return a value of true
            // Depende, si nos atenemos al código, la comprobación u.Usergroup lt; Group.Administrators está mal y, por tanto, 
            // la respuesta es NO
            // Si, suponemos que el enunciado está mal y lo que ponen es u.UserGroup < Group.Administrators la respuesta es SI.
            u.UserGroup = Group.Supervisors;
            if (u.UserGroup < Group.Administrators)
                Console.WriteLine("Pregunta 3 - SI");
            else
                Console.WriteLine("PreguntA 3 - NO");

            Console.ReadLine();
        }

        public class User
        {
            public Group UserGroup { get; set; }
            public GroupSinFlags UserGroupSinFlags { get; set; }
        }
        [System.FlagsAttribute()]
        public enum Group
        {
            Users = 1,
            Supervisors = 2,
            Managers = 4,
            Administrators = 8
        }

        public enum GroupSinFlags
        {
            Users = 1,
            Supervisors = 2,
            Managers = 4,
            Administrators = 8
        }

    }
}
