using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Politico Pedro = new Politico();
            Pedro.Nome = "Pedro";
            Pedro.Numero = "45";

            Politico Joao = new Politico();
            Joao.Nome = "Joao";
            Joao.Numero = "40";

            apuracaoDeVotos primeiroTurno = new apuracaoDeVotos();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Para votar em {Pedro.Nome} é só digitar {Pedro.Numero}");
                Console.WriteLine($"Para votar em {Joao.Nome} é só digitar {Joao.Numero}");
                Console.WriteLine("Qual será seu voto?");
                string escolha = Console.ReadLine();
                if (escolha == "45")
                {
                    primeiroTurno.acrescentarPedro(1);
                    Console.WriteLine("Você votou em Pedro!");
                    Console.WriteLine();
                }
                else if (escolha == "40")
                {
                    primeiroTurno.acrescentarJoao(1);
                    Console.WriteLine("Você votou em João!");
                    Console.WriteLine();
                }
                else
                {
                    primeiroTurno.acrescentarNulo(1);
                    Console.WriteLine("Você anulou seu Voto!");
                    Console.WriteLine();
                }
            }

            Console.WriteLine($"Quantidades de votos em Pedro: {primeiroTurno.VotoPedro} ");
            Console.WriteLine($"Quantidades de votos em Pedro: {primeiroTurno.VotoJoao} ");
            Console.WriteLine($"Quantidades de votos em Pedro: {primeiroTurno.VotoNulo} ");

            Console.ReadLine();
        }
    }
}
