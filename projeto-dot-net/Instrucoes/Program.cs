// See https://aka.ms/new-console-template for more information
using System;

namespace Instrucoes
{
    class Program
    {
        static void Declaracoes()
        {
            int a;
            int b = 2, c = 3;
            const int d = 4; // const não pode ser alterada
            a = 1;
            d = 5; // não vai alterar o valor de d, pois é const
            Console.WriteLine(a + b + c + d);
            // vai printar valor 10
        }
        static void InstrucaoIf(string[] args)
        {
            //array de string, lista de letras
            if (args.Length == 0)
            {
                Console.WriteLine("Nenhum argumento");
            }
            else if (args.Length == 1)
            {
                Console.WriteLine("Um argumento");
            }
            else
            {
                // $ instring interpolation, altera o texto da string
                Console.WriteLine($"{args.Length} argumento");
            }
        }
        static void InstrucaoSwitch(string[] args)
        {
            int numeroDeArgumentos = args.Length;
            switch (numeroDeArgumentos)
            {
                case 0:
                    Console.WriteLine("Nenhum argumento");
                    break;
                case 1:
                    Console.WriteLine("Um argumento");
                    break;
                default:
                    Console.WriteLine($"{numeroDeArgumentos} argumentos");
                    break;
            }
        }
        static void InstrucaoWhile(string[] args)
        {
            int i = 0;
            while (i < args.Length)
            {
                // enquanto i for menor que o numero do arg, imprimo.
                Console.WriteLine(args[i]);
                i++
            }
        }
        static void InstrucaoDo(string[] args)
        // do faz a verificação antes de executar o código
        // readline, aguarda input no console e guarda o valor na variavel texto
        // ! negativa
        {
            string texto;
            do
            {
                texto = Console.ReadLine();
                Console.WriteLine(texto);
            } while (!string.IsNullOrEmpty(texto));
        }
        static void InstrucaoFor(string[] args)
        // para i = 0
        // enquanto i for menor que numero de argumentos, executa o writeline
        // i++ = incrementa o i toda vez que executar o comando
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }
        static void InstrucaoForeach(string[] args)
        // parece com o for, mas é mais legivel.
        // para cada string no args vai ser armazenada no "s" e executar o writeline
        {
            foreach (string s in args)
            {
                Console.WriteLine(s);
            }
        }
        static void InstrucaoBreak(string[] args)
        // muito usado em laço de repetição
        // enquanto for true ele vai executar, senão ele para
        {
            while (true)
            {
                string s = Console.ReadLine();
                // enquanto S for nulo ou vazio, executa, senão ele para
                if (string.IsNullOrWhiteSpace(s))
                    break;

                Console.WriteLine(s);
            }
        }
        static void InstrucaoContinue(string[] args)
        {
            for (int i = 0; i < args.Length("/"))
                continue;

            Console.WriteLine(args[i]);
        }


    }
}

