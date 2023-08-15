using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAP_EAD.Models
{
    internal class Gato : Animal
        { 

        public string CorPelo { get; set; }
    
        public Gato(string nome, int idade, Genero genero, string corPelo) : base(nome, idade, genero)
        {
            CorPelo = corPelo;
        }

        public override void Comer()
        {
            Console.WriteLine("Gato come ração para gatos");
        }
    }
}
