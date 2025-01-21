namespace TheMagicCannon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Starts the hitcounter at 1 and created a boolean for the while loop
            bool isRunning = true;
            int hitCounter = 1;

            while (isRunning)
            {
               

                if (hitCounter <= 100) // To make sure the loop runs only if the counter is below 101
                {
                    if (hitCounter % 3 == 0 && hitCounter % 5 == 0) // If the counter can be divided by both 3 and 5
                    {
                        Console.ForegroundColor = ConsoleColor.Blue; //turns text blue
                        Console.WriteLine($"{hitCounter}: COMBINED BLAST");
                        
                    }

                    else if (hitCounter % 3 == 0) // If the counter can be divided by 3
                    {
                        Console.ForegroundColor = ConsoleColor.Red; // turns text red
                        Console.WriteLine($"{hitCounter}: Fire");
                        
                    }
                    else if (hitCounter % 5 == 0){ // if the counter can be divided by 5
                        Console.ForegroundColor = ConsoleColor.Yellow; // turns text yellow
                        Console.WriteLine($"{hitCounter}: Electric");
                        
                    }
                    
                    else // when the counter can't be divided by 3 or 5
                    {
                        Console.ForegroundColor = ConsoleColor.White; // turns the text white
                        Console.WriteLine($"{hitCounter}: Normal");
                        
                    }
                    hitCounter++; // +1 to the counter


                }
                else // exits the while loop once the counter reaches a number greater than 100
                {
                    isRunning = false;
                
                }





            }
        }
    }
}
