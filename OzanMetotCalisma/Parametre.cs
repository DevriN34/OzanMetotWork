using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzanMetotCalisma
{
    internal class Parametre
    {
        public void ekle(Customers customers)
        {
           Console.WriteLine(customers.ad+customers.soyad+customers.ID+"başarıyla eklendi");
        }
        public void listele(Customers customers)
        {
            Console.WriteLine(customers.ad);
            Console.WriteLine(customers.soyad);
            Console.WriteLine(customers.ID);
        }
        public void sil(Customers customers) 
        {
            Console.WriteLine(customers.ad+customers.soyad+customers.ID+"Başarıyla silindi");
        }
    }
}
