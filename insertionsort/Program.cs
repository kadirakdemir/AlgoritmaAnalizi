using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertionsort
{
    class Program
    {
        public static void insertionsort(int[] alist)
        {
            int karşılaştırma = 0;
            int yerdeğiştirme = 0;
            for (int i = 0; i < alist.Length; i++)
            {
                int taşınan = alist[i];
                int pozisyon = i-1;
                while (pozisyon>=0 && alist[pozisyon]>taşınan)
                {
                    karşılaştırma ++;
                    yerdeğiştirme ++;
                    alist[pozisyon + 1] = alist[pozisyon];
                    pozisyon --;
                }
                alist[pozisyon + 1] = taşınan;
              
            }

            Console.WriteLine("Karşılaştırma Sayısı:" + karşılaştırma);
            Console.WriteLine("Yerdeğiştirme Sayısı:" + yerdeğiştirme);
            
        }
        static void Main(string[] args)
        {
            Console.Write("Boyut Giriniz :");
            int boyut = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[boyut];
            Random rnd = new Random();
            for (int i = 0; i < boyut; i++)
            {
                array[i] = rnd.Next(-1000, 1000);
                Console.WriteLine(array[i]);
            }
            
            DateTime baslangıczamanı = DateTime.Now;
            insertionsort(array);
            DateTime bitişzamanı = DateTime.Now;

            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(j + ".item " + array[j]);
            }

            Console.WriteLine("n kare :" + boyut * boyut + " Süre :  " + bitişzamanı.Subtract(baslangıczamanı));
            Console.ReadLine();
        }
    }
}
