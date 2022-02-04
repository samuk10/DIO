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
            b = 5; // não vai alterar o valor de d, pois é const
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
                i++;
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
            // se começar com / eu continuo, senão eu paro
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].StartsWith("/"))
                    continue;

                Console.WriteLine(args[i]);
            }
        }
        static void InstrucaoReturn()
        {
            int Somar(int a, int b)
            {
                return a + b;
            }

            Console.WriteLine(Somar(1, 2));
            Console.WriteLine(Somar(3, 4));
            Console.WriteLine(Somar(5, 6));
            return;
        }
        static void InstrucoesTryCatchFinallyThrow(string[] args)
        {
            double Dividir(double x, double y)
            // double significa que espero 2 strings no metodo 
            // para que possa ser feita a operação
            {
                // se for zero já mostra erro, pois não ter divisão por zero.
                if (y == 0)
                    throw new DivideByZeroException();

                return x / y;
            }

            try
            {
                // Try catch tenta pegar os exception e tratar
                // Se o numero de argumentos for diferente de 2 eu vou
                // escrever a mensagem ""
                if (args.Length != 2)
                {
                    throw new InvalidOperationException("Informe 2 Números");
                }

                // Defino quem é X e Y no array
                // X = posição 0 ; Y = posição 1
                double x = double.Parse(args[0]);
                double y = double.Parse(args[1]);
                Console.WriteLine(Dividir(x, y));
            }
            // esse catch vai pegar "InvalidOperationExceptio"
            // e mostra a mensagem de exception acima do "informxx.. 2"
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            // se for qualquer outra exception, cai nesse aqui
            // e mostra erro genérico e msg da exception
            catch (Exception e)
            {
                Console.WriteLine($"Erro Genérico: {e.Message}");
            }
            finally
            // se der certo e se der alguma exceção ele mostra até breve
            {
                Console.WriteLine("Até Breve!");
            }
        }
        static void InstrucaoUsing(string[] args)
        {
            // Geralmente as Operações de IO, entrada e saida de dados, ficam em memoria
            // Do modo abaixo, ele apaga automaticamente da memoria logo após a operação
            // Escrever um arquivo de texto e algumas linhas dentro dele
            // 
            using (System.IO.TextWriter w = System.IO.File.CreateText("texte.txt"))
            {
                w.WriteLine("Line 1");
                w.WriteLine("Line 2");
                w.WriteLine("Line 3");
            }
        }
    }
}

