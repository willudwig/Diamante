using System;

namespace Diamante.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int meio;

            InputUsuario(out num, out meio);

            string[] vetor = new string[num];

            IniciarVetor(meio, vetor);
            AcresecerDiamante(meio, vetor);
            DecrescerDiamante(num, meio, vetor);

            Console.ReadKey();
        }

        private static void DecrescerDiamante(int num, int meio, string[] vetor)
        {
            for (int i = 1; i <= vetor.Length; i++)
            {
                if (i >= 0)
                {
                    if (vetor[meio - 1] == "x")
                    {
                        vetor[meio] = "x";
                        vetor[num - i] = " ";
                        vetor[i - 1] = " ";
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
        }

        private static void AcresecerDiamante(int meio, string[] vetor)
        {
            for (int i = 1; i <= vetor.Length; i++)
            {
                if (i >= 0)
                {
                    if (vetor[0] == " ")
                    {
                        vetor[meio] = "x";
                        vetor[meio + i] = "x";
                        vetor[meio - i] = "x";
                    }
                    else if (vetor[0] == "x")
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
        }

        private static void IniciarVetor(int meio, string[] vetor)
        {
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
        }

        private static void InputUsuario(out int num, out int meio)
        {
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

            meio = num / 2;
        }
    }
}