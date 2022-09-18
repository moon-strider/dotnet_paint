using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VGE.Figures;

namespace VGE.Creators
{
    internal class EllipseCreator : Creator
    {
        public override Ellipse Create(float x, float y, float w, float h)
        {
            return new Ellipse(x, y, w, h);
        }
    }
}
