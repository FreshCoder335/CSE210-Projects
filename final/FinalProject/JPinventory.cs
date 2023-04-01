 // Jeremiah Powell 
// 3/21/23
using System;

public class JPinventory
{
    List<string> JPdisplayProper = new List<string>();
    public JPinventory()
    {

    }
    public void JPaddFirearm(string JPdata)
    {
        JPdisplayProper.Add(JPdata);
    }
    public void JPshowFirearms()
    {
        foreach(string JPdisplayFirearm in JPdisplayProper)
        {
            Console.WriteLine(JPdisplayFirearm);
        }
    }
}