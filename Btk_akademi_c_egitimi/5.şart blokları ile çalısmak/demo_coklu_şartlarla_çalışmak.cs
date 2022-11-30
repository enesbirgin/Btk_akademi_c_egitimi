using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_akademi_c_egitimi._5.şart_blokları_ile_çalısmak
{
    public class demo_coklu_şartlarla_çalışmak
    {
        public static void Form()
        {
            var number = 20;
            if (number >= 0 && number <= 100)
            {
                Console.WriteLine("Number is between 0-100");
            }
            else if (number > 100 && number <= 200)
                {
                Console.WriteLine("Number is between 101-200");
                }
            else if(number > 200  || number < 0)
                {
                Console.WriteLine("number is less than 0 or greater than 200");
            }
            }
        }
    }

