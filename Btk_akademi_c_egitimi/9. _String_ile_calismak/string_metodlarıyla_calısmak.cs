using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_akademi_c_egitimi._String_ile_calismak
{
    public class string_metodlarıyla_calısmak
    {
        public static void Form()
        {

            string sentence = "My name is Enes Birgin";
            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Enes Birgin";

            bool result3 = sentence.EndsWith("Ğ");
            bool result4 = sentence.StartsWith("My name");

            var result5 = sentence.IndexOf("name");
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf("");
            var result8 = sentence.Insert(0, "Hello, ");
            var result9 = sentence.Substring(3,4);
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace("", "-");
            var result13 = sentence.Remove(2,4);
            Console.WriteLine(result2);
        }
    }
}
