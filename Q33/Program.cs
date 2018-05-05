using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q33
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private bool GetMaches(List<string> departments, string searchTerm)
        {
            // A
            var findDepartmentA = departments.Where(x => x == searchTerm);

            // B
            var findDepartmentB = departments.Where(x => x.Equals(searchTerm));
            
            // C
            var findDepartmentC = departments.First(x => x == searchTerm);

            // D
            var findDepartmentD = departments.Exists(x => x == searchTerm);

            return findDepartmentA;
            return findDepartmentB;
            return findDepartmentC;
            return findDepartmentD; // Sólo este está bien pq devuelve un boolean. El resto ni compilan.
        }
    }
}
