using System;

namespace FirstCprogram
{
    class Program
    {
        static void Main()
        {
            double runningTotal = 0;
            bool keepGoing = true;

            while (keepGoing)
            {
                //Prompt the user for minutes exercised
                Console.Write( "How many minutes did you exercise or type \"quit\" to exit: " );

                //Collect user input and save to variable
                string entry = Console.ReadLine();
                
                if (entry.ToLower() == "quit") 
                {
                    keepGoing = false;
                }
                else
                {
                    try
                    {
                         //Parse user input for integer and add to the running total
                        double minutes = double.Parse(entry);

                        if(minutes <=0)
                        {
                            Console.WriteLine(minutes + " is not an acceptable value");
                            continue;
                        }
                        else if(minutes <= 10)
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
                    }
                        catch(FormatException)
                    {
                        Console.WriteLine("Invalid input: non-numeric entry");
                        continue;
                    }
                    

                    //Display total mins exercies to the screen
                    Console.WriteLine("You've exercised " + runningTotal + " minutes");
                    //repeat until the user quits
                }
                
            }

            Console.WriteLine("Goodbye");
        }
    }
}
