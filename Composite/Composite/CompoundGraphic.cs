using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class CompoundGraphic : IGraphic
    {
        private List<IGraphic> compoundGraphic;

        public void AddItem(IGraphic graphic)
        {
            compoundGraphic.Add(graphic);
        }

        public void RemoveItem(IGraphic graphic)
        {
            compoundGraphic.Remove(graphic);
        }

        public override void Draw()
        {
            foreach (var graphic in compoundGraphic)
            {
                graphic.Draw();
            }
        }

        public override void Move(int x, int y)
        {
            foreach (var graphic in compoundGraphic)
            {
                graphic.Move(x, y);
            }
        }
    }
}
