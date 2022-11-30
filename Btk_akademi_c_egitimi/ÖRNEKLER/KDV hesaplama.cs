using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_akademi_c_egitimi.ÖRNEKLER
{
    public class KDV_hesaplama
    {
        public static void Form()
        {
            Console.WriteLine("Parcanın Adını Giriniz :");
            string tip= Console.ReadLine(); 
            Console.WriteLine("KDV Oranını yuzde olarak girirniz : ");
            
            int kdv = int.Parse(Console.ReadLine());
            Console.WriteLine("Fiyatı giriniz :");
            int fiyat = int.Parse(Console.ReadLine());


            Console.WriteLine();

            double toplam =(fiyat*1.88* (kdv + 100)) / 100;
            Console.WriteLine("Toplam Ödeyeceğiniz " + tip + " Fiyatı = " + toplam);
        }
    }
}
