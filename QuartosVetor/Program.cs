using System;

namespace QuartosVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vect = new Estudante[11];
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                if (vect[quarto] != null)
                {
                    Console.WriteLine($"O Quarto {quarto} já está ocupado! Por favor escolhar outro");
                    Console.Write("Qual quarto voce gostaria?");
                    quarto = int.Parse(Console.ReadLine());
                    if (vect[quarto] != null)
                        Console.WriteLine("Voce digitou novamente um quarto lotado");
                        Console.WriteLine("Iremos lhe dar um disponivel");

                    for (int x = 1; x < 11; x++)
                    {
                        if (vect[x] == null)
                        {
                            quarto = x;
                            break;
                        }

                    }
                    Console.WriteLine($"{nome} seu quarto será {quarto}");
                    vect[quarto] = new Estudante(nome, email);

                }
                else
                    vect[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 11; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}
