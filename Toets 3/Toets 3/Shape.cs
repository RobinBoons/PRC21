using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toets_3
{
    public abstract class Shape: IComparable, IDrawable
    {
        private int X { get; set; }
        private int Y { get; set; }
        private int Z { get; set; }
        private abstract double Area { get; set; }
        private Color Color { get; set; }

        private Shape(int x, int y, int z, Color color)
        {
            X = x;
            Y = y;
            Z = z;
            Color = color;
        }

        public abstract void DrawTo(Graphics drawingSurface)
        {
            ;
        }
    }
}
 