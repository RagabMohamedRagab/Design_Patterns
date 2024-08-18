using System;

namespace Facade_Patterns.Facade
{
    public class ShapeMaker
    {
        private readonly Circle _circle;
        private readonly Rectangle _rectangle;
        private readonly Square _square;

        public ShapeMaker()
        {
            _circle = new Circle();
            _rectangle = new Rectangle();
            _square = new Square();
        }

        public void DrawCircle()
        {
            _circle.Draw();
        }

        public void DrawRectangle()
        {
            _rectangle.Draw();
        }

        public void DrawSquare()
        {
            _square.Draw();
        }
    }
}
