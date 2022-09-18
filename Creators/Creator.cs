using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGE.Creators
{
    internal abstract class Creator
    {
        public abstract Figures.Figure Create(float x, float y, float w, float h);
    }
}
