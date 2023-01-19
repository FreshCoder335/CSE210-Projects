using System;

public class JPresume
{
    public string JPemp_name;

    public List<JPjob_description> JPjob_listing = new List<JPjob_description>();

    public void Display()
    {
        Console.WriteLine($"Name: {JPemp_name}");
        Console.WriteLine("Jobs: ");
        foreach (JPjob_description jPjob_Description in JPjob_listing)
        {
            jPjob_Description.Display();
        }
    }
}