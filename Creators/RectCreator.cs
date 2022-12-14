using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VGE.Figures;

namespace VGE.Creators
{
    internal class RectCreator : Creator
    {
        public override Figure Create(float x, float y, float w, float h)
        {
            return new Rect(x, y, w, h);
        }
    }
}
