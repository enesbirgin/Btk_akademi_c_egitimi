using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_akademi_c_egitimi.ÖRNEKLER
{
    public class hoşgeldiniz
    {
        public static void Form()
        {
            Console.WriteLine("İsminizi Giriniz");
           string isim = Console.ReadLine();
            Console.WriteLine("Hoşgeldin " + isim);
        }
    }
}
