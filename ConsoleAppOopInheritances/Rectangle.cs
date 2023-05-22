
namespace ConsoleAppOopInheritances
{
    public class Rectangle: Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        //overloading
        public Rectangle()
        {
            Width = 1.0;
            Height = 1.0;
        }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double GetArea()
        {
            return Height * Width;
        }

        //chu vi
        public double GetPerimetter()
        {
            return 2 * (Height + Width);
        }

        public override string ToString()
        {
            return $"The rectangle has width: {Width}, Height: {Height}, Area: {GetArea()}, Perimetter: {GetPerimetter()}" +
                $", {base.ToString()}";
        }



    }
}
