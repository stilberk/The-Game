using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace SpriteAnimation
{
    public class Player
    {
        //private AnimatedSprite animatedSprite;
        //private AnimatedSprite animatedSpriteDown;
        //private AnimatedSprite animatedSpriteLeft;
        //private AnimatedSprite animatedSpriteRight;
        //private AnimatedSprite animatedSpriteStandingDown;
        //private AnimatedSprite animatedSpriteStandingLeft;
        //private AnimatedSprite animatedSpriteStandingRight;
        //private AnimatedSprite animatedSpriteStandingUp;
        //private AnimatedSprite animatedSpriteUp;
        private string lastDirection = "down";
        private Vector2 heroLocation;

        private List<Rectangle> objOnMap; 
        private Vector2 currentLocation;
        private bool heroColide = false;
        const int HEROSPEED = 15;
        const int BGRSPEED = 35;

        private Rectangle heroBoundaries;


        public Player(Texture2D standingRight, Texture2D heroTexture, Texture2D rightTexture, Texture2D upTexture,
                        Texture2D downTexture, Texture2D standingLeft, Texture2D standingDown, Texture2D standingUp,
                        List<Rectangle> mapObjects)
        {
            AnimatedSprite = new AnimatedSprite(standingRight, 1, 9);
            AnimatedSpriteLeft = new AnimatedSprite(heroTexture, 1, 9);
            AnimatedSpriteRight = new AnimatedSprite(rightTexture, 1, 9);
            AnimatedSpriteUp = new AnimatedSprite(upTexture, 1, 9);
            AnimatedSpriteDown = new AnimatedSprite(downTexture, 1, 9);
            AnimatedSpriteStandingLeft = new AnimatedSprite(standingLeft, 1, 1);
            AnimatedSpriteStandingRight = new AnimatedSprite(standingRight, 1, 1);
            AnimatedSpriteStandingDown = new AnimatedSprite(standingDown, 1, 1);
            AnimatedSpriteStandingUp = new AnimatedSprite(standingUp, 1, 1);
            this.heroBoundaries = new Rectangle((int)this.heroLocation.X, (int)this.heroLocation.Y, 35, 49);
            heroLocation = new Vector2(304, 0);
            this.objOnMap = mapObjects;
        }

        public AnimatedSprite AnimatedSprite { get; set; }
        public AnimatedSprite AnimatedSpriteDown { get; set; }
        public AnimatedSprite AnimatedSpriteLeft { get; set; }
        public AnimatedSprite AnimatedSpriteRight { get; set; }
        public AnimatedSprite AnimatedSpriteStandingDown { get; set; }
        public AnimatedSprite AnimatedSpriteStandingLeft { get; set; }
        public AnimatedSprite AnimatedSpriteStandingRight { get; set; }
        public AnimatedSprite AnimatedSpriteStandingUp { get; set; }
        public AnimatedSprite AnimatedSpriteUp { get; set; }

        public Rectangle HeroBoundaries
        {
            get
            {
                return this.heroBoundaries;
            }

            set
            {
                this.heroBoundaries = value;
            }
        }

        public Vector2 HeroLocation
        {
            get
            {
                return this.heroLocation;
            }
            set
            {
                if (value.X < 1024 && value.X > 0 && value.Y < 1024 && value.X > 0)
                {
                    this.heroLocation = value;
                    this.heroBoundaries.X = (int)value.X;
                    this.heroBoundaries.Y = (int)value.Y;
                }
            }

        }

        private void LocationControl(Vector2 location)
        {
            this.heroBoundaries.X = (int)location.X;
            this.heroBoundaries.Y = (int)location.Y;
            this.heroColide = CollisionControler(this.objOnMap, this.heroBoundaries);

            if ((location.X < 960 && location.Y < 900) && (location.X > 0 && location.Y > 0) && !this.heroColide)
            {
                this.heroLocation = location;
                this.heroBoundaries.X = (int)location.X;
                this.heroBoundaries.Y = (int)location.Y;
            }
        }

        public void KeyListener()
        {
            var keyPressed = Keyboard.GetState();

            if (keyPressed.IsKeyDown(Keys.Right))
            {
                AnimatedSprite = AnimatedSpriteRight;
                lastDirection = "right";
                Vector2 newLocation = new Vector2 (heroLocation.X + HEROSPEED, heroLocation.Y);
                LocationControl(newLocation);                
            }

            if (keyPressed.IsKeyDown(Keys.Left))
            {
                AnimatedSprite = AnimatedSpriteLeft;
                lastDirection = "left";                
                Vector2 newLocation = new Vector2(heroLocation.X - HEROSPEED, heroLocation.Y);
                LocationControl(newLocation);
            }

            if (keyPressed.IsKeyDown(Keys.Up))
            {
                AnimatedSprite = AnimatedSpriteUp;
                lastDirection = "up";                
                Vector2 newLocation = new Vector2(heroLocation.X, heroLocation.Y - HEROSPEED);
                LocationControl(newLocation);
            }

            if (keyPressed.IsKeyDown(Keys.Down))
            {
                AnimatedSprite = AnimatedSpriteDown;
                lastDirection = "down";
                Vector2 newLocation = new Vector2(heroLocation.X, heroLocation.Y + HEROSPEED);
                LocationControl(newLocation);
            }


            if (lastDirection == "right" && Keyboard.GetState().IsKeyUp(Keys.Right))
            {
                AnimatedSprite = AnimatedSpriteStandingRight;
            }
            if (lastDirection == "left" && Keyboard.GetState().IsKeyUp(Keys.Left))
            {
                AnimatedSprite = AnimatedSpriteStandingLeft;
            }
            if (lastDirection == "down" && Keyboard.GetState().IsKeyUp(Keys.Down))
            {
                AnimatedSprite = AnimatedSpriteStandingDown;
            }
            if (lastDirection == "up" && Keyboard.GetState().IsKeyUp(Keys.Up))
            {
                AnimatedSprite = AnimatedSpriteStandingUp;
            }

            //Add your update logic here
            AnimatedSprite.Update();
        }

        private bool CollisionControler(List<Rectangle> mapObjects, Rectangle heroBounds)
        {
            bool haveCollision = false;
            foreach (var obj in mapObjects)
            {
                if (obj.Intersects(heroBounds))
                {
                    haveCollision = true;
                    break;
                }
            }
            return haveCollision;
        }

        public Vector2 GetCenterPlayer()
        {
            float x = heroLocation.X + heroBoundaries.Width / 2;
            float y = heroLocation.Y + heroBoundaries.Height / 2;
            return new Vector2(x, y);
        }
    }
}
