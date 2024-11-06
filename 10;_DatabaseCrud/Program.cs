using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace _10__DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crud create-read-update-delete

            #region Kategori Ekleme İşlemi
            //Console.WriteLine("***** Menü Sipariş İşlem Paneli*****");
            //Console.WriteLine();

            //Console.WriteLine("------------------------");
            //Console.WriteLine("Eklemek istediğiniz kategori adı: ");
            //string categoryName=Console.ReadLine();

            //NpgsqlConnection connection = new NpgsqlConnection("server=localHost; port=5432; Database=Kamp; user ID=postgres; password=1234");
            //connection.Open();
            //NpgsqlCommand command = new NpgsqlCommand("insert into tblcategory (categoryid,CategoryName) values (11,@p1)", connection);


            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori başarıyla eklendi");

            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün adı: ");
            //productName = Console.ReadLine();

            //Console.Write("Ürün Fiyatı: ");
            //productPrice=decimal.Parse(Console.ReadLine());

            //NpgsqlConnection connection = new NpgsqlConnection("server=localHost; port=5432; Database=Kamp; user ID=postgres; password=1234");
            //connection.Open();
            //NpgsqlCommand command = new NpgsqlCommand("insert into tblproduct (productid,productName, productPrice, productStatus) values (12,@productName,@productPrice, @productStatus)", connection);
            //command.Parameters.AddWithValue("@productName",productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Ürün ekleme başarılı!");

            #endregion

            #region Ürün Listeleme İşlemi


            //NpgsqlConnection connection = new NpgsqlConnection("server=localHost; port=5432; Database=Kamp; user ID=postgres; password=1234");
            //connection.Open();
            //NpgsqlCommand command = new NpgsqlCommand("select * from tblproduct",connection);
            //NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString()+" ");
            //    }
            //    Console.WriteLine();
            //}

            //command.ExecuteNonQuery();
            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün Id: ");
            //int productId=int.Parse(Console.ReadLine());

            //NpgsqlConnection connection = new NpgsqlConnection("server=localHost; port=5432; Database=Kamp; user ID=postgres; password=1234");
            //connection.Open();
            //NpgsqlCommand command = new NpgsqlCommand("delete from tblproduct where productId=@productId",connection);
            //command.Parameters.AddWithValue("@productId",productId);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kayıt Silindi");



            #endregion

            #region Güncelleme

            //Console.Write("Güncellenecek ürün Id giriniz: ");
            //int productId=int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek ürün adı giriniz: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek ürün fiyatı giriniz: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //NpgsqlConnection connection = new NpgsqlConnection("server=localHost; port=5432; Database=Kamp; user ID=postgres; password=1234");
            //connection.Open();
            //NpgsqlCommand command = new NpgsqlCommand("update tblproduct set productName=@productName,productPrice=@productPrice where productId=@productId", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Güncelleme tamamlandı");

            #endregion
            Console.Read();
        }
    }
}
