// This is an exercise on Liskov Substitution Principle.
// We were given a code that was not correct, according to the principle.

using System;

namespace Geometry
{
    class Polygon
    {
        public abstract double Area 
        { 
            get;
        }
        // Added area as an abstract property that each derived class must implement according to its specific calculations
        public abstract double GetArea();
        // Because a SetArea would not be a method easily defined in the Polygon class that would suit both Rectangle and Square, it's better to have an abstract method that the derived classes must implement
    }
    class Rectangle : Polygon
    {
        private double width;
        private double height;
        public void SetWidth(double width)
        {
            this.width = width;
        }
        public void SetHeight(double height)
        {
            this.height = height;
        }
        public double GetWidth()
        {
            return width;
        }

        public double GetHeight()
        {
            return height;
        }
        public override double GetArea()
        {
            return width * height;
        }
    }

    class Square : Polygon
    {
        private double width;
        public void SetWidth(double width)
        {
            this.width = width;
        }
        public double GetWidth()
        {
            return width;
        }
        public override double GetArea()
        {
            return width * width;
        }
    }
}
