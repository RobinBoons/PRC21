using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toets_3
{
    interface IDrawable
    {
       void DrawTo(Graphics drawingSurface);
    }
}
