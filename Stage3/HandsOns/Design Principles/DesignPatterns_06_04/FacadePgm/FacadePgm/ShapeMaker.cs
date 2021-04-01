using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePgm
{
    //FacadeClass
    class ShapeMaker
    {
        public Shape circle;
        public Shape rectangle;
        public Shape square;

        public ShapeMaker()
        {
            circle = new Circle();
            rectangle = new Rectangle();
            square = new Square();
        }

        public void drawCircle()
        {
            circle.draw();
        }

        public void drawRectangle()
        {
            rectangle.draw();
        }

        public void drawSquare()
        {
            square.draw();
        }

    }
}
