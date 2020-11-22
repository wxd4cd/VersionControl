using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToysFactory.Abstractions;

namespace ToysFactory.Entities

{
    public class Present : Toy
    {
        public SolidBrush BoxColor { get; private set; }
        public SolidBrush RibbonColor { get; private set; }

        public Present(Color boxColor, Color ribbonColor)
        {
            BoxColor = new SolidBrush(boxColor);
            RibbonColor = new SolidBrush(ribbonColor);
        }
        private protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(BoxColor, new Rectangle(0, 0, Width, Height));
            g.FillRectangle(RibbonColor, new Rectangle(20, 0, 30, Height));
        }
    }
}
