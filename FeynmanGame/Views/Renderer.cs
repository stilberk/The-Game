using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeynmanGame.Views
{
    using Models;
    public class Renderer
    {
        private SpriteBatch spriteBatch;
        private ContentManager Content;
        private Player Hero;
        private Stop stop;
        Texture2D stopTexture;
        private Vector2 backgorunPossition;
        private Texture2D bgrImage;
        private AnimatedSprite animatedSprite;
        private AnimatedSprite animatedSpriteDown;
        private AnimatedSprite animatedSpriteLeft;
        private AnimatedSprite animatedSpriteRight;
        private AnimatedSprite animatedSpriteStandingDown;
        private AnimatedSprite animatedSpriteStandingLeft;
        private AnimatedSprite animatedSpriteStandingRight;
        private AnimatedSprite animatedSpriteStandingUp;
        private AnimatedSprite animatedSpriteUp;
        private StatusBar statusbar;
        private SpriteFont messageFont;

        public Renderer(SpriteBatch spriteBatch, ContentManager contentManager,Player hero)
        {
            this.spriteBatch = spriteBatch;
            this.Content = contentManager;
            backgorunPossition = new Vector2(0, 0);
            this.Hero = hero;
            this.stop = new Stop();
            this.stopTexture = Content.Load<Texture2D>("stop");
            Texture2D heroTexture = Content.Load<Texture2D>("LEFT");
            Texture2D rightTexture = Content.Load<Texture2D>("RIGHT");
            Texture2D upTexture = Content.Load<Texture2D>("UP");
            Texture2D downTexture = Content.Load<Texture2D>("DOWN");
            Texture2D standingRight = Content.Load<Texture2D>("STANDINGRIGHT");
            Texture2D standingLeft = Content.Load<Texture2D>("STANDINGLEFT");
            Texture2D standingDown = Content.Load<Texture2D>("STANDINGDOWN");
            Texture2D standingUp = Content.Load<Texture2D>("STANDINGUP");
            animatedSprite = new AnimatedSprite(standingRight, 1, 9);
            animatedSpriteLeft = new AnimatedSprite(heroTexture, 1, 9);
            animatedSpriteRight = new AnimatedSprite(rightTexture, 1, 9);
            animatedSpriteUp = new AnimatedSprite(upTexture, 1, 9);
            animatedSpriteDown = new AnimatedSprite(downTexture, 1, 9);
            animatedSpriteStandingLeft = new AnimatedSprite(standingLeft, 1, 1);
            animatedSpriteStandingRight = new AnimatedSprite(standingRight, 1, 1);
            animatedSpriteStandingDown = new AnimatedSprite(standingDown, 1, 1);
            animatedSpriteStandingUp = new AnimatedSprite(standingUp, 1, 1);

            messageFont = Content.Load<SpriteFont>("MessagesFont");
            statusbar = new StatusBar(messageFont);
        }

        public AnimatedSprite AnimatedSprite
        {
            get
            {
                return this.animatedSprite;
            }
            set
            {
                this.animatedSprite = value;
            }
        }

        public AnimatedSprite AnimatedSpriteDown
        {
            get
            {
                return animatedSpriteDown;
            }

            set
            {
                animatedSpriteDown = value;
            }
        }

        public AnimatedSprite AnimatedSpriteLeft
        {
            get
            {
                return animatedSpriteLeft;
            }

            set
            {
                animatedSpriteLeft = value;
            }
        }

        public AnimatedSprite AnimatedSpriteRight
        {
            get
            {
                return animatedSpriteRight;
            }

            set
            {
                animatedSpriteRight = value;
            }
        }

        public AnimatedSprite AnimatedSpriteStandingDown
        {
            get
            {
                return animatedSpriteStandingDown;
            }

            set
            {
                animatedSpriteStandingDown = value;
            }
        }

        public AnimatedSprite AnimatedSpriteStandingLeft
        {
            get
            {
                return animatedSpriteStandingLeft;
            }

            set
            {
                animatedSpriteStandingLeft = value;
            }
        }

        public AnimatedSprite AnimatedSpriteStandingRight
        {
            get
            {
                return animatedSpriteStandingRight;
            }

            set
            {
                animatedSpriteStandingRight = value;
            }
        }

        public AnimatedSprite AnimatedSpriteStandingUp
        {
            get
            {
                return animatedSpriteStandingUp;
            }

            set
            {
                animatedSpriteStandingUp = value;
            }
        }

        public AnimatedSprite AnimatedSpriteUp
        {
            get
            {
                return animatedSpriteUp;
            }

            set
            {
                animatedSpriteUp = value;
            }
        }

        public void Draw()
        {
            bgrImage = Content.Load<Texture2D>("Desert");
            spriteBatch.Draw(bgrImage, backgorunPossition, Color.White);
            spriteBatch.Draw(stopTexture, stop.Boundaries, Color.White);
            spriteBatch.DrawString(statusbar.MessageFont, statusbar.MessageString, statusbar.МessagePos, statusbar.Color);
            PlayerDraw();
        }

        public void PlayerDraw()
        {
            animatedSprite.Draw(spriteBatch, Hero.HeroLocation);
        }

    }
}
