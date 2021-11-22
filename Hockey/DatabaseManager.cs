using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hockey
{
    public class DatabaseManager
    {
        private List<Player> players = new List<Player>();

        public void Run()
        {
            while (true)
            {
                PrintMenu();
                string sel = Console.ReadLine();
                if (sel == "0")
                    break;
                if(sel == "1")
                {
                    players.Add(CreatePlayer());
                }
                if(sel == "2") 
                {
                    Console.WriteLine("*** ALLA ***");
                    foreach (var player in players)
                        Console.WriteLine($"{player.Jersey} {player.Namn}  {player.Team}");
                }
            }
        }
        public Player CreatePlayer()
        {
            Console.WriteLine("*** NEW ***");
            var player = new Player();
            Console.Write("Namn:");
            player.Namn = Console.ReadLine();
            Console.Write("Jersey:");
            player.Jersey = Convert.ToInt32(Console.ReadLine());
            Console.Write("Team:");
            player.Team = Console.ReadLine();
            return player;
        }

        public void PrintMenu()
        {
            Console.WriteLine("1. Skapa ny spelare");
            Console.WriteLine("2. Lista alla");
            Console.WriteLine("0. Avsluta");
        }
    }
}
