using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * AdventureGame
 * Duncan McDonald, 9/21/20
 * 
 * This work is a derivative of 
 * "C# Adventure Game" by http://programmingisfun.com, used under CC BY.
 * https://creativecommons.org/licenses/by/4.0/
 */

namespace AdventureGameDM
{
    class Program
    {
        static void Main()
        {
            Game game = new Game();
            game.StartGame();

        }
    }
}
