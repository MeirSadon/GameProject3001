using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject_3001
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g1 = new Game
            {
                _name = "Monopol",
                _numberOfPlayers = 8,
                _originCountry = "Russian",
                _rating = 4.1f
            };

            Game g2 = new Game("Football");
            g2._numberOfPlayers = 6;
            g2._originCountry = "Arab";
            g2._rating = 0;

            Game g3 = new Game("Chess", "Israel");
            g3._numberOfPlayers = 4;
            g3._rating = 10;

            Game g4 = new Game("Computer", 3, 4.1f, "USA");
            PrintGame(g4);

        }
        static void PrintGame(Game g)
        {
            int number;
            Console.WriteLine(g);
        }

    }
}
