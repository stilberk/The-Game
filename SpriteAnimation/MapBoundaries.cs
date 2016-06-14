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
        private Rectangle treesP2;
        private Rectangle treesP3;
        private Rectangle treesP4;
        private Rectangle treesP5;
        private Rectangle treesP6;
        private Rectangle treesP7;
        private Rectangle treesP8;
        private Rectangle treesP9;

        public MapBoundaries()
        {
            this.mapObj = new List<Rectangle>();

            this.treesP1 = new Rectangle(0, 0, 290, 145);
            this.mapObj.Add(this.treesP1);

            this.treesP2 = new Rectangle(330, 305, 100, 75);
            this.mapObj.Add(this.treesP2);

            this.treesP3 = new Rectangle(555, 595, 100, 75);
            this.mapObj.Add(this.treesP3);

            this.treesP4 = new Rectangle(750, 500, 100, 75);
            this.mapObj.Add(this.treesP4);

            this.treesP5 = new Rectangle(925, 330, 100, 75);
            this.mapObj.Add(this.treesP5);

            this.treesP6 = new Rectangle(925, 760, 100, 75);
            this.mapObj.Add(this.treesP6);

            this.treesP7 = new Rectangle(65, 680, 100, 75);
            this.mapObj.Add(this.treesP7);

            this.treesP8 = new Rectangle(30, 310, 100, 75);
            this.mapObj.Add(this.treesP8);

            this.treesP9 = new Rectangle(355, 0, 620, 145);
            this.mapObj.Add(this.treesP9);

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
