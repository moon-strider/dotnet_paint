using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGE.Figures
{
    internal abstract class Figure
    {
        private float x, y;
        private float w, h;
        public Figure(float x, float y, float w, float h)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
        }

        public float X { get => x; }
        public float Y { get => y; }
        public float W { get => w; }
        public float H { get => h; }
        public virtual void Move(float new_x, float new_y)
        {
            x = new_x;
            y = new_y;
        }
        public virtual void MoveRelative(float dx, float dy)
        {
            x += dx;
            y += dy;
        }
        public virtual void Resize(float new_w, float new_h)
        {
            w = new_w;
            h = new_h;
        }
        public abstract void Draw(Graphics g);
        public Figure Clone() => MemberwiseClone() as Figure;
    }
}
