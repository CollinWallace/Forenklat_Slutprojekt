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
            List<Animal> djurlista = new List<Animal>(); //Skapar en lista för djuren
            Console.WriteLine("---=== Fantasy Races ===---");
            Console.WriteLine("Skriv först in hur många djur du vill lägga till i listan!");
            string DjurAntal = ""; //Stringen är lika med användarens input.
            int Antal = 0;
            bool isNumeric = int.TryParse(DjurAntal, out Antal); //Detta gör så att man kan kolla om man använder nummer eller bokstäver. Då den tar in DjurAntal och tryparsear den.

            while (isNumeric == false || DjurAntal.Length > 0) //.Length används för att mäta hur många symboler som används. Och så att man inte kan skriva en bokstav (False)
            {
                Console.Write("Skriv antal djur som du vill skapa:  ");
                DjurAntal = Console.ReadLine();
                isNumeric = int.TryParse(DjurAntal, out Antal);

                if (isNumeric == false) //Så länge boolen "isNumeric" är false så körs denna if- sats, alltså är det användaren skrev in inte ett nummer.
                {
                    Console.WriteLine("Det där var inte ett giltigt tal!");
                }
                if(DjurAntal.Length > 0)
                {
                    Console.WriteLine("Antalet djur kan inte vara 0!");
                }

            }

            for (int counter = 0; counter < Antal; counter++) //Denna for loop kommer att loopas så länge int counter är mindre än Antal (Som är användarens input).
            {
                int i = Animal.generator.Next(1, 3); //Jag tar random genaratorn från Animal classen och genererar ett tal mellan 1 och 3. Logiken funkar inte om det är mellan 1,2

                if (i == 1) //om generator är lika med 1 så skapas en instans av TeddyBear klassen och den lägs in i listan
                {
                    djurlista.Add(new TeddyBear());
                }
                    
                if(i == 2)//om generator är lika med 2 så skapas en instans av Unicorn klassen och den lägs in i listan
                {
                    djurlista.Add(new Unicorn());
                }
            }

            Animal djurRace;
            djurRace = djurlista[Animal.generator.Next(djurlista.Count)];//Den slumpar ett tal beroende på antalet platser i listan, därför man använder .count

            int count = 0; // denna int är till för att räkna rundorna

            while (djurRace.position<20) //Så länge djuren är under position 20 så körs loopen. Då position 20 är mållinjen
            {
                string input = Console.ReadLine(); //Användarens input från Readline lagras i stringen input.
                djurRace.PrintStats(); //Detta anropar metoden PrintStats och skriver då ut djurens stats.

                Console.WriteLine("-----Runda nummer: " + count +"-----"); //detta visar då rundan i consolen
                Console.WriteLine("Skriv '1' om du vill röra dit djur framåt" );
                Console.WriteLine("Skriv '2' om du vill låta ditt djur vila");
                if (input =="1") //om användarens input är lika med 1 så rörs sig djuret enligt sin Move metod.
                {
                    djurRace.Move();
                }

                if (input == "2") //Om användarens input är lika med 2 så anropas djurets Rest metod.
                {
                    djurRace.Rest();
                }

                else //Om man skriver något annat än "1" eller "2" så tas man tillbaka till att skriva in ett input.
                {
                    Console.WriteLine("Du måste välja antingen 1 eller 2.. Försök igen:");
                    input = Console.ReadLine();
                }
            }
                    
        }
    }
}
