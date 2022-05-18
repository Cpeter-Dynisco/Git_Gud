using System;

namespace CP_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Text displays on startup
            Console.WriteLine("Let's Play Higher or lower!");
            Console.WriteLine("Please set Lower bound");
            //read in players guidelines
            String Val;
            int Low_Bound = 0;
            int Hi_Bound = 0;
            while (Low_Bound == 0) {
                Val = Console.ReadLine();
                if (!int.TryParse(Val, out Low_Bound)) {
                    Console.WriteLine("Error! Please input a number");//prevents breakage if player does not input a number properly
                }//needs loop so that number is guaranteed entered properly
            }
            Console.WriteLine("Please set Upper bound"); //see lower bound
            while (Hi_Bound == 0)
            {
                Val = Console.ReadLine();
                if (!int.TryParse(Val, out Hi_Bound))
                {
                    Console.WriteLine("Error! Please input a number");
                }
                else if(Hi_Bound <= Low_Bound)
                {
                    Console.WriteLine("Please ensure that the upper bound is larger than the lower bound");
                    Hi_Bound = 0;
                }
            }
            //initialize various important values
            Random rnd = new Random();
            int guess = Low_Bound;
            int temp_lo = Low_Bound;
            int temp_hi = Hi_Bound;
            bool found = false;
            Console.WriteLine("Pick a number between " + Low_Bound + " and " + Hi_Bound + " and I will try to guess it! type h if your number is higher, l if it's lower, and o if I am correct. Press enter to start.");
            while (!found){ //game runs in this loop. foudn terminates it once game is won
                guess = rnd.Next(temp_lo+1, temp_hi); //generate random guess in current range
                Console.Write(guess + "\r\n");
                String feed = Console.ReadLine(); //read player feedback. "h" means higher, "l" means lower, "o" means correct.
                if(feed.Equals("h")){
                    temp_lo = guess; //tighten guess range to only be numbers higher than last guess
                }
                else if(feed.Equals("l")){
                    temp_hi = guess; //tighten guess range to only be numbers lower than last guess
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
