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

        public override string Atacar()
        {
            return this.Nome + " deu uma ombrada no slime e causou " + this.Forca + " de dano!\n\n";
        }

        public string Atacar(int Bonus)
        {
            if(Bonus >= 3)
            {
                return this.Nome + " realizou uma investida no modo Berserker contra o slime e causou " + (this.Forca * Bonus) + " de dano!\n";
            } else
            {
                return this.Nome + " realizou uma investida contra o slime e causou " + (this.Forca + Bonus) + " de dano!\n";
            }
        }
    }
}
