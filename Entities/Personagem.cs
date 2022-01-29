using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.rpg.Entities
{
    public abstract class Personagem
    {
        public string Nome { get; set; }
        public int Nivel { get; set; }
        public int Vida { get; set; }
        public int Forca { get; set; }

        public Personagem(string Nome, int Nivel, int Vida, int Forca)
        {
            this.Nome = Nome;
            this.Nivel = Nivel;
            this.Vida = Vida;
            this.Forca = Forca;
        }

        public virtual string Atacar()
        {
            return this.Nome + " atacou o slime e causou " + this.Forca + " de dano!\n\n";
        }

    }
}
