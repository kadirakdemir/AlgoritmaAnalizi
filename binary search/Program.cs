using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev3
{
   class Program
     {    
        static int hesapla(int[] dizi)
        {
            Random rnd = new Random();
            int orta;
            int kucuk = 0;
            int buyuk = dizi.Length - 1;
            int aranansayi = rnd.Next(1,dizi.Count());
            int say = 0;
            while (kucuk <= buyuk)
            {
                say += 1;
                orta = (kucuk + buyuk) / 2;
                if (aranansayi == dizi[orta])
                {  
                    Console.WriteLine("Aradığınız sayı dizinin {0} .elemanı  " , orta);
                    return say;
                }
                else if (aranansayi < dizi[orta])
                    buyuk = orta - 1;
                else
                    kucuk = orta + 1;
            }
            return 0;
        }
         static void Main(string[] args)
         {
            int deger = 10;
            for (int k = 0; k < 6; k++)
            {
                int[] dizi = new int[deger];
                for (int i = 0; i < dizi.Length; i++)
                {
                    dizi[i] = i + 1;
                }
                DateTime baslangiczamani = DateTime.Now;
                int say= hesapla(dizi);
                DateTime bitiszamani = DateTime.Now;
                Console.WriteLine(bitiszamani.Subtract(baslangiczamani));
                Console.WriteLine(say);
                Console.ReadKey();
                deger = 10 * deger;
            }
         } 
     } 
}
