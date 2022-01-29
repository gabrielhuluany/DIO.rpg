using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.rpg.Entities
{
    public class Guerreiro : Personagem
    {

        public Guerreiro(string Nome, int Nivel, int Vida, int Forca) : base (Nome, Nivel, Vida, Forca)
        {

        }

        public override string ToString()
        {
            return ("Nome: " + this.Nome + "\nNível: " + this.Nivel + "\nVida: " + this.Vida + "\nForça: " + this.Forca + "\n\n");
        }

        public override string Atacar()
        {
            return this.Nome + " deu uma ombrada no slime e causou " + this.Forca + " de dano!\n\n";
        }
    }
}
