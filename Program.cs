using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.rpg.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            Guerreiro Gus = new Guerreiro("Gus, o imortal", 17, 23, 15);
            Mago JoJo = new Mago("JoJo, o arcano", 15, 14, 25);
            Arqueiro Lamps = new Arqueiro("Lamps, o calculista", 19, 16, 21);

            Console.Write(Gus.ToString());
            Console.Write(JoJo.ToString());
            Console.Write(Lamps.ToString());
        }
    }
}
