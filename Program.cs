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
            Console.WriteLine("Boas-vindas!\n");
            Console.WriteLine("--------Personagens--------");

            Guerreiro Gus = new Guerreiro("Gus", 17, 23, 15);
            Arqueiro Lamps = new Arqueiro("Lamps", 19, 16, 21);
            Mago JoJo = new Mago("JoJo", 15, 14, 25);

            Console.WriteLine(Gus.ToString());
            Console.WriteLine(Lamps.ToString());
            Console.WriteLine(JoJo.ToString());

            Console.WriteLine("");

            Console.WriteLine(Gus.Atacar(3));
            Console.WriteLine(Lamps.Atacar());
            Console.WriteLine(JoJo.Atacar());

            Console.ReadKey();
        }
    }
}
