using System;

public class JPjob_description 
{
    public string JPtitle;
    
    public string JPcompany_name;

    public int JPsignon_year;

    public int JPsignoff_year;

    public void Display()
    {
        Console.WriteLine($"{JPtitle} ({JPcompany_name}) {JPsignon_year}-{JPsignoff_year}");
    }
}
