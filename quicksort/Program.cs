using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quicksort
{
    public class Program
    {
        static int q;
        public static void quick_sort(int[] dizi, int başlangıç, int bitiş)
        {
            if (başlangıç < bitiş)
            {
                partition(dizi, başlangıç, bitiş);
                quick_sort(dizi, başlangıç, q);
                quick_sort(dizi, q + 1, bitiş);
            }
        }
        public static void partition(int[] dizi, int başlangıç, int bitiş)
        {
            int x = dizi[başlangıç];
            int i = başlangıç - 1;
            int j = bitiş + 1;
            int say = 0;
            while (true)
            {
                
                do
                {
                    j--;
                }
                while (dizi[j] > x);

                do
                {
                    i++;
                }
                while (dizi[i] < x);

                if (i < j)
                {
                    int gecici = dizi[i];
                    dizi[i] = dizi[j];
                    dizi[j] = gecici;
                    say++;                   
                }                
                else
                {
                    q = j;
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
           // int [] dizi1 = { 2, 17, -4, 42, 9, 26, 11 };
            Console.Write("Dizi boyutunu giriniz : ");
            int boyut = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[boyut];
            Random rnd = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(-1000,1000);
            }

            Console.WriteLine();
            DateTime başlangıçzamanı=DateTime.Now;
            quick_sort(dizi,0,dizi.Length-1);
            DateTime bitişzamanı = DateTime.Now;
            Console.WriteLine("Bitiş zamanı : "+bitişzamanı.Subtract(başlangıçzamanı));
            Console.ReadLine();
        }
    }
}
