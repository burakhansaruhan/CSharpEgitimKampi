using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar

            //()
            //Geriye değer döndürmeyen metotlar - void

            //void CustomerList()
            //{
            //    Console.WriteLine("Burakhan");
            //    Console.WriteLine("Saruhan");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar

            //void writeMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //writeMethod("Burakhan Saruhan");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Musteri: " + name + " " + surName);
            //}

            //CustomerCard("Burakhan", "Saruhan");

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string StudentCard()
            //{
            //    string name = "Burakhan";
            //    string surName = "Saruhan";

            //    return name+" "+surName;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo= "Ülke: " + countryName + " - Başkent: " + capital +" - Bayrak Rengi: " + flagColor;

            //    return cardInfo;
            //}
            //string x, y, z;

            //Console.Write("Ülke adı giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkent adı giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak rengi giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            #endregion

            #region Ornek Uygulama

            //string CourseResult (string studentName, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;

            //    if (result < 50)
            //    {
            //        return studentName + " " + result + " ortalamasıyla dersi geçemedi";
            //    }

            //    else
            //    {
            //        return studentName + " " + result + " ortalamasıyla dersi geçti";
            //    }
            //}

            //Console.WriteLine(CourseResult("Burakhan",90,30,60));

            #endregion
            Console.Read();
        }
    }
}
