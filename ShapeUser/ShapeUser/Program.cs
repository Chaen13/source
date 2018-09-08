namespace shapeuser
{
    using System;
    using Shapes;

    public class ShapeUser
    {
        public static void Main(string[] args)
        {
            Circle c = new Circle(1.0f);
            Console.WriteLine("Area of Circle(1.0) is {0}", c.Area());
        }
    }
}
