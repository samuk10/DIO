// Quando coloco using posso acessar uma classe desse namespace.
// Se o namespace não tiver no using lá em cima posso acessar uma classe dele usando:
// exemplo:  System.Console
// Mas como lá em cima está com som o using System, eu acesso apenas com:
// exemplo: Console
using System;
using Primeiro;
using Csharp;
using Interface;
using Enum;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // pegando a pessoa na posição 0
            var pessoa1 = (Pessoas)0;
            // pegando a index do joão
            Pessoas pessoa2 = Pessoas.João;
            // ou
            Pessoas pessoa3 = (Pessoas)4;


            // Person vai ter o objeto com os valores de Pessoa
            Pessoa person = new Pessoa();

            person.Nome = "Samuel";
            person.Idade = 29;
            person.Estado = "Rio de Janeiro";

            var person2 = new Pessoa();

            person2.Nome = "Julia";
            person2.Idade = 23;
            person2.Estado = "Minas Gerais";

            Animal animal = new Animal();
            animal.Nome = "Rex";
            animal.NomeDono = "Pedro";
            animal.Especie = "Cachorro";

            // Aqui usei uma classe com namespace referenciado com using
            var classe = new Classe();
            // Aqui usei uma classe não referenciada com using, 
            // escrevendo o nome do namespace.Class
            var classe2 = new Segundo.Classe();

            Console.WriteLine("Hello, World!");
            Console.WriteLine(person.Nome);
        }
    }
}
