using System;
using GameCollection.Classes;
using System.Collections.Generic;

namespace GameCollection
{
    class Program
    {
        static List<Game> gamesList = new List<Game>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("### Biblioteca de jogos ###");
                Console.WriteLine("\n");
                Console.WriteLine("1 - Adicionar um jogo");
                Console.WriteLine("2 - Listar os jogos");
                Console.WriteLine("3 - Atualizar um jogo");
                Console.WriteLine("4 - Deletar um jogo");
                Console.WriteLine("");

                int option = Console.Read();
                switch (option)
                {
                    case '1':
                        gamesList.Add(AddingGames());
                        break;

                    case '2':
                        listingGames();
                        break;

                    case '3':
                        updatingGames();
                        break;

                    case '4':
                        removingGames();
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
        static private Game AddingGames()
        {
            Console.Clear();

            Console.WriteLine("ADICIONAR JOGO");
            Console.ReadLine();

            string name = "";
            while (name.Length == 0)
            {
                Console.Write("Nome: ");
                name = Console.ReadLine();
            }

            Console.Write("Lançamento: ");
            int data = Convert.ToInt32(Console.ReadLine());

            Console.Write("Gênero: ");
            string gender = Console.ReadLine();

            Console.Write("Max. de jogadores: ");
            int max = Convert.ToInt32(Console.ReadLine());

            Console.Write("Metacritic: ");
            int metacritic = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");


            Game game = new Game(name, data, gender, max, metacritic);

            Console.Beep();
            Console.WriteLine("Precione qualquer tecla para voltar ao menu");
            Console.ReadLine();
            Console.Clear();

            return game;
        }

        static private void listingGames()
        {
            Console.Clear();
            Console.WriteLine("JOGOS ADICIONADOS");
            Console.WriteLine("");

            foreach (Game game in gamesList)
            {
                Console.Write("Jogo: ");
                Console.WriteLine(game.getTitle());

                Console.Write("Ano: ");
                Console.WriteLine(game.getYear());

                Console.Write("Gênero: ");
                Console.WriteLine(game.getGender());

                Console.Write("Max. de jogadores: ");
                Console.WriteLine(game.getMaxPlayers());

                Console.Write("MetaCritic: ");
                Console.WriteLine(game.getMetaCritic());
                Console.WriteLine("--------------------");
                Console.WriteLine("");

            }
            Console.WriteLine("Precione qualquer tecla para prosseguir....");
            Console.ReadLine();
            Console.WriteLine("");
        }

        static private void updatingGames()
        {
            Console.Clear();
 
            listingGames();

            Console.WriteLine("ATUALIZANDO INFO. DOS JOGOS");
            Console.WriteLine("");

            Console.Write("Escolha o jogo a ser editado. Digite 1, 2, 3....: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nome editado: ");
            string editedName = Console.ReadLine();

            Console.Write("Lançamento editado: ");
            int editedYear = Convert.ToInt32(Console.ReadLine());

            Console.Write("Genero editado: ");
            string editedGender = Console.ReadLine();

            Console.Write("Max. de jogadores editado: ");
            int editedMax = Convert.ToInt32(Console.ReadLine());

            Console.Write("Metacritic editado: ");
            int editedMetacritic = Convert.ToInt32(Console.ReadLine());

            gamesList[choice-1].setTitle(editedName);
            gamesList[choice-1].setYear(editedYear);
            gamesList[choice-1].setGender(editedGender);
            gamesList[choice-1].setMaxPlayers(editedMax);
            gamesList[choice-1].setMetaCritic(editedMetacritic);

            Console.Clear();
        }

         static private void removingGames()
        {
            Console.Clear();
            
            listingGames();

            Console.WriteLine("REMOVENDO JOGOS");
            Console.WriteLine("");

            Console.Write("Escolha o jogo a ser removido. Digite 1, 2, 3....: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            gamesList.RemoveAt(choice - 1);
            Console.Clear();
        }
    }
}
