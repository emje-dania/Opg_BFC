using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg.BFC
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Varible list
            bool play = true;
            int min = 1;
            int max = 3;
            int myChoice;
            int rnd;
            string response;

            // intro
            Console.WriteLine("Hello player");
            Console.WriteLine("Rules: pick between 1-3 in order to play against the computer");
            

            //While play is true the game will run
            while (play)
            {
                Console.WriteLine("1. Rock, 2. Paper, 3. Scissors");

                Random randomNumber = new Random();
                rnd = randomNumber.Next(min, max + 1);

                myChoice = Convert.ToInt32(Console.ReadLine());

                switch (myChoice)
                {
                    case 1:
                        {
                            if (rnd > myChoice)
                            {
                                Console.WriteLine($"You: {myChoice} vs CPU: {rnd}\nYou Lost");
                            }
                            else if (rnd < myChoice)
                            {
                                Console.WriteLine($"You: {myChoice} vs CPU: {rnd}\nYou Won");
                            }
                            else
                            {
                                Console.WriteLine($"You: {myChoice} vs CPU: {rnd}\nIt was a tie");
                            }
                            break;
                        }
                    case 2:
                        {
                            if(rnd > myChoice)
                            {
                                Console.WriteLine($"You: {myChoice} vs CPU: {rnd}\nYou Lost");
                            }
                            else if (rnd < myChoice)
                            {
                                Console.WriteLine($"You: {myChoice} vs CPU: {rnd}\nYou Won");
                            }
                            else
                            {
                                Console.WriteLine($"You: {myChoice} vs CPU: {rnd}\nIt was a tie");
                            }
                            break;
                        }
                    case 3:
                        {
                            if(rnd > myChoice)
                            {
                                Console.WriteLine($"You: {myChoice} vs CPU: {rnd}\nYou Lost");
                            }
                            else if (rnd < myChoice)
                            {
                                Console.WriteLine($"You: {myChoice} vs CPU: {rnd}\nYou Won");
                            }
                            else
                            {
                                Console.WriteLine($"You: {myChoice} vs CPU: {rnd}\nIt was a tie");
                            }
                            break;
                        }
                }

                Console.WriteLine("Play again? (Y/N)");
                response = Console.ReadLine();
                response = response.ToUpper();
                if (response == "Y")
                {
                    play = true;
                }
                else
                {
                    play = false;
                }

            }
            Console.WriteLine("Thanks for playing");
            Console.ReadLine();

        }





    }
    
}
