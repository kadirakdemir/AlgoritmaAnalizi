using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubblesort
{
    class Program
    {
        public static void bubblesort(int[] alist)
        {
            int karsilastirma = 0;
            int yerdegistirme = 0;
            for (int i = 0; i < alist.Length-1; i++)
            {
                for (int j = 1; j < alist.Length-i; j++)
                {
                    karsilastirma++;
                    if (alist[j]<alist[j-1])
                    {
                        yerdegistirme++;
                        int gecici = alist[j - 1];
                        alist[j - 1] = alist[j];
                        alist[j] = gecici;
                    }
                }
            }
            Console.WriteLine("Karşılaştırma Sayısı:"+karsilastirma);
            Console.WriteLine("Yerdeğiştirme Sayısı:"+yerdegistirme);
           // Console.ReadLine();
        }

        static void Main(string[] args)
        {            
            Console.Write("Boyut Giriniz :");
            int boyut=Convert.ToInt32(Console.ReadLine());

            int[] array = new int[boyut];
            Random rnd = new Random();
            for (int i = 0; i < boyut; i++)
            {
                array[i] = rnd.Next(-1000,1000);
                Console.WriteLine(array[i]);
            }
           
            DateTime baslangiczamani = DateTime.Now;
            bubblesort(array);
            DateTime bitiszamani = DateTime.Now;
           
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(j + ".item "+ array[j]);
            }

            Console.WriteLine("n kare :"+ boyut*boyut+" Süre :  "+bitiszamani.Subtract(baslangiczamani));
            Console.ReadLine();
        }
    }
}
