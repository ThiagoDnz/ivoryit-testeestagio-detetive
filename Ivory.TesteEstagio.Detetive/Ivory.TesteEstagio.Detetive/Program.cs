using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivory.TesteEstagio.Detetive
{
    class Program
    {
        static void Main(string[] args)
        {
            var testemunha = new Testemunha();
            int criminoso;
            int local;
            int arma;
            int dica;

            // Escreva seu código aqui.
            do
            {
                //Coleta de informações sobre o caso.
                //Criminoso
                Console.Write(" 1 - Advogado Sr. Marinho\n 2 - Chef. de Cozinha Tony Gourmet\n 3 - Coveiro Sérgio Sortuno\n 4 - Dançarina Srta. Rosa"
                             + "\n 5 - Florista Dona Branca\n 6 - Médica Dona Violeta\n 7 - Mordomo James\n 8 - Sargento Bigode\n QUAL O CRIMINOSO?: ");
                criminoso = int.Parse(Console.ReadLine());
                //Local
                Console.Write(" \n 1 - Biblioteca\n 2 - Cozinha\n 3 - Hall\n 4 - Escritório\n 5 - Sala de estar\n 6 - Sala de Jantar\n 7 - Sala de música"
                             + "\n 8 - Salão de festas\n 9 - Salão de jogos\n QUAL O LOCAL DO CRIME?: ");
                local = int.Parse(Console.ReadLine());
                //Arma
                Console.Write(" \n 1 - Castiçal\n 2 - Cano\n 3 - Chave Inglesa\n 4 - Corda\n 5 - Revólver\n 6 - Faca\n QUAL A ARMA UTILIZADA?: ");
                arma = int.Parse(Console.ReadLine());
                testemunha.Interrogar(criminoso, local, arma);


                //Respostas da testemunha.
                dica = testemunha.Interrogar(criminoso, local, arma);
                switch (dica)
                {
                    case 1:
                        Console.WriteLine("\n 1 - O assassino está incorreto");
                        break;
                    case 2:
                        Console.WriteLine("\n 2 - O local está incorreto");
                        break;
                    case 3:
                        Console.WriteLine("\n 3 - A arma está incorreto");
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine(" 0 - Parabéns você solucionou o caso");
                        Console.WriteLine(" Número de Tentativas: " + testemunha.ObterNumeroInterogatoriosRealizados());
                        Console.WriteLine("\n Tecle qualque tecla para sair!!");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine(" Pressione qualquer tecla para uma nova tentativa ou ESC para fechar a aplicação.");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
                Console.Clear();
            } while (testemunha.Interrogar(criminoso, local, arma) != 0);
        }
    }
}