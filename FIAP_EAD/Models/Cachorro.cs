using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAP_EAD.Models
{
    internal class Cachorro : Animal
    {

        public string Raca { get; set; }

        public Cachorro(string nome, int idade, Genero genero, string raca) : base(nome, idade, genero) 
        {
            Raca = raca;
        }

        public override void Comer() 
        {
            Console.WriteLine("Cachorro come Ração para cachorro!");
        }
    }
}
