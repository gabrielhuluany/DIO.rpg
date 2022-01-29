using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.rpg.Entities
{
    public abstract class Personagem
    {
        public string Nome;
        public int Nivel;
        public int Vida;
        public int Forca;

        public Personagem(string Nome, int Nivel, int Vida, int Forca)
        {
            this.Nome = Nome;
            this.Nivel = Nivel;
            this.Vida = Vida;
            this.Forca = Forca;
        }

        public override string ToString()
        {
            return ("Nome: " + this.Nome + "\nNível: " + this.Nivel + "\nVida: " + this.Vida + "\nForça: " + this.Forca + "\n\n");
        }

        public virtual string Atacar()
        {
            return this.Nome + " atacou o slime e causou " + this.Forca + " de dano!\n\n";
        }

    }
}
