using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpriteAnimation
{
    public class MapBoundariesLevel2
    {
        private List<Rectangle> mapObjLevel2;

        public MapBoundariesLevel2()
        {
            this.mapObjLevel2 = new List<Rectangle>();
        }

        public List<Rectangle> MapObjLevel2
        {
            get
            {
                return this.mapObjLevel2;
            }
        }
    }
}
