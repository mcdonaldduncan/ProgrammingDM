using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    public static class Game
    {
        
        static string GameName = "Trivia Game by Duncan";

        //Constructor
        public static void StartGame()   
        {
            Play();
            Console.ReadKey();
        }

        private static void Play()
        {
            Player Player1 = GameIntro();

            TriviaItem[] triviaItems = TriviaItemsAssignment();

            PlayGame(Player1, triviaItems);
            EndGame(Player1);

        }

        private static Player GameIntro()
        {
            Console.Title = GameName;
            Console.WriteLine("Welcome to " + GameName);
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("What is your name?");
            Player Player1 = new Player();
            Player1.name = Console.ReadLine();
            Player1.score = 0;
            Console.Clear();
            Console.WriteLine("Thank you " + Player1.name);
            Console.WriteLine("Press Enter to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You will be asked a series of questions about Geese, answer to the best of your abilities.");
            Console.WriteLine("Press Enter to continue");
            Console.ReadKey();
            Console.Clear();
            return Player1;
        }

        private static void EndGame(Player Player1)
        {
            Console.WriteLine("Congratulations you answered " + Player1.score + " Out of 10 correctly");
            double Percentcorrect = ((Player1.score / 10) * 100);
            Console.WriteLine(Percentcorrect + "%");
            Console.WriteLine("Press Enter to continue");
            Console.ReadKey();
        }

        private static TriviaItem[] TriviaItemsAssignment()
        {
            TriviaItem[] triviaItems = new TriviaItem[10];
            triviaItems[0] = new TriviaItem
            {
                question = "What do you call a group of flying Geese?",
                answer = "Skein"
            };
            triviaItems[1] = new TriviaItem
            {
                question = "What do you call a group of walking Geese?",
                answer = "Gaggle"
            };
            triviaItems[2] = new TriviaItem
            {
                question = "Do Geese mourn for their lost companions?",
                answer = "Yes"
            };
            triviaItems[3] = new TriviaItem
            {
                question = "What is the term for a male goose?",
                answer = "Gander"
            };
            triviaItems[4] = new TriviaItem
            {
                question = "Where do geese come from historically?",
                answer = "Africa or China"
            };
            triviaItems[5] = new TriviaItem
            {
                question = "Where were geese first domesticated?",
                answer = "Egypt"
            };
            triviaItems[6] = new TriviaItem
            {
                question = "How old can a goose get? Please type your answer as text",
                answer = "Twenty"
            };
            triviaItems[7] = new TriviaItem
            {
                question = "Under which classification do geese fall based on diet?",
                answer = "Herbivore"
            };
            triviaItems[8] = new TriviaItem
            {
                question = "Which sport traditionally used goose feathers in the making of their ball?",
                answer = "Golf"
            };
            triviaItems[9] = new TriviaItem
            {
                question = "What do geese love most?",
                answer = "Weed"
            };
            return triviaItems;
        }

        private static void PlayGame(Player Player1, TriviaItem[] triviaItems)
        {
            for (int i = 0; i < triviaItems.Length; i++)
            {
                Console.WriteLine(triviaItems[i].question);
                string playerInput = Console.ReadLine();
                playerInput = playerInput.ToUpper();
                if (playerInput == triviaItems[i].answer.ToUpper())
                {
                    Console.WriteLine("Correct!");
                    Player1.score += 1;
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                }

                Console.WriteLine("Your score is " + Player1.score);
                Console.WriteLine("The correct answer was " + triviaItems[i].answer);
                Console.WriteLine("Press Enter to Continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
