// Jeremiah Powell 
// 3/21/23
using System;

public class JPmenu
{
    public JPmenu()
    {

    }

    public void JPmenuSelection()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1). Order Shipment");
        Console.WriteLine("2). Display current inventory");
        Console.WriteLine("3).Display Firearm and munition specifications.");
        Console.WriteLine("4). Quit program");

    }

    public string JPuserSelection()
    {
        Console.Write("Please select the numerical value of the choice you with to procceed with ");
        return Console.ReadLine();
    }
}