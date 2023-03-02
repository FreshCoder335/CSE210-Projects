//Jeremiah Powell, 3/1/23
using System;
public class Square : JPShape
{
    private double _JPsidelength;

    public Square(string JPcolor, double JPcalculatdlength) : base (JPcolor)
    {
        _JPsidelength = JPcalculatdlength;
    }
    public override double GetArea()
    {
        return _JPsidelength * _JPsidelength;
    }
}