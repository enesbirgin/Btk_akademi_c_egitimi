using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_akademi_c_egitimi.ÖRNEKLER
{
    public class if_hız_ve_mesafe
    {
        public static void Form()
        {
            Console.WriteLine("Aracınızın hızını giriniz :");
            double hiz = double.Parse(Console.ReadLine());

            if(hiz > 40 ) 
            {
                int mesafe = 270;
                double saat = mesafe / hiz;

                Console.WriteLine("Aracınız" + saat.ToString("F2") + " saat de Ayvalığa varır...");
            }
            else 

                Console.WriteLine("Hızı yüksek girin...");

        }
    }
}
