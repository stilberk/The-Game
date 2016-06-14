using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace SpriteAnimation
{
    public class KnoledgeBook
    {
        private Texture2D bookImg;

        private Vector2 location;
        private Rectangle bookBoundaries;

        public KnoledgeBook(Texture2D img)
        {
            this.bookImg = img;
            location = new Vector2(90, 240);
            this.bookBoundaries = new Rectangle(90,240,64,64);
            //this.BookBoundaries.Offset(this.location);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            int width = bookImg.Width;
            int height = bookImg.Height;
            spriteBatch.Draw(bookImg, location, Color.White);
        }

        public Rectangle BookBoundaries
        {
            get
            {
                return this.bookBoundaries;
            }
        }
    }
}
