using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tersten
{
    
    class Program
    {
        
       static char[,] tut = new char[4, 4];
       static char[,] array = new char[4, 4]
        {
                {'a','a','a','a' },
                {'a','t','b','c' },
                {'a','t','t','a' },
                {'e','f','c','e' }
        };

        static int[] a=new int[] { 1,2,3,4};
        static int k = 0,t=0;
        static int hesapla(int s)
        {
            if (s==-1 & t==4)
            {
                if (k >= 3)
                {
                    return 0;
                }
                else
                {
                    k++; s = 4; t = 0;
                }
                Console.WriteLine();
                return hesapla(s - 1);
            }
            else
            {
                if (array[k,t] ==array[k,s])
                {
                    Console.Write(array[k, s]);
                }
                t++;
                return hesapla(s-1);
            }
          
        }
       static int rec_fonk(int deger)
        {
            if (deger == 0) return 1;
            else
            {
                Console.WriteLine(deger);
                return  deger * rec_fonk(deger-1);
            }
            
        }

        static int fibonacci(int sayi)
        {
            if (sayi == 0) return 0;
            else if (sayi == 1) return sayi = 1;
            else return fibonacci(sayi - 1) + fibonacci(sayi-2);
        }
        public void Palindrome()
        {
           
        }

        public static void Tersten()
        {
            int sıra;           
            for (int i = 0; i < 4; i++)
            {
                sıra = 3;
                for (int j = 0; j < 4; j++)
                {
                    if (array[i, j] == array[i, sıra])
                    {
                        tut[i, j] = array[i, j];
                    }
                    else { break; }
                    if (sıra == 0)
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            Console.Write(array[i, k]);
                        }
                    }
                    sıra--;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        //static void Main(string[] args)
        //{

        //    // Tersten();
        //    //Console.WriteLine( rec_fonk(5));
        //    //Console.WriteLine(fibonacci(6));
        //    Console.WriteLine(hesapla(3));
        //    Console.WriteLine();
        //    Console.ReadKey();
        //}
    }
}
