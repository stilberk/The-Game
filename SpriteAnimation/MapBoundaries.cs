using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpriteAnimation
{
    using Microsoft.Xna.Framework;

    public class MapBoundaries
    {
        private List<Rectangle> mapObj;
        private Rectangle treesP1;

        public MapBoundaries()
        {
            this.mapObj = new List<Rectangle>();
            this.treesP1 = new Rectangle(0, 0, 114, 143);
            this.mapObj.Add(this.treesP1);
        }


        public List<Rectangle> MapObjects
        {
            get
            {
                return this.mapObj;
            }
        }
    }
}
