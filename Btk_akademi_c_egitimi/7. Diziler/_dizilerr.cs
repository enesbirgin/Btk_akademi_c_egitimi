using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_akademi_c_egitimi._7._Diziler
{
    public class _dizilerr
    {
        public static void Form()
        {
            string[] students = new string[3];
            students[0] = "Enes";
            students[1] = "Eno";
            students[2] = "ENES";
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
 
        }
    }
}
