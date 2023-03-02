//Jeremiah Powell, 3/1/23
using System;
public abstract class JPShape
{
    private string _JPcolor;

    public JPShape(string JPpigment)
    {
        _JPcolor = JPpigment;
    }

    public string GetColor()
    {
        return _JPcolor;
    }

    public void SetColor(string JPpigment)
    {
        _JPcolor = JPpigment;
    }


    public abstract double GetArea();
}