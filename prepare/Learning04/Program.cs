// Jeremiah Powell 2/15/23
using System;

class Program
{
    static void Main(string[] args)
    {
        JPAssignment A1 = new JPAssignment("Marcus Redfall", "Derivatives");
        Console.WriteLine(A1.JPcreateSummary());

        JParithmeticAssignment A2 = new JParithmeticAssignment("Joseph Fenix", "Intergrals", "9.8", "22-27");
        Console.WriteLine(A2.JPcreateSummary());
        Console.WriteLine(A2.JPsaveHomeworkAssignment());

        JPliteratureAssignment A3 = new JPliteratureAssignment("Sydney Madison", "Persian Rule", "The rise of nations during the Iron Age");
        Console.WriteLine(A3.JPcreateSummary());
        Console.WriteLine(A3.JPsaveWritingWork());
    }
}