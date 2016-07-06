using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeynmanGame.Models
{
    public class Stop
    {
        public Vector2 locationStop;
        private Rectangle boundStop;

        public Stop()
        {
            locationStop = new Vector2(304, 100);
            this.boundStop = new Rectangle(512, 885, 59, 59);
        }

        public Rectangle Boundaries
        {
            get
            {
                return this.boundStop;
            }
        }
    }
}
