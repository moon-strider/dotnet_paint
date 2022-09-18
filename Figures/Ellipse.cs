using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGE.Figures
{
    internal class Ellipse : Figure
    {
        public Ellipse(float x, float y, float w, float h) : base(x, y, w, h)
        {
        }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(Pens.Black, X, Y, W, H);
        }
    }
}
