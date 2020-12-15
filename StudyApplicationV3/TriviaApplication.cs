using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyApplication
{
    

    public class TriviaApplication
    {

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
     
        public TriviaTerm[] TriviaTermAssignment()
        {
            TriviaTerm[] triviaArray = new TriviaTerm[16];
            triviaArray[0] = new TriviaTerm
            {
                term = System.IO.File.ReadAllText(@"C:\Users\dfmcd\Documents\C#_Text\Term1.txt"), 
                definition = System.IO.File.ReadAllText(@"C:\Users\dfmcd\Documents\C#_Text\Def1.txt"),
                difficulty = 1
            }; triviaArray[1] = new TriviaTerm
            {
                term = System.IO.File.ReadAllText(@"C:\Users\dfmcd\Documents\C#_Text\Term2.txt"),
                definition = System.IO.File.ReadAllText(@"C:\Users\dfmcd\Documents\C#_Text\Def2.txt"),
                difficulty = 1
            }; triviaArray[2] = new TriviaTerm
            {
                term = System.IO.File.ReadAllText(@"C:\Users\dfmcd\Documents\C#_Text\Term3.txt"),
                definition = System.IO.File.ReadAllText(@"C:\Users\dfmcd\Documents\C#_Text\Def3.txt"),
                difficulty = 1
            }; triviaArray[3] = new TriviaTerm
            {
                term = System.IO.File.ReadAllText(@"C:\Users\dfmcd\Documents\C#_Text\Term4.txt"),
                definition = System.IO.File.ReadAllText(@"C:\Users\dfmcd\Documents\C#_Text\Def4.txt"),
                difficulty = 1
            }; triviaArray[4] = new TriviaTerm
            {
                term = System.IO.File.ReadAllText(@"C:\Users\dfmcd\Documents\C#_Text\Term5.txt"),
                definition = System.IO.File.ReadAllText(@"C:\Users\dfmcd\Documents\C#_Text\Def5.txt"),
                difficulty = 1
            }; triviaArray[5] = new TriviaTerm
            {
                term = System.IO.File.ReadAllText(@"C:\Users\dfmcd\Documents\C#_Text\Term6.txt"),
                definition = System.IO.File.ReadAllText(@"C:\Users\dfmcd\Documents\C#_Text\Def6.txt"),
                difficulty = 1
            };triviaArray[6] = new TriviaTerm
            {
                term = System.IO.File.ReadAllText(@"C:\Users\dfmcd\Documents\C#_Text\Term7.txt"),
                definition = System.IO.File.ReadAllText(@"C:\Users\dfmcd\Documents\C#_Text\Def7.txt"),
                difficulty = 1
            }; triviaArray[7] = new TriviaTerm
            {
                term = System.IO.File.ReadAllText(@"C:\Users\dfmcd\Documents\C#_Text\Term8.txt"),
                definition = System.IO.File.ReadAllText(@"C:\Users\dfmcd\Documents\C#_Text\Def8.txt"),
                difficulty = 1
            }; triviaArray[8] = new TriviaTerm
            {
                term = System.IO.File.ReadAllText(@"C:\Users\dfmcd\Documents\C#_Text\Term9.txt"),
                definition = System.IO.File.ReadAllText(@"C:\Users\dfmcd\Documents\C#_Text\Def9.txt"),
                difficulty = 1
            }; triviaArray[9] = new TriviaTerm
            {
                term = System.IO.File.ReadAllText(@"C:\Users\dfmcd\Documents\C#_Text\Term10.txt"),
                definition = System.IO.File.ReadAllText(@"C:\Users\dfmcd\Documents\C#_Text\Def10.txt"),
                difficulty = 1
            }; triviaArray[10] = new TriviaTerm
            {
                term = System.IO.File.ReadAllText(@"C:\Users\dfmcd\Documents\C#_Text\Term11.txt"),
                definition = System.IO.File.ReadAllText(@"C:\Users\dfmcd\Documents\C#_Text\Def11.txt"),
                difficulty = 1
            }; triviaArray[11] = new TriviaTerm
            {
                term = System.IO.File.ReadAllText(@"C:\Users\dfmcd\Documents\C#_Text\Term12.txt"),
                definition = System.IO.File.ReadAllText(@"C:\Users\dfmcd\Documents\C#_Text\Def12.txt"),
                difficulty = 1
            }; triviaArray[12] = new TriviaTerm
            {
                term = System.IO.File.ReadAllText(@"C:\Users\dfmcd\Documents\C#_Text\Term13.txt"),
                definition = System.IO.File.ReadAllText(@"C:\Users\dfmcd\Documents\C#_Text\Def13.txt"),
                difficulty = 1
            }; triviaArray[13] = new TriviaTerm
            {
                term = System.IO.File.ReadAllText(@"C:\Users\dfmcd\Documents\C#_Text\Term14.txt"),
                definition = System.IO.File.ReadAllText(@"C:\Users\dfmcd\Documents\C#_Text\Def14.txt"),
                difficulty = 1
            }; triviaArray[14] = new TriviaTerm
            {
                term = System.IO.File.ReadAllText(@"C:\Users\dfmcd\Documents\C#_Text\Term15.txt"),
                definition = System.IO.File.ReadAllText(@"C:\Users\dfmcd\Documents\C#_Text\Def15.txt"),
                difficulty = 1
            }; triviaArray[15] = new TriviaTerm
            {
                term = System.IO.File.ReadAllText(@"C:\Users\dfmcd\Documents\C#_Text\Term16.txt"),
                definition = System.IO.File.ReadAllText(@"C:\Users\dfmcd\Documents\C#_Text\Def16.txt"),
                difficulty = 1
            }; 
            return triviaArray;
        }

        

        public void Play(Player player1, TriviaTerm[] triviaArray)
        {
            Console.WriteLine("Hey there " + player1.name + " it is time for you to review your knowledge of programming concepts, here you go!");
            Console.WriteLine("Press enter when you are ready");
            Console.ReadKey();
            Console.Clear();

           
            for (int i = 0; i < triviaArray.Length; i++)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(triviaArray[i].definition);
                    Console.ForegroundColor = ConsoleColor.Green;
                    string playerInput = Console.ReadLine();
                    playerInput = playerInput.ToUpper();
                    if (playerInput == triviaArray[i].term.ToUpper())
                    {
                        Console.WriteLine("Correct!");
                        player1.score += triviaArray[i].difficulty;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!");
                    }

                    Console.WriteLine(player1.name + ", your score is " + player1.score);
                    Console.WriteLine("The correct term is " + triviaArray[i].term);
                    Console.WriteLine("Press Enter to Continue");
                    Console.ReadKey();
                    Console.Clear();

                }
                catch (Exception)
                {

                    throw;
                }
                
            }
            
        }

        public void ExecuteGame()
        {
            Player player1 = NewPlayer();
            TriviaTerm[] triviaArray = TriviaTermAssignment();
            Play(player1, triviaArray);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Thank you for reviewing your terms!");
            Console.WriteLine($"You answered " + player1.score + " out of " + triviaArray.Length + " questions correct");
            Console.WriteLine("Press Enter to close the program");
            Console.ReadKey();
        }

        
        

    }
}
