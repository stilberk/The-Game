using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpriteAnimation
{
    class MenuButton
    {
        readonly Texture2D texture;
        Color color = new Color(255, 255, 255, 255);

        bool down;
        public bool isClicked;
        Vector2 position;
        Rectangle rectangle;

        public Vector2 size;

        public MenuButton(Texture2D newTexture, GraphicsDevice graphics)
        {
            texture = newTexture;
            //Screen W 1024, Screen H = 1024
            //button W 314, button H = 99
            size = new Vector2(graphics.Viewport.Width/3, graphics.Viewport.Height/10);
        }

        public void Update(MouseState mouse)
        {
            rectangle = new Rectangle((int) position.X, (int) position.Y, (int) size.X, (int) size.Y);

            Rectangle mouseRectangle = new Rectangle(mouse.X, mouse.Y, 1, 1);

            if (mouseRectangle.Intersects(rectangle))
            {
                if (color.A == 255)
                {
                    down = false;
                }
                if (color.A == 0)
                {
                    down = true;
                }
                if (down)
                {
                    color.A += 17;
                }
                else
                {
                    color.A -= 17;
                }
                if (mouse.LeftButton == ButtonState.Pressed)
                {
                    isClicked = true;
                }
            }
            else if (color.A < 255)
            {
                color.A += 17;

                isClicked = false;
            }
        }

        public void setPosition(Vector2 newPosition)
        {
            position = newPosition;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rectangle, color);
        }
    }
}