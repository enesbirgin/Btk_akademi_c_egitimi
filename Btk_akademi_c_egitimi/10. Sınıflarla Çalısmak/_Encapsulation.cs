using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_akademi_c_egitimi._10._Sınıflarla_Çalısmak
{
    public class _Encapsulation
    {
        public static void Form()
        { }



        public int Id { get; set; }
        private string _firstName;
        public string Firstname
        {
            get { return "Mr" + _firstName; }
            set { _firstName = value; }
            
        }
        public string Lastname { get; set; }
        public string City { get; set; }
    
    } 


}


