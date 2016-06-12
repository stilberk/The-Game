using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

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

        public Player(Texture2D standingRight, Texture2D heroTexture, Texture2D rightTexture, Texture2D upTexture, Texture2D downTexture, Texture2D standingLeft, Texture2D standingDown, Texture2D standingUp)
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
    }
}
