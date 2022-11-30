using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_akademi_c_egitimi._7._Diziler
{
    public class _cok_boyutlu_diziler
    {
        public static void Form() {


            string[,] regions = new string[5, 3]
            {

            { "İstanbul" ,"izmit" ,"balıkesir"},
            { "ankara" ,"konya" ,"kırıkkale"},
            { "antalya" ,"adana" ,"mersin"},
            { "samsun" ,"trabzon" ,"rize"},
            { "izmir" ,"muğla" ,"manisa"},
            

            };
            for (int i =0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
            }
        }
    }
}
