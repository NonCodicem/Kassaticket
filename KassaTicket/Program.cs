using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassaTicket
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Ticket ticket = new Ticket("Ben", Betaalwijze.bankcontact);
            Product appel = new Product("appel", 0.30, "P12345");
            Product advacado = new Product("advacado", 0.90, "P12347");
            Product bananen = new Product("bananen", 1.20, "P23467");
            ticket.ProductList.Add(appel);
            ticket.ProductList.Add(advacado);
            ticket.ProductList.Add(bananen);

            //Product advacado = new Product("advacado", 0.90, "P1234");
            Console.WriteLine(appel.ToString());
            Console.WriteLine(Product.ValideerCode("P1234"));
            Console.WriteLine(Product.ValideerCode("P12345"));
            ticket.DrukTicket();
            Console.ReadKey();
        }
    }
}
