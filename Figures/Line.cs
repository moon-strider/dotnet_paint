using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGE.Figures
{
    internal class Line : Figure
    {
        public Line(float x, float y, float w, float h) : base(x, y, w, h)
        {
        }

        public override void Draw(Graphics g)
        {
            g.DrawLine(Pens.Black, X, Y, X+W, Y+H);
        }
    }
}
