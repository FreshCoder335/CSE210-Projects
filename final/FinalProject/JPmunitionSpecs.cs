// Jeremiah Powell 
// 3/21/23
using System;

public class JPmunitionSpecs 
{
    protected String _JPgrains;
    protected String _JPtotalLength;
    protected String _JPmuzzleVelocity;

    public JPmunitionSpecs(string JPgrains, string JPtotalLength, string JPmuzzleVelocity) 
    
    {
        _JPgrains = JPgrains;
        _JPtotalLength = JPtotalLength;
        _JPmuzzleVelocity = JPmuzzleVelocity;
    }

    public string JPtoString()
    {
        return$"{_JPgrains} \n {_JPtotalLength} \n {_JPmuzzleVelocity}";
    }
}
