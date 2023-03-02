//Jeremiah Powell, 3/1/23
using System;

public class JPcircle : JPShape
{
    private double _JPradius;

    public JPcircle(string JPcolor, double JPradius) : base (JPcolor)
    {
        _JPradius = JPradius;
    }

    public override double GetArea()
    {
        return _JPradius * _JPradius * Math.PI;
    }
}