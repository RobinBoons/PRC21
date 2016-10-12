using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toets_3
{
    public abstract class Shape : IComparable<Shape>, IDrawable
    {
        public int CompareTo(Shape otherShape)
        {
            return Z.CompareTo(otherShape.Z);
        }
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Z { get; private set; }
        public abstract double Area { get; set; }
        public Color Color { get; private set; }

        protected Shape(int x, int y, int z, Color color)
        {
            X = x;
            Y = y;
            Z = z;
            Color = color;
        }

        public abstract DrawTo(Graphics drawingSurface)
        {
            ;
        }
    }
}
 