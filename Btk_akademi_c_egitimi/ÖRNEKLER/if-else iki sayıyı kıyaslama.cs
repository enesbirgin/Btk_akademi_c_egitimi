using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_akademi_c_egitimi.ÖRNEKLER
{
    public class if_else_iki_sayıyı_kıyaslama
    {
        public static void Form()
        {

            Console.Write("İlk sayıyı giriniz :");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.Write("İkinci Sayıyı giriniz :");
            int sayi2 = int.Parse(Console.ReadLine());

            if (sayi1 == sayi2)
                Console.Write("iki sayı birbirine Eşit");

            else if (sayi1 > sayi2)
                Console.Write("{0} sayisi daha büyük {1} sayisi daha kucuk", sayi1, sayi2);

            else if (sayi1 < sayi2)
                Console.Write("{1} Sayısı daha büyük {0} sayisi daha kucuk", sayi1, sayi2);

        }
    }
}
