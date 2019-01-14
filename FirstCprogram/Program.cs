using System;

namespace FirstCprogram
{
    class Program
    {
        static void Main()
        {
            int runningTotal = 0;
            bool keepGoing = true;

            while (keepGoing)
            {
                //Prompt the user for minutes exercised
                Console.Write( "How many minutes did you exercise or type \"quit\" to exit: " );

                //Collect user input and save to variable
                string entry = Console.ReadLine();
                
                if (entry == "quit") 
                {
                    keepGoing = false;
                }
                else
                {
                    //Parse user input for integer and add to the running total
                    int minutes = int.Parse(entry);

                        if(minutes <= 10)
                        {
                            Console.WriteLine("Better than nothing, am right?");
                        }
                        else if(minutes <= 30)
                        {
                            Console.WriteLine("Way to go hot stuff");
                        }
                        else
                        {
                            Console.WriteLine("Okay, now you're just showing");
                        }
                    runningTotal = runningTotal + minutes;

                    //Display total mins exercies to the screen
                    Console.WriteLine("You've exercised " + runningTotal + " minutes");
                    //repeat until the user quits
                }
                
            }

            Console.WriteLine("Goodbye");
        }
    }
}
