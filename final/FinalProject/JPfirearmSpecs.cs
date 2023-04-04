// Jeremiah Powell 
// 3/21/23
using System;

public class JPfirearmSpecs : JPfirearmGeneral
{
    protected String _JPbarrelLength;
    protected String _JPfirearmWeight;
    protected String _JProundsPerMinute;

    public JPfirearmSpecs(string JPbarrelLength, string JPfirearmWeight, string JProundsPerMinute, string _JPmanufacturer, string _JPfirearmName, string _JParmStyle, string _JPcapacity, string _JPcartridge) : 
    base(_JPmanufacturer, _JPfirearmName, _JParmStyle, _JPcapacity, _JPcartridge)
    {
        _JPbarrelLength = JPbarrelLength; 
        _JPfirearmWeight = JPfirearmWeight;
        _JProundsPerMinute = JProundsPerMinute;

    }
    public override string JPtoString()
    {
        return$"{_JPbarrelLength} \n {_JPfirearmWeight} \n {_JProundsPerMinute} \n{_JPmanufacturer} \n {_JPfirearmName} \n {_JParmStyle} \n {_JPcapacity} \n {_JPcartridge}";
    }
}