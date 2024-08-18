using System;
using Facade_Patterns.Facade;

namespace Facade_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the facade
            ShapeMaker shapeMaker = new ShapeMaker();

            // Use the facade to draw shapes
            shapeMaker.DrawCircle();
            shapeMaker.DrawRectangle();
            shapeMaker.DrawSquare();
        }
    }
}
