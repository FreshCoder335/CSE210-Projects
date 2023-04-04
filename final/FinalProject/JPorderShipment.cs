// Jeremiah Powell 
// 3/21/23
using System;

public class JPorderShipment
{
    protected String _JPshipment;
    protected String _JPcurrentInventory;

    public JPorderShipment(string JPshipment, string JPcurrentIventory)
    {
        _JPshipment = JPshipment;
        _JPcurrentInventory = JPcurrentIventory;
    }

    public string JPtoString()
    {
        return$"{_JPshipment} \n {_JPcurrentInventory}";
    }
}