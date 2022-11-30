using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_akademi_c_egitimi._String_ile_calismak
{
    public class string_ile_calısmaya_baslamak
    {
        public static void Form()
        {

            string city = "İzmir";
            //Console.WriteLine(city[0]);
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "Eskişehir";
            string result = city + city2;
            Console.WriteLine(result);
        }
    }
}
