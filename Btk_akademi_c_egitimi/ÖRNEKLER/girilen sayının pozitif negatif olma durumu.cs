using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_akademi_c_egitimi.ÖRNEKLER
{
    internal class girilen_sayının_pozitif_negatif_olma_durumu
    {
        public static void Form()
        {
            double  sayi;
            Console.Write("Bir sayı giriniz ");

          sayi = Convert.ToDouble(Console.ReadLine());

            if(sayi < 0)
            {
                Console.WriteLine("Sayı negatiftir");
            }

            else
            {
                Console.WriteLine("Girdiğiniz sayı pozitiftir");
            }


        }
    }
}
