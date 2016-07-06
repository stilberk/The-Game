using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeynmanGame.Controllers
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Input;
    using Views;
    using Models;

    public class UserIO
    {
        private Renderer renderer;
        private Player hero;
        private CollisionHandler ch;
        private string lastDirection = "down";

        public UserIO(Renderer painter,Player hero)
        {
            this.renderer = painter;
            this.hero = hero;
            this.ch = new CollisionHandler(hero.LocationSize);
        }

        public void KeyListener()
        {
            var keyPressed = Keyboard.GetState();

            if (keyPressed.IsKeyDown(Keys.Right))
            {
                renderer.AnimatedSprite = renderer.AnimatedSpriteRight;
                lastDirection = "right";
                Rectangle heroNewPosition = new Rectangle((int)hero.HeroLocation.X + hero.HeroSpeed,
                                                (int)hero.HeroLocation.Y,Player.Width,Player.Hight);
                bool newPosCollide = ch.CollisionControler(heroNewPosition);
                if (!newPosCollide)
                {
                    hero.HeroLocation = new Vector2(hero.HeroLocation.X + hero.HeroSpeed, hero.HeroLocation.Y);
                }
            }

            if (keyPressed.IsKeyDown(Keys.Left))
            {
                renderer.AnimatedSprite = renderer.AnimatedSpriteLeft;
                lastDirection = "left";
                Rectangle heroNewPosition = new Rectangle((int)hero.HeroLocation.X - hero.HeroSpeed,
                                (int)hero.HeroLocation.Y, Player.Width, Player.Hight);
                bool newPosCollide = ch.CollisionControler(heroNewPosition);
                if (!newPosCollide)
                {
                    hero.HeroLocation = new Vector2(hero.HeroLocation.X - hero.HeroSpeed, hero.HeroLocation.Y);
                }
            }

            if (keyPressed.IsKeyDown(Keys.Up))
            {
                renderer.AnimatedSprite = renderer.AnimatedSpriteUp;
                lastDirection = "up";
                Rectangle heroNewPosition = new Rectangle((int)hero.HeroLocation.X,
                                (int)hero.HeroLocation.Y - hero.HeroSpeed, Player.Width, Player.Hight);
                bool newPosCollide = ch.CollisionControler(heroNewPosition);
                if (!newPosCollide)
                {
                     hero.HeroLocation = new Vector2(hero.HeroLocation.X , hero.HeroLocation.Y - hero.HeroSpeed);
                }
            }

            if (keyPressed.IsKeyDown(Keys.Down))
            {
                renderer.AnimatedSprite = renderer.AnimatedSpriteDown;
                lastDirection = "down";
                Rectangle heroNewPosition = new Rectangle((int)hero.HeroLocation.X,
                                (int)hero.HeroLocation.Y + hero.HeroSpeed, Player.Width, Player.Hight);
                bool newPosCollide = ch.CollisionControler(heroNewPosition);
                if (!newPosCollide)
                {
                    hero.HeroLocation = new Vector2(hero.HeroLocation.X, hero.HeroLocation.Y + hero.HeroSpeed); ;
                }
            }


            if (lastDirection == "right" && Keyboard.GetState().IsKeyUp(Keys.Right))
            {
                renderer.AnimatedSprite = renderer.AnimatedSpriteStandingRight;
            }
            if (lastDirection == "left" && Keyboard.GetState().IsKeyUp(Keys.Left))
            {
                renderer.AnimatedSprite = renderer.AnimatedSpriteStandingLeft;
            }
            if (lastDirection == "down" && Keyboard.GetState().IsKeyUp(Keys.Down))
            {
                renderer.AnimatedSprite = renderer.AnimatedSpriteStandingDown;
            }
            if (lastDirection == "up" && Keyboard.GetState().IsKeyUp(Keys.Up))
            {
                renderer.AnimatedSprite = renderer.AnimatedSpriteStandingUp;
            }

            //Add your update logic here
            renderer.AnimatedSprite.Update();
        }
    }
}
