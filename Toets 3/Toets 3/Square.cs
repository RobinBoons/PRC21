using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toets_3
{
    class Square : Shape
    {
        private int Lenght { get; set; }
        private double Area { get; set; }

        public Square(int x, int y, int z, Color color, int length) : base(x, y, z, color)
        {
            Lenght = length;
        }

        public override void DrawTo(Graphics drawingSurface)
        {
            
        }
    }
}
