using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("What is your grade Percent? ");
        string JPresponse = Console.ReadLine();
        int JPgrade = int.Parse(JPresponse);

        string JPvalue = "";

        if (JPgrade >= 90)
        {
           JPvalue = "A";
        }
        else if (JPgrade >= 80)
        {
            JPvalue = "B";
        }
        else if (JPgrade >= 70)
        {
            JPvalue = "C";
        }
        else if (JPgrade >= 60)
        {
            JPvalue = "D";
        }
        else
        {
            JPvalue = "F";
        }

        Console.WriteLine($"Your Class Grade is: {JPvalue}");
        if (JPgrade >= 70)
        {
            Console.WriteLine("You have passed this class. Congragulations!");
        }
        else
        {
            Console.WriteLine("You can always retake the course. ");
        }
    }
}