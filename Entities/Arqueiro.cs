using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.rpg.Entities
{
    public class Arqueiro : Personagem
    {
        public string Nome { get; set; }
        public int Nivel { get; set; }
        public int Vida { get; set; }
        public int Forca { get; set; }

        public Arqueiro(string Nome, int Nivel, int Vida, int Forca)
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
    }
}
