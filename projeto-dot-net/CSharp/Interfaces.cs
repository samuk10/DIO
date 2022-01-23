// Interface usada para criar um padrão e não se esquecer de nenhum parãmetro
namespace Interface
{
    interface IAnimal
    {
        void Nome(string nome);
        void NomeDono(string nomeDono);
        void Especie(string especie);
    }

    class Animal : IAnimal
    {
        public string Nome { get; set; }
        public string NomeDono { get; set; }
        public string Especie { get; set; }

        void IAnimal.Nome(string nome)
        {
            this.Nome = nome;
        }

        void IAnimal.NomeDono(string nomeDono)
        {
            this.NomeDono = nomeDono;
        }

        void IAnimal.Especie(string especie)
        {
            this.Nome = especie;
        }
    }
}