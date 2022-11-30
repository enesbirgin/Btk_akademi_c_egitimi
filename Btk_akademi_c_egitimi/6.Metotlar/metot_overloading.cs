using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_akademi_c_egitimi._6.Metotlar
{
    public class metot_overloading
    {
        public static void Form()
        {

            // Add();
            //  Add();
            //  Add();
            //  var result = Add2(20);
            // int number1 = 20;
            //  int number2 = 60;
            // var result2 = Add3(number1, number2);
            // Console.WriteLine(result2);
            Console.WriteLine(Multiply(2,4));
        }
        static void Add()
        {
            Console.WriteLine("Added!!!");
        }
        static int Add2(out int number1, int number2 = 30)//DEFAULT
        {
            number1 = 30;
            var result = number1 + number2;
            return result;
        }
        static int Add3(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        
    }
}
