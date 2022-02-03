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
        public string Classe;
        public string Titulo;
        public string Rank;
        public int Nivel;
        public int Vida;
        public int Forca;
        public static int id = 0;

        public Personagem(string Nome, int Nivel, int Vida, int Forca)
        {
            this.Nome = Nome;
            this.Titulo = "";
            this.Classe = GetType().Name;
            this.Rank = "";
            this.Nivel = Nivel;
            this.Vida = Vida;
            this.Forca = Forca;

            if (this.GetType().Name == "Guerreiro")
            {
                this.Titulo = "O imortal";
            }
            if (this.GetType().Name == "Arqueiro")
            {
                this.Titulo = "O especialista";
            }
            if (this.GetType().Name == "Mago")
            {
                this.Titulo = "O arcano";
            }

            if (this.Nivel < 25) 
            {
                this.Rank = "Novato";
            }

            if (this.Nivel >= 25 && this.Nivel < 50)
            {
                this.Rank = "Experiente";
            }

            if (this.Nivel >= 50 && this.Nivel < 75)
            {
                this.Rank = "Esplêndido";
            }

            if (this.Nivel >= 75 && this.Nivel < 90)
            {
                this.Rank = "Formidável";
            }

            if (this.Nivel >= 90)
            {
                this.Rank = "Lenda";
            }
        }

        public override string ToString()
        {
            id++;
            return ("ID: " + id + "\nNome: " + this.Nome + "\nTítulo: " + this.Titulo + "\nClasse: " + this.Classe + "\nRank: " + this.Rank + "\nNível: " + this.Nivel + "\nVida: " + this.Vida + "\nForça: " + this.Forca + "\n---------------------------");
        }

        public virtual string Atacar()
        {
            return this.Nome + " atacou o slime e causou " + this.Forca + " de dano!\n";
        }

    }
}
