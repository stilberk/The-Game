using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace SpriteAnimation
{
    class Stop
    {
        private Texture2D imgStop;

        public Vector2 locationStop;
        private Rectangle boundStop;

        public Stop(Texture2D ingStop)
        {
            this.imgStop = ingStop;
            locationStop = new Vector2(304, 100);
            this.boundStop = new Rectangle(572,885,59,146);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            int width = imgStop.Width;
            int height = imgStop.Height;
            spriteBatch.Draw(imgStop, locationStop, Color.White);
        }
        public Rectangle BookBoundaries
        {
            get
            {
                return this.boundStop;
            }
        }

        public Vector2 GetCenterStop()
        {
            float x = locationStop.X + BookBoundaries.Width / 2;
            float y = locationStop.Y + BookBoundaries.Height / 2;
            return new Vector2(x, y);
        }

        

    }
}
