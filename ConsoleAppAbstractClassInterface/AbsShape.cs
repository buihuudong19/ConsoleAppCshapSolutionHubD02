

namespace ConsoleAppAbstractClassInterface
{
    public abstract class AbsShape
    {
        //1. thuoc tinh 
        public string Color { get; set; }
        //2. constructors
        public AbsShape() {
            Color = "Blue";
        }

        protected AbsShape(string color)
        {
            Color = color;
        }
        public abstract double GetArea();
        public abstract double GetPerimetter();

        public override string ToString()
        {
            return $" Color: {Color}, Area: {GetArea()} and Perimetter: {GetPerimetter()}";
        } 
    }
}
