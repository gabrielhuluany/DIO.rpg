using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.rpg.Entities
{
    public class Mago : Personagem
    {

        public Mago(string Nome, int Nivel, int Vida, int Forca) : base(Nome, Nivel, Vida, Forca)
        {

        }

        public override string Atacar()
        {
            return this.Nome + " lançou uma bola de fogo no slime e causou " + this.Forca + " de dano!\n";
        }
    }
}
