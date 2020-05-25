using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Förenklat_Slutprojekt
{
    class TeddyBear: Animal //Detta gör så att TeddyBear ärver från Animal classen
    {
        public TeddyBear() //Detta är konstruktorn för TeddyBear klassen och den anropas automatiskt när en instans skapas
        {
            position = Animal.generator.Next(4, 8);//Detta genrerar ett tal mellan 4,8 som då blir antalet steg som djuret tar
            speed = 0;
            energyMax = Animal.generator.Next(6, 10);//Detta genererar ett tal som ska bli djurets max energi
            energyCurrent = energyMax;//Gör så att när djuret skapas så är energy current lika med energy max

            Console.WriteLine("Du skapade en TeddyBear");
        }
    }
}
