using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Förenklat_Slutprojekt
{
    class Unicorn:Animal //Detta gör så att Uncicorn ärver från Animal classen
    {
        public Unicorn() //Detta är konstruktorn för TeddyBear klassen och den anropas automatiskt när en instans skapas
        {
            position = Animal.generator.Next(2,10); //Detta genrerar ett tal mellan 2,10 som då blir antalet steg som djuret tar
            speed = 0;
            energyMax = Animal.generator.Next(10, 13); //Detta genererar ett tal som ska bli djurets max energi
            energyCurrent = energyMax; //Gör så att när djuret skapas så är energy current lika med energy max

            Console.WriteLine("Du skapade en Unicorn");
        }


    }
}
