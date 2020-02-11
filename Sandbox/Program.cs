using System;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int yesCounter = 1;
            int noCounter = 2;
            int totalVotes = yesCounter + noCounter;
            var yesPercentage = Math.Round((yesCounter * 100.00) / totalVotes,2);
            var noPercentage = Math.Round((noCounter * 100.00) / totalVotes,2);

            Console.WriteLine($"Total Yes Precentage {yesPercentage}%");
            Console.WriteLine($"Total No Precentage {noPercentage}%");

            if (yesCounter > noCounter)
            { 
                Console.WriteLine($"Yes Votes Win: {yesCounter}"); 
            }
            else if(noCounter > yesCounter)
            {
                Console.WriteLine($"No Votes Win: {noCounter}");
            }
            else
            {
                Console.WriteLine("No Winner! It is a Draw");
            }
        }
    }
}
