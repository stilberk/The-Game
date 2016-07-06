using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeynmanGame.Controllers
{
    using Models;

    public class CollisionHandler
    {
        Rectangle heroBounds;
        private MapEnvironment mapObjects;

        public CollisionHandler(Rectangle heroBounds)
        {
            this.heroBounds = heroBounds;
            this.mapObjects = new MapEnvironment();
        }

        public bool CollisionControler(Rectangle heroBounds)
        {
            bool haveCollision = false;
            foreach (var obj in mapObjects.GetMapObjects)
            {
                if (obj.Intersects(heroBounds))
                {
                    haveCollision = true;
                    break;
                }
            }
            return haveCollision;
        }

    }
}
