using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Förenklat_Slutprojekt
{
    class Animal
    {
        //Dessa är int variablerna som skulle tas med
        public int speed;//maximalt antal meter per runda djuret kan röra sig
        public int position = 0; //hur många meter djuret rört sig hittills, position skulle alltid börja med 0 (Tror det är så här man gör då?)
        public int energyCurrent;//hur mycket ork djuret har kvar
        public int energyMax;//hur mycket ork djuret har när det är utvilat.

        // Här skapar jag en random generator för att kunna slumpa på värdena. Den är public static så att den kan användas utanför denna klass och delas av Unicorn och TeddyBear.
        public static Random generator = new Random();

        //Dessa är det gemensama metoderna för Unicorn och TeddyBear:

        public void Move()
        {
            if (energyCurrent > 0) // Så länge energyCurrent är större än 0 så kan djuret röra på sig
            {
                position += Animal.generator.Next(1,speed); //Position skulle plussas på med ett slumpmässigt tal mellan 1 och värdet på djurets Speed
                energyCurrent--;
            }

            else if (position > 20) // Detta gör så att så fort position är > 20 så blir den återställd till 20.
            {
                position = 20;
            }
        }

        public void PrintStats() //Metoden skriver helt enkelt ut alla stats som djuren har.
        {
            Console.WriteLine("----- ANIMAL STATS -----");
            Console.WriteLine("Speed: " + speed);
            Console.WriteLine("Position: " + position);
            Console.WriteLine("Current Energy: " + energyCurrent);
        }

        public void Rest()
        {
            energyCurrent = energyMax; //Detta gör så att när rest metoden kallas så blir energyCurrent lika med energyMax
        }

    }
}
