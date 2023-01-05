using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string JP1name = Console.ReadLine();
        Console.Write("What is your last name? ");
        string JP2name = Console.ReadLine();

        Console.WriteLine($"Your name is {JP2name}, {JP1name} {JP2name}. ");
    }
}