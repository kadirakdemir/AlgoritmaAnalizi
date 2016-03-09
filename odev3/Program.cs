using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev3
{
    class Program
    {
   
        static void Main(string[] args)
        {
            int[] dizi = new int[2000000];
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = i+1;                        
            }

            int orta;
            int kucuk = 0;
            int buyuk = dizi.Length - 1;
            int aranansayi = 62;
            int say = 0;
            DateTime baslangiczamani=DateTime.Now;
            DateTime bitiszamani = DateTime.Now;
           TimeSpan sure;
            while (kucuk <= buyuk)
            {
                say += 1;
                orta = (kucuk + buyuk) / 2;
                if (aranansayi == dizi[orta])
                {
                    sure = bitiszamani - baslangiczamani;
                    Console.WriteLine("Aradığınız sayı dizinin {0} .elemanı",orta);
                    Console.WriteLine(say);
                    //Console.WriteLine(sure);
                    Console.WriteLine(bitiszamani.Subtract(baslangiczamani).TotalSeconds);
                    break;
                }
                else if (aranansayi < dizi[orta])
                    buyuk = orta - 1;
                else
                    kucuk = orta + 1;
            }
            
            Console.ReadKey();
        }
    }
}
