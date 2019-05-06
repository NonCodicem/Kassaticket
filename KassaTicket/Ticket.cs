using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassaTicket
{
    public enum Betaalwijze { bankcontact, cash, visa }

    class Ticket
    {
        public List<Product> ProductList { get; set; } = new List<Product>();
        public Betaalwijze BetaaldMet { get; set; }
        public string NaamKassier { get; set; }
        public double TotaalPrijs {
            get {
                double totaal = 0;

                foreach (Product p in ProductList)
                {
                    totaal += p.Eenheidsprijs;
                }
                return totaal; }
        }

        public Ticket(string nmKassier, Betaalwijze betaalwijze)
        {
            NaamKassier = nmKassier;
            BetaaldMet = betaalwijze;
        }

        public void DrukTicket()
        {
            Console.WriteLine("KASSATICKET");
            Console.WriteLine("===========");
            Console.WriteLine($"Uw kassier: {NaamKassier}");
            Console.WriteLine();
            foreach (Product p in ProductList)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine($"Totaal: {TotaalPrijs}");

        }
    }
}
