using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_akademi_c_egitimi._8.Döngüler
{
    public class _for_Each_Döngüsü
    {
        public static void Form()
        {
            string[] students = new string[3] { "ENO", "ENES", "enes" };
            foreach (var student in students) 
            {

                Console.WriteLine(student);
            }

            
        }
    }
}
