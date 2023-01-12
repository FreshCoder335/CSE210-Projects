using System;
// Jeremiah Powell
// 1/11/2023
// CSE 210 3:15PM
class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int JPnum_selection = randomGenerator.Next(1,100);

        int JPuser_input = 0;

        while(JPuser_input != JPnum_selection)
        {
            Console.Write("What is your guess? ");
            JPuser_input = int.Parse(Console.ReadLine());

            if (JPnum_selection > JPuser_input)
            {
                Console.WriteLine("Higher");
            }
            else if (JPnum_selection < JPuser_input)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("That's the one!");
            }
        }
    }
}