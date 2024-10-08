using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //int i;

            //for(i=1; i<=5; i++)
            //{
            //    Console.WriteLine(i+"-C# Eğitim Kampi");
            //}

            //for (int i = 3; i <=50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}


            //Console.Write("Lütfen ekrana kaç defa yazılması istediğini giriniz: ");
            //int finishValue=int.Parse(Console.ReadLine());

            //for(int i = 0; i < finishValue; i++)
            //{
            //    Console.WriteLine(i+1 +"-YAŞASIN CUMHURİYET");
            //}
            #endregion

            #region For Döngüsü İle karar Yapıları

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;

            //for (int i = 1; i <=10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            //int totalValue = 0;
            //for (int i = 1; i <20; i++)
            //{
            //    if (i%2==0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }              
            //}
            //Console.WriteLine("Toplam:" + totalValue);

            //int count = 0;
            //for (int i = 1; i < 50; i++)
            //{
            //    if (i%7 == 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);

            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ". Saat Sonunda " + bacterium + " bakteri var.");
            //}

            #endregion

            #region While Döngüsü

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i + "-Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;
            //while (i < 50)
            //{
            //    if (i%3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //    Console.WriteLine(sum);


            #endregion

            #region Örnek Sınav Sorusu
            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.
            // örn: 456 çıktı:15

            Console.Write("3 basamaklı bir sayı giriniz: ");
            int number=int.Parse(Console.ReadLine());

            int result = 0;
            result += number % 10;
            result += number % 100 / 10;
            result += number / 100;

            Console.WriteLine(result);

            #endregion
            Console.Read();
        }
    }
}
