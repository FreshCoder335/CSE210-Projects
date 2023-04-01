// Jeremiah Powell 
// 3/21/23
using System;

public abstract class JPfirearmGeneral
{
    protected String _JPmanufacturer;
    protected String _JPfirearmName;
    protected String _JParmStyle;
    protected String _JPcapacity;
    protected String _JPcartridge;

    public JPfirearmGeneral(String JPmanufacturer, String JPfirearmName, String JParmStyle, String JPcapacity, String JPcartridge)
    {
        _JPmanufacturer = JPmanufacturer;
        _JPfirearmName = JPfirearmName;
        _JParmStyle = JParmStyle;
        _JPcapacity = JPcapacity;
        _JPcartridge = JPcartridge;

    }

    public abstract String JPtoString();
}