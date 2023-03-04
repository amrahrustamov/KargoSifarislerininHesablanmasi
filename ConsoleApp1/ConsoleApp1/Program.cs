using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orderTypes = 3;

            string firstShoesName = "Adidas";
            int firstOrderCount = 4;
            int firstOrderPrice = 200;
            int firstTotalPrice = firstOrderCount * firstOrderPrice;

            string secondShoesName = "Gucci";
            int secondOrderCount = 2;
            int secondOrderPrice = 1000;
            int secondTotalPrice = secondOrderCount * secondOrderPrice;

            string thirdShoesName = "Nike";
            int thirdOrderCount = 1;
            int thirdOrderPrice = 150;
            int thirdTotalPrice = thirdOrderCount * thirdOrderPrice;


            Console.WriteLine("Firma : ");
            Console.WriteLine(firstShoesName);
            Console.WriteLine("Ayaqqabi sayi :");
            Console.WriteLine(firstOrderCount);
            Console.WriteLine("Birinin qiymeti ($) :");
            Console.WriteLine(firstOrderPrice);
            Console.WriteLine("Hamisinin birlikde qiymeti ($) :");
            Console.WriteLine(firstTotalPrice);


            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Firma : ");
            Console.WriteLine(secondShoesName);
            Console.WriteLine("Ayaqqabi sayi :");
            Console.WriteLine(secondOrderCount);
            Console.WriteLine("Birinin qiymeti ($) :");
            Console.WriteLine(secondOrderPrice);
            Console.WriteLine("Hamisinin birlikde qiymeti ($) :");
            Console.WriteLine(secondTotalPrice);


            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Firma : ");
            Console.WriteLine(thirdShoesName);
            Console.WriteLine("Ayaqqabi sayi :");
            Console.WriteLine(thirdOrderCount);
            Console.WriteLine("Birinin qiymeti ($) :");
            Console.WriteLine(thirdOrderPrice);
            Console.WriteLine("Hamisinin birlikde qiymeti ($) :");
            Console.WriteLine(thirdTotalPrice);


            Console.ReadLine();
        }
    }
}