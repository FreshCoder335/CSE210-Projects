using System;

class Program
{
    static void Main(string[] args)
    {
        JPfraction version1 = new JPfraction();
        Console.WriteLine(version1.JPstringforfraction());
        Console.WriteLine(version1.JPdecimalvalue());

        JPfraction version2 = new JPfraction(8);
        Console.WriteLine(version2.JPstringforfraction());
        Console.WriteLine(version2.JPdecimalvalue());

        JPfraction version3 = new JPfraction(2,7);
        Console.WriteLine(version3.JPstringforfraction());
        Console.WriteLine(version3.JPdecimalvalue());

        JPfraction version4 = new JPfraction(5,9);
        Console.WriteLine(version4.JPstringforfraction());
        Console.WriteLine(version4.JPdecimalvalue());
    }
}