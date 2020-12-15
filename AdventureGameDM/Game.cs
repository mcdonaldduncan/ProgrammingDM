using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameDM
{
    public class Game
    {
        public string title = "Turtle Adventure";
       
        public void StartGame()
        {
            Console.WriteLine("Welcome to " + title + "\nAre you ready to embark on an epic adventure as the most underrated member of the animal kingdom?");
            Console.WriteLine("Press Enter to Continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Please enter your name");
            Player player1 = new Player
            {
                name = Console.ReadLine(),
                score = 0
            };
            Console.Clear();
            Console.WriteLine(player1.name + "! it is time to begin your adventure!\nAs you explore you must endure the many pressures of delinguent dissidents!\nHave Fun!");

           
            Dissident[] dissidents = new Dissident[9];
            dissidents[0] = new Dissident
            {
                message = "",
                name = "",
                intelligence = 0,
                speed = 0,
                strength = 0
            };
            dissidents[1] = new Dissident
            {
                message = "",
                name = "",
                intelligence = 0,
                speed = 0,
                strength = 0
            };
            dissidents[2] = new Dissident
            {
                message = "",
                name = "",
                intelligence = 0,
                speed = 0,
                strength = 0
            };
            dissidents[3] = new Dissident
            {
                message = "",
                name = "",
                intelligence = 0,
                speed = 0,
                strength = 0
            };
            dissidents[4] = new Dissident
            {
                message = "",
                name = "",
                intelligence = 0,
                speed = 0,
                strength = 0
            };
            dissidents[5] = new Dissident
            {
                message = "",
                name = "",
                intelligence = 0,
                speed = 0,
                strength = 0
            };
            dissidents[6] = new Dissident
            {
                message = "",
                name = "",
                intelligence = 0,
                speed = 0,
                strength = 0
            };
            dissidents[7] = new Dissident
            {
                message = "",
                name = "",
                intelligence = 0,
                speed = 0,
                strength = 0
            };
            dissidents[8] = new Dissident
            {
                message = "",
                name = "",
                intelligence = 0,
                speed = 0,
                strength = 0
            };


            Console.ReadKey();
        }

        public Player NewPlayer()
        {
            Console.WriteLine("Please enter your name");
            Player player1 = new Player
            {
                name = Console.ReadLine(),
                score = 0
            };
            Console.Clear();
            return player1;
        }

        public void Interact(Dissident[] dissidents)
        {
            int i = 0;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(dissidents[i].message);

        }

        public Dissident[] DissidentAssignment()
        {
            Dissident[] dissidents = new Dissident[15];
            dissidents[0] = new Dissident
            {
                message = "",
                name = "",
                intelligence = 0,
                speed = 0,
                strength = 0
            };
            dissidents[1] = new Dissident
            {
                message = "",
                name = "",
                intelligence = 0,
                speed = 0,
                strength = 0
            };
            dissidents[2] = new Dissident
            {
                message = "",
                name = "",
                intelligence = 0,
                speed = 0,
                strength = 0
            };
            dissidents[3] = new Dissident
            {
                message = "",
                name = "",
                intelligence = 0,
                speed = 0,
                strength = 0
            };
            dissidents[4] = new Dissident
            {
                message = "",
                name = "",
                intelligence = 0,
                speed = 0,
                strength = 0
            };
            dissidents[5] = new Dissident
            {
                message = "",
                name = "",
                intelligence = 0,
                speed = 0,
                strength = 0
            };
            dissidents[6] = new Dissident
            {
                message = "",
                name = "",
                intelligence = 0,
                speed = 0,
                strength = 0
            };
            dissidents[7] = new Dissident
            {
                message = "",
                name = "",
                intelligence = 0,
                speed = 0,
                strength = 0
            };
            dissidents[8] = new Dissident
            {
                message = "",
                name = "",
                intelligence = 0,
                speed = 0,
                strength = 0
            };
            return dissidents;
        }

    }
}
