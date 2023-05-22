using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOopInheritances
{
    public class Shape
    {
        //properties
        public string Color { get; set;}
        public DateTime DateCreate { get; set;}

        public Shape()
        {
        }
        public Shape(string color, DateTime dateCreate)
        {
            Color = color;
            DateCreate = dateCreate;
        }

        public override string ToString()
        {
            return $"Color = {Color} and Date Create:{DateCreate}";
        }

    }
}
