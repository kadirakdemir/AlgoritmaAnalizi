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
            Console.WriteLine("kaç defa itesayon sayısı ");
            int ite = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dizi boyutu ne olsun ");
            int size = Convert.ToInt32(Console.ReadLine());
            int say = 0;
            for (int j = 0; j < ite; j++)
            {
                Console.WriteLine(j.ToString()+" . iteration yapılıyor .......");
                int[] dizi = new int[size];
                for (int i = 0; i < dizi.Length; i++)
                {
                    dizi[i] = i + 1;
                }

                int orta;
                int kucuk = 0;
                int buyuk = dizi.Length - 1;
                Random r = new Random();

                int aranansayi = r.Next() % size;

                DateTime baslangiczamani = DateTime.Now;
                DateTime bitiszamani = DateTime.Now;
                TimeSpan sure;
                while (kucuk <= buyuk)
                {
                    say += 1;
                    orta = (kucuk + buyuk) / 2;
                    if (aranansayi == dizi[orta])
                    {
                        sure = bitiszamani - baslangiczamani;
                        Console.WriteLine("Aradığınız sayı dizinin {0} .elemanı", orta);
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

                //Console.ReadKey();
               
            }
            Console.WriteLine(" toplam arama sayısı   "+say.ToString()+ "   ortalama  "+(say / ite).ToString());
            Console.ReadKey();
            //Console.ReadKey();
            //Console.ReadKey();
            //Console.ReadKey();
        }
    }
}
