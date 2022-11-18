using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzanMetotCalisma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customers customers1 = new Customers();
            customers1.ad = "ozana";
            customers1.soyad = "ads";
            customers1.ID = 1;

            Customers customers2 = new Customers();
            customers2.ad = "ahmeta";
            customers2.soyad = "ad1s";
            customers2.ID = 2;

            Customers customers3 = new Customers();
            customers3.ad = "mehmet";
            customers3.soyad = "ad2s";
            customers3.ID = 3;
            Console.WriteLine("****************************");


            Customers[] parametre = new Customers[] { customers2, customers1, customers3 };

            foreach (var customers in parametre)
            {
                Console.WriteLine(customers.ad);
                
            }

            Console.WriteLine("*******************************");

            // Parametre listele = new Parametre();

            //listele.listele(customers);
            //Console.WriteLine("------");
            //listele.listele(customers1);
            //Console.WriteLine("------");
            //listele.listele(customers3);
            //Console.WriteLine("------");

            //listele.ekle(customers);
            //Console.WriteLine("------");
            //listele.ekle(customers1);
            //Console.WriteLine("------");
            //listele.ekle(customers3);

            //listele.sil(customers);
            //Console.WriteLine("------");
            //listele.sil(customers1);
            //Console.WriteLine("------");
            //listele.sil(customers3);




             Console.ReadKey(); 
        }
       
    }
}
