using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    public class Hash
    {

        List<Object>[] dizi;
        int kapasite; 

        public Hash(int boyut) {

            this.dizi = new List<object>[boyut];

            for(int i = 0; i < boyut; i++)
            {
                this.dizi[i] = null;
            }
            this.kapasite = boyut;

        }

        public void HashYenidenBoyutlandir()
        {
            List<Object>[] yenidizi=new List<object>[this.dizi.Length];

            
           int yeniBoyut = this.dizi.Length*2;
           yenidizi = new List<object>[yeniBoyut];
           for (int k = 0; k<yeniBoyut; k++)
           {
               yenidizi[k] = null;
           }            

            int i = 0;
            foreach(List<object> değer in this.dizi)
            {
                yenidizi[i] = değer;
                i++;
            }
            this.dizi = yenidizi;
        }

        public void HashYaz()
        {
           for(int i = 0; i < this.dizi.Length; i++)
            {
                if (this.dizi[i] == null) Console.WriteLine(" Boş ");
                else
                {
                    foreach( object obj in dizi[i])
                    {
                        Console.Write(" {0} ",obj);
                    }
                    Console.WriteLine();
                }
            } 
        }

        public int  HashFonksiyonu(object x)
        {
            Type type = x.GetType();
            if (type == typeof(string))
            {
                int toplam = 0;
                foreach(char i in x.ToString())
                {
                    toplam += i;
                }
                return toplam % this.dizi.Length;
            }
            else if (type == typeof(int))
            {
                return Convert.ToInt32(x)% this.dizi.Length;
            }

            else
            {
                return -1;
            }
            
        }

        public void hasteAra( object aranacak)
        {

            Type type = aranacak.GetType();
            if (type == typeof(string) || type == typeof(int))
            {
                int aranan_index = this.HashFonksiyonu(aranacak);
                if (this.dizi[aranan_index] == null)
                {
                    Console.WriteLine("Aranan Eleman Bulunamadı");
                }
                else
                {
                    Console.Write("Aranan eleman dizinin {0} . elemandaki liste içerisinde ve",aranan_index);
                    int sayac=1;
                    foreach(object i in this.dizi[aranan_index])
                    {
                        if (i == aranacak)
                        {
                            Console.WriteLine("listedeki sırası {0}",sayac);
                            break;
                        }
                        sayac++;
                    }
                }
            }
            else
            {
                Console.WriteLine("Aranacak Tip Yok");
            }
       }

        public bool HashDolumu()
        {
            for(int i=0; i < this.kapasite; i++)
            {
                if (this.dizi[i] == null)
                {
                    return false;
                }
            }
            return true;
        }

        public void HasheEkle(object eklenecekEleman)
        {
            Type type = eklenecekEleman.GetType();
            if (type == typeof(string) || type == typeof(int))
            {
                if (this.HashDolumu())
                {
                    this.HashYenidenBoyutlandir();
                }

                int eklenecegiIndex = this.HashFonksiyonu(eklenecekEleman);
                if (this.dizi[eklenecegiIndex] == null)
                {
                    List<object> yeniListe = new List<object>();
                    yeniListe.Add(eklenecekEleman);
                    this.dizi[eklenecegiIndex] = yeniListe;
                }

                else
                {
                    this.dizi[eklenecegiIndex].Add(eklenecekEleman);
                }                
            }

            else
            {
                Console.WriteLine("Hashe sadece string veya integer eklenebilir.");                
            }
        }
    }

    class Program
    {

        static void Main(string[] args)
        {   
            Console.WriteLine("Hash tablosunun boyutunu giriniz : ");
            int boyut = Convert.ToInt32(Console.ReadLine());
            Hash yeniHash = new Hash(boyut);
            yeniHash.HasheEkle(50);
            yeniHash.HasheEkle(100);
            yeniHash.HasheEkle("Trabzonspor");
            yeniHash.HasheEkle("İstanbul");
            yeniHash.HashYaz();
            Console.ReadKey();

        }
    }
}
