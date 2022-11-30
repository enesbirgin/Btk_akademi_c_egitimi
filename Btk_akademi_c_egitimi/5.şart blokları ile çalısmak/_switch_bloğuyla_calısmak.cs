using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_akademi_c_egitimi._5.şart_blokları_ile_çalısmak
{
    public class _switch_bloğuyla_calısmak
    {
        public static void Form()
        {
            var number = 11;
            switch (number)
            {
                case 10:
                    Console.WriteLine("number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                    default: 
                    Console.WriteLine("number is not 10 or 20");
                    break;
            }

            }
        }
    }

