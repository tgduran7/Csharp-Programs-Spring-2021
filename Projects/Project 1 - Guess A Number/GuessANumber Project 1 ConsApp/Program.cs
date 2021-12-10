using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GuessANumber_Project_1_ConsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool gameStatus = false;

            while (gameStatus == false)
            {
                int correctNumber = random.Next(1, 101);
                int userInput = 0;
                int count = 1;

                while (userInput != correctNumber)
                {
                    Console.Write("Make a guess between 1 to 100: ");
                    string user_Input = Console.ReadLine();
                    
                    

                    bool valid = Int32.TryParse(user_Input, out userInput);

                    if (!valid || (userInput <1) || (userInput > 100))
                    
                    {
                        Console.WriteLine("\nEnter a valid input. Please try again.\n");
                    }
                    else
                    {
                        if (userInput == correctNumber)
                        {
                            Console.WriteLine("\n{0} was CORRECT!", correctNumber);
                            Console.WriteLine("Number of guesses = {0}.", count);
                            Console.Write("\nTo play again type 'y'. To quit the game type 'n': ");
                            string res = Console.ReadLine();
                            char restart;
                            bool valid2 = char.TryParse(res, out restart);

                            if (valid2)
                            {
                                if (restart == 'n')
                                {
                                    gameStatus = true;
                                    Console.WriteLine("Thank you for playing!\n");
                                }
                            }
                        }
                        if (userInput < correctNumber)
                        {
                            Console.WriteLine("\nYour guess is too LOW. Try again.\n");
                        }
                        if (userInput > correctNumber)
                        {
                            Console.WriteLine("\nYour guess is too HIGH. Try again.\n");
                        }
                        ++count;
                    }
                }
                
                Console.Clear();

            }
            
        }
    }
}
