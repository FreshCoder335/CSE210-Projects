using System;

public class JPfraction
{
    private int _JPnumerator;
    private int _JPdenominator;

    public JPfraction()
    {
        _JPnumerator = 1;
        _JPdenominator = 1;
    }
    public JPfraction(int JPwholeNumber)
    {
        _JPnumerator = JPwholeNumber;
        _JPdenominator = 1;
    }
    public JPfraction(int JPnumerator, int JPdenominator)
    {
        _JPnumerator = JPnumerator;
        _JPdenominator = JPdenominator;
    }
    public string JPstringforfraction()
    {
    string JPinput = $"{_JPnumerator}/{_JPdenominator}";
    return JPinput;
    }
    public double JPdecimalvalue()
    {
        return (double)_JPnumerator / (double)_JPdenominator;
    }
}