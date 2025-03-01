using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubblesortt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[6];
            Random r = new Random();

            for (int sıra = 0; sıra < 6; sıra++)
            { dizi[sıra] = r.Next(40); }

            Console.WriteLine("Sıralanmamış Dizi :");
            foreach (int eleman in dizi)
                Console.Write(eleman + " ");

            dizi = Kabarcik_Siralama_Algoritmasi(dizi);

            Console.WriteLine("Dizinin Son Hali :");
            foreach (int eleman in dizi)
                Console.Write(eleman + " ");

            Console.ReadKey();
        
    }
        static int[] Kabarcik_Siralama_Algoritmasi(int[] islenecekDizi)
        {
            Console.WriteLine("\n\nAdım adım sonuçlar :");
            int gecici = 0;
            for (int i = 0; i < islenecekDizi.Count(); i++)
            {
                Console.WriteLine((i + 1) + ". Adım");
                for (int j = 0; j < islenecekDizi.Count() - (i + 1); j++)
                {
                    if (islenecekDizi[j] > islenecekDizi[(j + 1)])
                    {
                        gecici = islenecekDizi[j];
                        islenecekDizi[j] = islenecekDizi[j + 1];
                        islenecekDizi[j + 1] = gecici;
                    }

                    //diziyi yazdırma
                    foreach (int eleman in islenecekDizi)
                        Console.Write(eleman + " ");

                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            return islenecekDizi;
        }

    }
}
