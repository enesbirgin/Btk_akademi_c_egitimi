using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_akademi_c_egitimi.ÖRNEKLER
{
    internal class maaş_kesinti_hesaplama
    {
        public static void Form()
        {

            int maas = 0;
            Console.WriteLine("Maaşınızı giriniz");
            maas = Convert.ToInt32(Console.ReadLine());

            if (maas >= 1000 && maas <= 2500)
            {
                Console.WriteLine("Maasınızdan 384 TL kesinti olacaktır.");
            }
            else if (maas >= 2501 && maas <= 4000)
            {
                Console.WriteLine("Maasınızdan 567 TL kesinti olacaktır");
            }
            else if (maas > 4000)
            {
                Console.WriteLine("Maasınınzdan 867 TL kesinti olacaktır");
            }
            else
            {
                Console.WriteLine("maasınızdan 8 TL kesinti olacaktır");
            }
            }
        }
    }

