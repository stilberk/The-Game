using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace SpriteAnimation
{
    public class KnoledgeBook
    {
        private Texture2D bookImg;

        public KnoledgeBook(Texture2D img)
        {
            this.bookImg = img;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            int width = bookImg.Width;
            int height = bookImg.Height;
            Vector2 location = new Vector2(90, 240);
            spriteBatch.Draw(bookImg, location, Color.White);
        }
    }
}
