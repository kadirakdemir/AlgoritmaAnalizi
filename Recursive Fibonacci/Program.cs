using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci2
{
    class Program
    {  
        public static int[] fibBuffer = new int[1000];
        public static int fibTopDown(int n)
        {
            if (n < 2)
            {
                return n;
            }
            else if(fibBuffer[n]!=0)
            {
                return fibBuffer[n];
            }
            else
            {
                fibBuffer[n] = fibTopDown(n - 1) + fibTopDown(n - 2);
                return fibBuffer[n];
            }
        }


        static void Main(string[] args)
        {
            int sayi = 0;
            Console.Write("Hesaplanacak Fibonacci Sayısını Giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibonacci Değeri  :" + fibTopDown(sayi));
            Console.ReadKey();
        }
    }
}
