using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAP_EAD.Models
{
    internal abstract class Animal
    {

        public string Nome { get; set; }

        public int Idade { get; set; }

        public Genero Genero { get; set; }

        public Animal(string nome, int idade, Genero genero) 
        {
            Nome = nome;
            Idade = idade;
            Genero = genero;
        }

        public abstract void Comer();

        public virtual void EmitirBarulho(string som)
        {
            Console.WriteLine($"Animal emitindo som: {som}");
        }


    }
    public enum Genero
    {
        Femea,
        Macho
    }
}
