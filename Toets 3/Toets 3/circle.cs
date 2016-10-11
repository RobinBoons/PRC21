using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toets_3
{
    public class circle : Shape
    {
        private int Radius { get; set; }
        private double Area { get; set; }

        public Circle(int x, int y, int z, Color color, int radius) : base(x, y, z, color)
        {
            Radius = radius;
        }

        public override void DrawTo(Graphics drawingSurface)
        {
            
        }
    }
}
