using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePgm
{
    interface Shape
    {
        public void draw();
    }

    //Subsystem 1
    public class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("CIRCLE");
        }
    }

    //Subsystem 2
    public class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("RECTANGLE");
        }
    }


    //Subsystem 3
    public class Square : Shape
    {
        public void draw()
        {
            Console.WriteLine("SQUARE");
        }
    }
}
