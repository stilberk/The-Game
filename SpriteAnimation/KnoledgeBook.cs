using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace SpriteAnimation
{
    public class KnoledgeBook
    {
        private Texture2D bookImg;

        public Vector2 location;
        private Rectangle bookBoundaries;

        public KnoledgeBook(Texture2D img)
        {
            this.bookImg = img;
            location = new Vector2(90, 240);
            this.bookBoundaries = new Rectangle(120,270,64,64);
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

        public Vector2 GetCenterBook()
        {
            float x = location.X + bookBoundaries.Width / 2;
            float y = location.Y + bookBoundaries.Height / 2;
            return new Vector2(x, y);
        }

        static Random ran = new Random();

        public Vector2 RandamPlace()
        {
            
            float x = ran.Next(20, 800);
            float y = ran.Next(20, 800);
            return new Vector2(x, y);
        }
    }
}
