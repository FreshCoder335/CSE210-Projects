using System;

class Program
{
    static void Main(string[] args)
    {
        JPjob_description jPjob_Description1 = new JPjob_description();
        jPjob_Description1.JPtitle = "Project Manager";
        jPjob_Description1.JPcompany_name = "AMD";
        jPjob_Description1.JPsignon_year = 2000;
        jPjob_Description1.JPsignoff_year= 2010;

        JPjob_description jPjob_Description2 = new JPjob_description();
        jPjob_Description2.JPtitle = "Lead graphics engineer";
        jPjob_Description2.JPcompany_name = "Intel";
        jPjob_Description2.JPsignon_year = 2010;
        jPjob_Description2.JPsignoff_year = 2023;

        JPresume JPpersonal_resume = new JPresume();
        JPpersonal_resume.JPemp_name = "Marcus Hollaway";

        JPpersonal_resume.JPjob_listing.Add(jPjob_Description1);
        JPpersonal_resume.JPjob_listing.Add(jPjob_Description2);

        JPpersonal_resume.Display();
    }
}