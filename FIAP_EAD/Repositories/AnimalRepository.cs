using FIAP_EAD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAP_EAD.Repositories
{
    internal class AnimalRepository : IAnimalRepository
    {

        private static IList<Animal> animais = new List<Animal>();

        public void Cadastrar(Animal animal)
        {
            animais.Add(animal);
        }

        public int Contar()
        {
            return animais.Count;
        }

        public IList<Animal> Listar()
        {
            return animais;
        }
    }
}
