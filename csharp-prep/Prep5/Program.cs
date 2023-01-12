using System;
// Jeremiah Powell
// 1/11/2023
// CSE 210 3:15PM
class Program
{
    static void Main(string[] args)
    {
        JPwelcome_popup();
        string JPgiven_name = JPname_prompt();
        int JPgiven_number = JPnum_prompt();
        int JPnum_square = JPresult(JPgiven_number);

        JPfull_Result(JPgiven_name, JPnum_square);
    }
    static void JPwelcome_popup()
    {
        Console.WriteLine("Welcome to an introductory Program! ");
    }
    static string JPname_prompt()
    {
        Console.Write("Would you enter your name please? ");
        string JPst_response = Console.ReadLine();
        return JPst_response;
    }
    static int JPnum_prompt()
    {
        Console.Write("What is your favorite number? ");
        int JPfav_num = int.Parse(Console.ReadLine());
        return JPfav_num;
    }
    static int JPresult(int JPfav_num)
    {
        int JPmath_value = JPfav_num * JPfav_num;
        return JPmath_value;
    }
    static void JPfull_Result(string JPst_response, int JPmath_value)
    {
        Console.WriteLine($"Wonderful {JPst_response}! The square of your favorite number is {JPmath_value}!");
    }
}