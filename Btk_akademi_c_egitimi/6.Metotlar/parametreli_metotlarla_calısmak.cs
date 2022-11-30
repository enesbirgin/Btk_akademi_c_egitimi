using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_akademi_c_egitimi._6.Metotlar
{
    public class parametreli_metotlarla_calısmak
    {
        public static void Form()
        {
            Add();
            Add();
            Add();
            var result = Add2(20, 30);
            Console.WriteLine(result);
        }
        static void Add()
        {
            Console.WriteLine("Added!!!");
        }
        static int Add2(int number1, int number2)
        {
        var result = number1 + number2;
        return result;
        }
     }
}    

