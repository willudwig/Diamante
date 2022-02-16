using System;

namespace Diamante.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            while (true)
            {
                Console.Write("Digite um número ímpar: ");
                num = int.Parse(Console.ReadLine());

                if (num % 2 != 0)
                {
                    break;
                }
                else if (num % 2 == 0)
                {
                    continue;
                }
            }
            Console.WriteLine();

            int meio = num / 2;
            
            string[] vetor = new string[num];
            
            //inicia vetor
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = " ";
            }

            vetor[meio] = "x";

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i]);
            }
            Console.WriteLine();

            //aumenta o diamante
            for (int i = 1; i <= vetor.Length; i++)
            {
                if (i >= 0)
                {
                    if (vetor[0]  == " ")
                    {
                        vetor[meio] = "x";
                        vetor[meio + i] = "x";
                        vetor[meio - i] = "x";
                    }
                    else if (vetor [0] == "x")
                    {
                        break;
                    }
                }
                else
                    break;

                    //exibe
                    for (int j = 0; j < vetor.Length; j++)
                {
                    Console.Write(vetor[j]);
                }
                Console.WriteLine();
            }

            //diminui o diamante
            for (int i = 1; i <= vetor.Length; i++)
            {
                if (i >= 0)
                {
                    if (vetor[meio - 1] == "x")
                    {
                        vetor[ meio ] = "x";
                        vetor[ num - i ] = " ";
                        vetor[ i - 1 ] = " ";
                    }
                    else if (vetor[meio - 1] == " ")
                    {
                        break;
                    }
                }
                else
                    break;

                //exibe
                for (int j = 0; j < vetor.Length; j++)
                {
                    Console.Write(vetor[j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}