using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_akademi_c_egitimi.ÖRNEKLER
{
    internal class hesap_makinası
    {
        public static void Form()
        {

            int sonuc = 0;

            Console.WriteLine("Toplama islemi icin +");
            Console.WriteLine("Çıkarma işlemi için -");
            Console.WriteLine("Çarpma işlemi için *");
            Console.WriteLine("Bölme işlemi için /");
            Console.Write("yapmak istediğniz işlemi secın :");
            char secim = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("1. değeri giriniz : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. değeri girinz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {

                case '+':
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine("Toplama işleminin sonucu : {0}",sonuc);
                    break;

                case '-':
                 sonuc = sayi1 - sayi2;
                    Console.WriteLine("cıkarma isleminin sonucu : {0}",sonuc);
                    break;

                case '*':
                    sonuc= sayi1 * sayi2; 
                    Console.WriteLine("carpma isleminin sonucu : {0}",sonuc);
                    break; 

                case '/':
                    sonuc= sayi1 / sayi2;
                    Console.WriteLine("bölme isleminin sonucu : {0}", sonuc);
                    break;

                default:
                    Console.WriteLine("Hatalı giris yaptınız !");
                    break;


            }

        }


    }
}
