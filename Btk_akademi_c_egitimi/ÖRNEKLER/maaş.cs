using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_akademi_c_egitimi.ÖRNEKLER
{
    public class maaş
    {
        public static void Form()
        {
            Console.WriteLine("Doktorun Adını Giriniz :");
            string doktor= Console.ReadLine();
            Console.WriteLine("Doktorun Çalıstığı gün sayısını giriniz :");
            int gun =int.Parse(Console.ReadLine());
            Console.WriteLine("Birgünde baktığı hasta sayısını girirniz :");
            int hastasay=int.Parse(Console.ReadLine());

            int hastaucret = 25;
            int ilkmaas = 4000;

            Console.WriteLine("Doktor" + doktor + "ın aylık geliri...:"+((hastasay*hastaucret*ilkmaas)+ilkmaas));

        }
    }
}
