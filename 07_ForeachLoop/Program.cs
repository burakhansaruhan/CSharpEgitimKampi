﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            // Foreach(1,2,3,4)
            // 1: Değişken türü
            // 2: Değişken adı
            // 3: In
            // 4: Liste, koleksiyon, dizi

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int sum = 0;

            //foreach (int i in numbers)
            //{
            //    sum += i;
            //}

            //Console.WriteLine(sum);

            //List<int> numbers = new List<int>()
            //{
            //    1,2, 3, 4, 5, 8
            //};

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //string word = "merhaba";

            //foreach (char s in word)
            //{
            //    Console.WriteLine(s);
            //}



            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("***** C# Eğitim Kampı Uygulama *****");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("------------------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------");

            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"       {i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();
                Console.WriteLine();

                double totalExamResult = 0;

            for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j+1}. Sınav Notunu Giriniz: ");
                    double value=double.Parse(Console.ReadLine());
                    totalExamResult += value;
                    Console.WriteLine();
                }
                Console.WriteLine("------------------------------------------");
                studentExamAvg[i] = totalExamResult / 3;

            }

            Console.WriteLine();
            for (int i = 0;i < studentCount;i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması {studentExamAvg[i]}") ;
                Console.WriteLine();
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} dersi geçti.") ;
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} dersten kaldı.");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");



            #endregion
            Console.Read();
        }
    }
}