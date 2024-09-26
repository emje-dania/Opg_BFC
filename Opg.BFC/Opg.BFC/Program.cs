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
            Console.WriteLine("1. Rock, 2. Paper, 3. Scissors");

            //While play is true the game will run
            while (play)
            {
                Random randomNumber = new Random();
                rnd = randomNumber.Next(min, max + 1);

                myChoice = Convert.ToInt32(Console.ReadLine());

                

                }

            Console.ReadLine();

        }





    }
    
}
