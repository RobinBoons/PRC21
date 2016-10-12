using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toets_3
{
    public class Circle : Shape
    {
        public int Radius { get; private set; }
        public override double Area { get; set; }

        public Circle(int x, int y, int z, Color color, int radius) : base(x, y, z, color)
        {
            Radius = radius;
        }

        public override void DrawTo(Graphics drawingSurface)
        {
            
        }
    }
}
