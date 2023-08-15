using FIAP_EAD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAP_EAD.Repositories
{
    internal interface IAnimalRepository
    {
        // cadastrar
        void Cadastrar(Animal animal);

        // listar
        IList<Animal> Listar();

        // contar quantidade de animais
        int Contar();
    }
}
