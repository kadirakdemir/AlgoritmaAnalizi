using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birler
{
    class Program
    {
        static void Main(string[] args)
        {
            int gecici = 0;
            int birler = 0;
            int satır = 0;
            Console.Write("Kaç satır olsun:");
            satır = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[,] dizi = new int[satır, 100];
            int[] dizi2 = new int[100];
            Random rnd = new Random();
            for (int i = 0; i < satır; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    dizi[i, j] = rnd.Next(0, 2);
                   
                    Console.Write(dizi[i,j]);            
                }
                Console.WriteLine();
            }

            for (int k = 0; k < 100; k++)
            {
                for (int l = 0; l < satır; l++)
                    if (dizi[l, k] == 1)
                    {
                        birler++;
                    }
                dizi2[k] = birler;
                birler = 0;
            }

            int değer = 0;
            int sütun = 0;
            for (int h = 0; h < satır; h++)
            {
               gecici= dizi2[h];
                if (gecici>=değer)
                {
                    değer = gecici;
                    sütun = h+1;
                }
                
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(sütun);
            Console.ReadKey();
        }
    }
}
