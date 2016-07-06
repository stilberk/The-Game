using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeynmanGame.Models
{
    using Controllers;
    public class Player 
    {
        private const int width = 35;
        private const int hight = 49;
        private const int herospeed = 15;
        private const int stratLocationX = 304;
        private const int stratLocationY = 0;
        private bool heroColide;

        private Vector2 heroLocation;
        private Rectangle newLocation;
        private Rectangle locationSize;

        public Player()
        {
            this.heroLocation = new Vector2(stratLocationX, stratLocationY);
            this.locationSize = new Rectangle((int)heroLocation.X, (int)heroLocation.Y, 35, 49);
            this.newLocation = new Rectangle();
        }
        public Rectangle LocationSize
        {
            get
            {
                return this.locationSize;
            }
            set
            {
                this.locationSize = value;
            }
        }

        public int newX { get; set; }
        public int newY { get; set; }

        public Vector2 HeroLocation
        {
            get
            {
                return heroLocation;
            }

            set
            {               
                if ((value.X < 980 && value.Y < 990) && (value.X > -26 && value.Y > 0) && !heroColide)
                {
                    heroLocation = value;
                    this.LocationSize = new Rectangle((int)value.X, (int)value.Y, 35, 49);
                }             
            }
        }

        public int HeroSpeed
        {
            get
            {
                return herospeed;
            }
        }

        public bool HeroColide
        {
            get
            {
                return heroColide;
            }

            set
            {
                heroColide = value;
            }
        }

        public Rectangle NewLocation
        {
            get
            {
                return newLocation;
            }

            set
            {
                newLocation = value;
            }
        }

        public static int Width
        {
            get
            {
                return width;
            }
        }

        public static int Hight
        {
            get
            {
                return hight;
            }
        }

        //public void Move()
        //{
        //    this.heroLocation.X += HEROSPEED * (this.heroLocation.X - newX);
        //    this.heroLocation.Y += HEROSPEED * (this.heroLocation.Y - newY);
        //}
    }
}
