using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VGE.Figures;

namespace VGE.Creators
{
    internal class PrototypeCreator : Creators.Creator
    {
        private Figure proto;

        public PrototypeCreator()
        {
            Proto = new Rect(20, 20, 20, 20);
        }

        public Figure Proto
        {
            get => proto;
            set
            {
                proto = value;
            }
        }
        public override Figure Create(float x, float y, float w, float h)
        {
            Figure fig = proto.Clone();
            fig.Move(x, y);
            return fig;
        }
    }
}
