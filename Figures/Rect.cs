using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGE.Figures
{
    internal class Rect : Figure
    {
        public Rect(float x, float y, float w, float h) : base(x, y, w, h)
        {

        }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(Pens.Black, (int)X, (int)Y, (int)W, (int)H);
        }
    }
}
