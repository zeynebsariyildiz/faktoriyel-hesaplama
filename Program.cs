using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktoriyel_hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Lütfen Bir Sayı Giriniz:");
            double sayi = Convert.ToInt32(Console.ReadLine());
            double faktoriyel = 1;

            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel = faktoriyel * i;
            }

            Console.WriteLine("{0} Sayısının Faktöriyeli={1}", sayi, faktoriyel);
            Console.ReadLine();
            //gayet güzel olmuş
        }
    }
}
