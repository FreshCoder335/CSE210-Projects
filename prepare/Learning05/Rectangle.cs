//Jeremiah Powell, 3/1/23

using System;
public class JPrectangle : JPShape
{
    private double _JPlength;
    private double _JPwidth;

    public JPrectangle(string JPcolor, double JPlength, double JPwidth) : base (JPcolor)
    {
        _JPlength = JPlength;
        _JPwidth = JPwidth;
    }
    public override double GetArea()
    {
        return _JPlength * _JPwidth;
    }
}