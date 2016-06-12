using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpriteAnimation
{
    /// <summary>
    ///     This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        const int HEROSPEED = 15;
        const int BGRSPEED = 35;
        readonly GraphicsDeviceManager graphics;

        private Player hero;
        private KnoledgeBook kBook;

        Texture2D bgrImage;
        //Create a Rectangle that will define the limits for the main game screen
        Rectangle mainFrame;

        public Vector2 heroLocation = new Vector2(290, 0);
        private string lastDirection = "down";
        public Vector2 position1, position2;
        SpriteBatch spriteBatch;
        


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = 1024;
            graphics.PreferredBackBufferHeight = 1024;
            graphics.ApplyChanges();
            Content.RootDirectory = "Content";
            TargetElapsedTime = new TimeSpan(0, 0, 0, 0, 99); // 33ms = 30fps
            Window.AllowUserResizing = false;
            Window.AllowAltF4 = true;
            Window.Title = "Team Feynman";
            position1 = new Vector2(0, 0);
            //position2 = new Vector2(3263, 2330);
        }

        /// <summary>
        ///     Allows the game to perform any initialization it needs to before starting to run.
        ///     This is where it can query for any required services and load any non-graphic
        ///     related content.  Calling base.Initialize will enumerate through any components
        ///     and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
            IsMouseVisible = true;
        }

        /// <summary>
        ///     LoadContent will be called once per game and is the place to load
        ///     all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            //use this.Content to load your game content here
            Texture2D heroTexture = Content.Load<Texture2D>("LEFT");
            bgrImage = Content.Load<Texture2D>("Desert");
            //Set the rectangle parameters.
            //mainFrame = new Rectangle(0, 0, 3200, 1600);
            Texture2D rightTexture = Content.Load<Texture2D>("RIGHT");
            Texture2D upTexture = Content.Load<Texture2D>("UP");
            Texture2D downTexture = Content.Load<Texture2D>("DOWN");
            Texture2D standingRight = Content.Load<Texture2D>("STANDINGRIGHT");
            Texture2D standingLeft = Content.Load<Texture2D>("STANDINGLEFT");
            Texture2D standingDown = Content.Load<Texture2D>("STANDINGDOWN");
            Texture2D standingUp = Content.Load<Texture2D>("STANDINGUP");

            hero = new Player(standingRight, heroTexture, rightTexture, upTexture, 
                downTexture, standingLeft, standingDown, standingUp);
            kBook = new KnoledgeBook(Content.Load<Texture2D>("Book1"));
        }

        /// <summary>
        ///     UnloadContent will be called once per game and is the place to unload
        ///     game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        ///     Allows the game to run logic such as updating the world,
        ///     checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            var keyPressed = Keyboard.GetState();

            if (keyPressed.IsKeyDown(Keys.Right))
            {
                hero.AnimatedSprite = hero.AnimatedSpriteRight;
                lastDirection = "right";
                heroLocation.X += HEROSPEED;
            }

            if (keyPressed.IsKeyDown(Keys.Left))
            {
                hero.AnimatedSprite = hero.AnimatedSpriteLeft;
                lastDirection = "left";
                heroLocation.X -= HEROSPEED;
            }

            if (keyPressed.IsKeyDown(Keys.Up))
            {
                hero.AnimatedSprite = hero.AnimatedSpriteUp;
                lastDirection = "up";
                heroLocation.Y -= HEROSPEED;
            }

            if (keyPressed.IsKeyDown(Keys.Down))
            {
                hero.AnimatedSprite = hero.AnimatedSpriteDown;
                lastDirection = "down";
                heroLocation.Y += HEROSPEED;
            }


            if (lastDirection == "right" && Keyboard.GetState().IsKeyUp(Keys.Right))
            {
                hero.AnimatedSprite = hero.AnimatedSpriteStandingRight;
            }
            if (lastDirection == "left" && Keyboard.GetState().IsKeyUp(Keys.Left))
            {
                hero.AnimatedSprite = hero.AnimatedSpriteStandingLeft;
            }
            if (lastDirection == "down" && Keyboard.GetState().IsKeyUp(Keys.Down))
            {
                hero.AnimatedSprite = hero.AnimatedSpriteStandingDown;
            }
            if (lastDirection == "up" && Keyboard.GetState().IsKeyUp(Keys.Up))
            {
                hero.AnimatedSprite = hero.AnimatedSpriteStandingUp;
            }


            //Add your update logic here
            hero.AnimatedSprite.Update();

            //Limits of screen - not implemented
            //int maxX = 3200 - 20;
            //int maxY = 1600 - 20;

            //if (heroLocation.X >= maxX || heroLocation.X < 20)
            //{
            //    heroLocation.X -= 20;
            //}

            //if (heroLocation.Y >= maxY || heroLocation.Y < 20)
            //{
            //    heroLocation.Y -= 20;
            //}

            if (heroLocation.X >= 700)
            {
                position1.X -= BGRSPEED;
                position2.X -= BGRSPEED;
                heroLocation.X = 699;
            }

            if (heroLocation.X <= 20)
            {
                position1.X += BGRSPEED;
                position2.X += BGRSPEED;
                heroLocation.X = 21;
            }

            if (heroLocation.Y <= 20)
            {
                position1.Y += BGRSPEED;
                position2.Y += BGRSPEED;
                heroLocation.Y = 21;
            }

            if (heroLocation.Y >= 500)
            {
                position1.Y -= BGRSPEED;
                position2.Y -= BGRSPEED;
                heroLocation.Y = 499;
            }

            base.Update(gameTime);
        }

        /// <summary>
        ///     This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);


            spriteBatch.Begin();
            // spriteBatch.Draw(bgrImgage, Vector2.Zero);

            //Draw limits of the screen
            spriteBatch.Draw(bgrImage, position1, Color.White);
            //spriteBatch.Draw(bgrImage, mainFrame, Color.White);

            // spriteBatch.Draw(bgrImgage, position2, Color.White);
            spriteBatch.End();

            // TODO: Add your drawing code here

            kBook.Draw(spriteBatch);

            hero.AnimatedSprite.Draw(spriteBatch, heroLocation);

            base.Draw(gameTime);
        }
    }
}