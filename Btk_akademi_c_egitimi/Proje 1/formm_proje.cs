using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_akademi_c_egitimi.Proje_1
{
    public class formm_proje
    {
        public static void Form()
        {
            Console.WriteLine("Cümleyi giriniz");
            string text = Console.ReadLine();

            Console.WriteLine("Kelimeyi Giriniz");
            string aranacak = Console.ReadLine();

            string sekil = text.Replace(aranacak, "*");

            int adet = sekil.Count(x => x == 'x');
            Console.WriteLine(adet + "Adet Bulunmaktadır");
        }

    }
}
