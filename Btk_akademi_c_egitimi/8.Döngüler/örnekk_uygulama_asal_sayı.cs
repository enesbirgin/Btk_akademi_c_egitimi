using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_akademi_c_egitimi._8.Döngüler
{
    public class örnekk_uygulama_asal_sayı
    {
        public static void Form() { }
        private static void ForEachLoop()
        {
            string[] students = new string[3] { "ENO", "ENES", "enes" };
            foreach (var student in students)
            {

                Console.WriteLine(student);
            }
            if (IsPrimeNumber(6))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not  a prime number");
            }
        }
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;

        }
    }
}