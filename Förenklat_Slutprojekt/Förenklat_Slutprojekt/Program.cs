using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Förenklat_Slutprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> djurlista = new List<string>();
            Console.WriteLine("---=== Fantasy Races ===---");
            Console.WriteLine("Skriv först in hur många djur du vill lägga till i listan!");
            string DjurAntal = ""; //Stringen är lika med användarens input.
            int Antal = 0;
            bool isNumeric = int.TryParse(DjurAntal, out Antal); //Detta gör så att man kan kolla om man använder nummer eller bokstäver. Då den tar in ElevAntal och tryparsear den.

            while (isNumeric == false) //.Length används för att mäta hur många symboler som används.
            {
                Console.Write("Skriv antal djur som du vill skapa:  ");
                DjurAntal = Console.ReadLine();
                isNumeric = int.TryParse(DjurAntal, out Antal);

                if (isNumeric == false) //Så länge boolen "isNumeric" är false så körs denna if- sats, alltså är det användaren skrev in inte ett nummer.
                {
                    Console.WriteLine("Det där var inte ett giltigt tal!");
                }

            }
            djurlista.Add(DjurAntal);

        }
    }
}
