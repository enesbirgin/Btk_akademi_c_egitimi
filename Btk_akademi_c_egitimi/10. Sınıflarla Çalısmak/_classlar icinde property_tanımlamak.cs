using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_akademi_c_egitimi._10._Sınıflarla_Çalısmak
{
    public class _classlar_icinde_property_tanımlamak
    {
        public static void Form()
        { }
        class Customer
        {
            public int id { get; set; }
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public string city { get; set; }

            public static implicit operator Customer(int v)
            {
                throw new NotImplementedException();
            }

        }

         
    }
}
