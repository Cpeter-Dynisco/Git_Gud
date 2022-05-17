using System;

namespace CP_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro
            Console.WriteLine("Let's Play Higher or lower!");
            Console.WriteLine("Please set Lower bound");
            string Val = Console.ReadLine(); //Read lower bound from console, as string
            if (!int.TryParse(Val, out int Low_Bound)) {//try to convert string to number
                Console.WriteLine("Error! Please input a number");//if string is invalid, throw this error
            }
            Console.WriteLine("Please set Upper bound");
            Val = Console.ReadLine(); //Same procedure as lower bound
            if (!int.TryParse(Val, out int Hi_Bound)) { 
                Console.WriteLine("Error! Please input a number"); //currently, code does not check that the upper bound is larger than the lower bound. 
            }
            //initialize the game
            Random rnd = new Random();
            int guess = Low_Bound; //machine's current guess
            int temp_lo = Low_Bound; //current low bound (changes as game progresses)
            int temp_hi = Hi_Bound; //current high bound (changes as game progresses)
            bool found = false; //flag for game's winning
            Console.WriteLine("Pick a number between " + Low_Bound + " and " + Hi_Bound + " and I will try to guess it! type h if your number is higher, l if it's lower, and o if I am correct. Press enter to start.");
            while (!found){ //found escapes the loop when the correct number is found
                guess = rnd.Next(temp_lo+1, temp_hi); //generate guess
                Console.Write(guess); //show guess to user
                String feed = Console.ReadLine(); //take user's response as input
                if(feed.Equals("h")){ //if higher
                    temp_lo = guess; //current guess becomes new low bound
                }
                else if(feed.Equals("l")){//if lower
                    temp_hi = guess; //current guess becomes new high bound
                }
               else if (feed.Equals("o")){//if correct
                    found = true; //escape loop
                    Console.WriteLine("Yay! Let's play again sometime");//end game
                }
                else{//if input is invalid
                    Console.WriteLine("Error! Invalid input. please either enter l for lower, h for higher, or o for correct");//errorproofing
                }
                }

            }

        }
    }
