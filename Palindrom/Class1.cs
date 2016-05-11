using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tersten
{
    class Class1
    {
      
        static char[,] array = new char[4,4 ]
         {
                {'a','a','a','a' },
                {'a','t','b','a' },
                {'a','t','t','a' },
                {'a','f','c','a' }
         };
        static int s = 3;
        static int  t=0;
        static int sayac = 0;
        static int sayac2 = 0;
        static bool hesapla(int a,int b)
        {            
            if (s == -1)
            {
                s = 3;  a++;  b = 0;
                Console.WriteLine();
            }

            if (a == 4)
            {
                return true;               
            }
                
            if (array[a,b]==array[a,s])
            {               
                s--; sayac++;
                if (sayac==4)
                {
                    b = 0;
                    while (b != 4)
                    {
                        Console.Write(array[a, b]);
                        b++;
                    }
                    b = -1;  a++; s = 3; sayac = 0;
                } 
                hesapla(a,b+1);
            }
            else
            {
                s--;               
                hesapla(a,b+1);
            }
           
            return true;
        }
        
    }
}
