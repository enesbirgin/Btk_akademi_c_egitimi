using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_akademi_c_egitimi.ÖRNEKLER
{
    internal class hesap_makinası2
    {
        public static void Form()
        {

            int sonuc = 0;

            Console.WriteLine("Toplama islemi icin +");
            Console.WriteLine("Cıkarma islemi icin -");
            Console.WriteLine("carpma islemi icin *");
            Console.WriteLine("bölme islemi icin /");
            Console.Write("Yapmak isteoiğiniz islemi seciniz :");
            char secim = Convert.ToChar(Console.ReadLine());


            Console.Write("1. değeri giriniz : ");
            int sayi1  = Convert.ToInt16(Console.ReadLine());
            Console.Write("2. değeri giriniz :");
            int sayi2 = Convert.ToInt16(Console.ReadLine());

            switch (secim)
            {

                case '+':
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine("toplama islemının sonucu : {0}", sonuc);
                    break;

                case '-':
                    sonuc = sayi1 - sayi2;
                    Console.WriteLine("cıkarma islemının sonucu : {0}", sonuc);
                    break;

                case '*':
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine("carpma isleminin sonucu : {0}", sonuc);
                    break;

                case '/':
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine("bölme isleminin sonucu : {0}", sonuc);
                    break;

                    default:
                    Console.WriteLine("YANLIS ISLEM GİRDİNİZ ");
                    break;

            }
        }
    }
}
