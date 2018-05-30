using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Soru
{
    class Program
    {
        public static int Faktoriyel(int sayi)
        {
            if (sayi == 0)
            {
                return 1;
            }

            return sayi * Faktoriyel(sayi - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Başlangıç sayısı girip enter tuşuna basınız :");
            int baslangic = Convert.ToInt32(Console.ReadLine());
            List<int> dizi = new List<int>();
            for (int i = 0; i < baslangic; i++)
            {
                dizi.Add(Faktoriyel(i + 1));
                foreach (var item in dizi)
                {
                    Console.Write(item + " ");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
