

namespace ConsoleAppAbstractClassInterface
{
    public class Rectangle : AbsShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle()
        {
            
        }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }

        public override double GetPerimetter()
        {
            return 2 * (Width + Height);
        }
    }
}
