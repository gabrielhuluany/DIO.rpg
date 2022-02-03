using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.rpg.Entities
{
    public class Arqueiro : Personagem
    {

        public Arqueiro(string Nome, int Nivel, int Vida, int Forca) : base(Nome, Nivel, Vida, Forca)
        {

        }

        public override string Atacar()
        {
            return this.Nome + " acertou uma flecha no slime e causou " + this.Forca + " de dano!\n";
        }
    }
}
