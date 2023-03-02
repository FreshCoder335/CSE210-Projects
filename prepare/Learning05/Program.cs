//Jeremiah Powell, 3/1/23
using System;

class Program
{
    static void Main(string[] args)
    {

        List<JPShape> JPgivenShapes = new List<JPShape>();

        Square s1 = new Square("Cyan", 5);
        JPgivenShapes.Add(s1);

        JPrectangle s2 = new JPrectangle("Magenta", 9, 33);
        JPgivenShapes.Add(s2);

        JPcircle s3 = new JPcircle("Dark Yellow", 9);
        JPgivenShapes.Add(s3);

        foreach (JPShape s in JPgivenShapes)
        {
            string JPcolor = s.GetColor();
            double JParea = s.GetArea();

            Console.WriteLine($"The designated {JPcolor} shape has a calculated area of:  {JParea}.");
        }
     
    }
}