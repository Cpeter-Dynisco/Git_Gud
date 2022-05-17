using System;

namespace CP_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's Play Higher or lower!");
            Console.WriteLine("Please set Lower bound");
            string Val = Console.ReadLine();
            if (!int.TryParse(Val, out int Low_Bound)) {
                Console.WriteLine("Error! Please input a number");
            }
            Console.WriteLine("Please set Upper bound");
            Val = Console.ReadLine();
            if (!int.TryParse(Val, out int Hi_Bound)) { 
                Console.WriteLine("Error! Please input a number");
            }
            Random rnd = new Random();
            int guess = Low_Bound;
            int temp_lo = Low_Bound;
            int temp_hi = Hi_Bound;
            bool found = false;
            Console.WriteLine("Pick a number between " + Low_Bound + " and " + Hi_Bound + " and I will try to guess it! type h if your number is higher, l if it's lower, and o if I am correct. Press enter to start.");
            while (!found){
                guess = rnd.Next(temp_lo+1, temp_hi);
                Console.Write(guess);
                String feed = Console.ReadLine();
                if(feed.Equals("h")){
                    temp_lo = guess;
                }
                else if(feed.Equals("l")){
                    temp_hi = guess;
                }
               else if (feed.Equals("o")){
                    found = true;
                    Console.WriteLine("Yay! Let's play again sometime");
                }
                else{
                    Console.WriteLine("Error! Invalid input. please either enter l for lower, h for higher, or o for correct");
                }
                }

            }

        }
    }
