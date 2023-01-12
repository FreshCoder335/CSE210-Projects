using System;
// Jeremiah Powell
// 1/11/2023
// CSE 210 3:15PM

using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> JPuser_lists = new List<int>();

        int JPfirst_number = -1;
        while (JPfirst_number != 0)
        {
            Console.WriteLine("Welcome to your numeric list builder! ");
            Console.Write("You may begin by adding numbers and when you are done, type 0. ");

            string JPfirst_response = Console.ReadLine();
            JPfirst_number = int.Parse(JPfirst_response);
            if (JPfirst_number != 0)
            {
                JPuser_lists.Add(JPfirst_number);
            }
        }
        int JPsum_response = 0;
        foreach (int JPuser_list in JPuser_lists)
        {
            JPsum_response += JPuser_list;
        }
        Console.WriteLine($"Your total sum of your list is: {JPsum_response}");
        float JPaverage_response = ((float)JPsum_response) / JPuser_lists.Count;
        Console.WriteLine($"The average of your compiled list is: {JPaverage_response}");
        int JPmax_response = JPuser_lists[0];
        foreach (int JPuser_list in JPuser_lists)
        {
            if(JPuser_list > JPmax_response)
            {
                JPmax_response = JPuser_list;
            }
        }
        Console.WriteLine($"The Largest number in your list is: {JPmax_response}");
    }
}