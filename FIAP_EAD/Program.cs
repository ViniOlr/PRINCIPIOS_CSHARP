using FIAP_EAD.Models;
using FIAP_EAD.Repositories;

try
{

    Cachorro cachorro = new Cachorro("Zizo", 8, Genero.Macho, "Schitzu");

    Console.WriteLine(cachorro.Nome);
    Console.WriteLine(cachorro.Idade);
    Console.WriteLine(cachorro.Raca);
    Console.WriteLine(cachorro.Genero);
    cachorro.Comer();
    cachorro.EmitirBarulho("Au au");

    Console.WriteLine();
    Console.WriteLine("-----------------------");
    Console.WriteLine();

    Gato gato = new Gato("Gatinho", 3, Genero.Femea, "Preto e Branco");

    Console.WriteLine(gato.Nome);
    Console.WriteLine(gato.Idade);
    Console.WriteLine(gato.CorPelo);
    Console.WriteLine(gato.Genero);
    gato.Comer();
    gato.EmitirBarulho("miau");

    //throw new ArgumentException("Erro de teste");

    Console.WriteLine();
    Console.WriteLine("-----------------------");
    Console.WriteLine();

    var repository = new AnimalRepository();

    repository.Cadastrar(gato);
    repository.Cadastrar(cachorro);

    var lista = repository.Listar();

    foreach (var item in lista)
    {
        Console.WriteLine(item.Nome);
    }
} catch(Exception ex)
{
    Console.WriteLine("Ocorreu um erro: " + ex.Message);
} finally
{
    Console.WriteLine("Programa finalizado com sucesso!");
}
