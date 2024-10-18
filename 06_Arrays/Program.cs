using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            // DeğişkenTürü [] DiziAdı = new DeğişkenTürü[elemansayısı]

            //string[] colors = new string[4];
            //colors[0] = "kırmızı";
            //colors[1] = "sarı";
            //colors[2] = "beyaz";
            //colors[3] = "mavi";

            //Console.WriteLine(colors[3]);

            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;                // atamadığımız 4, 5, 6, 8, 9 numaralı indisler 0 olarak set edilir.
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;

            //Console.WriteLine(numbers[5]);

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };

            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizilerdeki tüm elemanları listeleme

            //string[] colors = { "Sarı", "Lacivert", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++) 
            //{ 
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0 )
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            //int maxNumber=myArray[0];

            //for (int i = 1; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}         

            //Console.WriteLine(maxNumber);

            //string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };

            //Console.WriteLine(persons.Length);

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 34 };

            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 34 };
            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi metotları

            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };

            //int index = Array.IndexOf(customers, "çınar");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };

            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max() + " Dizinin En Küçük elemanı: " + numbers.Min());

            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write(i+1 + ". şehri giriniz: "); // Console.Write($"Lütfen {i+1}. şehri giriniz: "); şeklinde de yazılabilir
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(i + 1 + ". şehir: "+ cities[i]);
            //}
             
            //int[] number = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < number.Length; i++)
            //{
            //    sum += number[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            //Console.WriteLine("ÇİFT SAYILAR");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("TEK SAYILAR");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion
            Console.Read();
        }
    }
}
