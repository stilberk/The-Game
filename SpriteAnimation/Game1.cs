﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpriteAnimation
{
    using Microsoft.Xna.Framework.Audio;
    using Microsoft.Xna.Framework.Media;
    using System.Collections.Generic;

    /// <summary>
    ///     This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        private const int screenHeight = 1024, screenWidth = 1024;

        Texture2D bgrImage;
        private MenuButton buttonPlay;
        private MenuButton buttonQuit;
        private MenuButton buttonResume;
        GameState currentGameState = GameState.MainMenu;
        public GraphicsDeviceManager Graphics;
        private Player hero;
        private KnoledgeBook kBook;

        private MapBoundaries map;

        // sounds
        private Song backgroundMusic;
        private Song startMelody;
        private SoundEffect burpSound;

        // string Time/Score
        private SpriteFont messageFont;
        private int timer;
        private int score;
        private string messageString;
        private Vector2 messagePos;

        private List<Rectangle> mapObjects;
        //Create a Rectangle that will define the limits for the main game screen
        Rectangle mainFrame;
        Texture2D menuBackground;
        Texture2D playBtnTexture;

        public Vector2 position1;
        Texture2D quitBtnTexture;
        Texture2D resumeBtnTexture;
        SpriteBatch spriteBatch;

        public Game1()
        {
            Graphics = new GraphicsDeviceManager(this);
            Graphics.PreferredBackBufferWidth = screenWidth;
            Graphics.PreferredBackBufferHeight = screenHeight;
            Graphics.ApplyChanges();
            Content.RootDirectory = "Content";
            TargetElapsedTime = new TimeSpan(0, 0, 0, 0, 99); // 33ms = 30fps
            Window.AllowUserResizing = false;
            Window.AllowAltF4 = true;
            Window.Position = Point.Zero;
            Window.Title = "Team Feynman";
            position1 = new Vector2(0, 0);
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

            Texture2D rightTexture = Content.Load<Texture2D>("RIGHT");
            Texture2D upTexture = Content.Load<Texture2D>("UP");
            Texture2D downTexture = Content.Load<Texture2D>("DOWN");
            Texture2D standingRight = Content.Load<Texture2D>("STANDINGRIGHT");
            Texture2D standingLeft = Content.Load<Texture2D>("STANDINGLEFT");
            Texture2D standingDown = Content.Load<Texture2D>("STANDINGDOWN");
            Texture2D standingUp = Content.Load<Texture2D>("STANDINGUP");
            menuBackground = Content.Load<Texture2D>("BACKGROUND");

            playBtnTexture = Content.Load<Texture2D>("playBtn");
            quitBtnTexture = Content.Load<Texture2D>("quitBtn");
            resumeBtnTexture = Content.Load<Texture2D>("resumeBtn");

            buttonPlay = new MenuButton(playBtnTexture, Graphics.GraphicsDevice);
            buttonQuit = new MenuButton(quitBtnTexture, Graphics.GraphicsDevice);
            buttonResume = new MenuButton(resumeBtnTexture, Graphics.GraphicsDevice);

            buttonPlay.setPosition(new Vector2(512 - playBtnTexture.Width / 2, 512));
            buttonQuit.setPosition(new Vector2(512 - quitBtnTexture.Width / 2, 632));
            buttonResume.setPosition(new Vector2(512 - resumeBtnTexture.Width / 2, 512));
            kBook = new KnoledgeBook(Content.Load<Texture2D>("Book1"));
            this.map = new MapBoundaries();
            this.mapObjects = new List<Rectangle>();
            //                      {
            //                          this.kBook.BookBoundaries,
            //                      };
            mapObjects.AddRange(this.map.MapObjects);

            hero = new Player(standingRight, heroTexture, rightTexture, upTexture,
                downTexture, standingLeft, standingDown, standingUp, this.mapObjects);

            // load music
            startMelody = Content.Load<Song>("Sounds\\BoxCat_Games_-_24_-_Tricks");
            MediaPlayer.Play(startMelody);
            MediaPlayer.IsRepeating = true;
            backgroundMusic = Content.Load<Song>("Sounds\\Inspiration");
            burpSound = Content.Load<SoundEffect>("Sounds\\BurbSound");

            //load score/time string
            messageFont = Content.Load<SpriteFont>("messageScoreTime");
            messagePos = new Vector2(600, 30);
        }

        /// <summary>
        ///     UnloadContent will be called once per game and is the place to unload
        ///     game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        

        public int GetDistanceFrom(KnoledgeBook book, Player hero)
        {
            Vector2 centerBook = book.GetCenterBook();
            Vector2 centerPlayer = hero.GetCenterPlayer();
            float dx = centerBook.X - centerPlayer.X;
            float dy = centerBook.Y - centerPlayer.Y;

            return (int) Math.Sqrt((dx * dx) + (dy * dy));
        }

        /// <summary>
        ///     Allows the game to run logic such as updating the world,
        ///     checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            MouseState mouse = Mouse.GetState();

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed &&
                currentGameState != GameState.MainMenu ||
                Keyboard.GetState().IsKeyDown(Keys.Escape) && currentGameState != GameState.MainMenu)
                currentGameState = GameState.Options;


            switch (currentGameState)
            {
                case GameState.MainMenu:
                    if (buttonPlay.isClicked)
                    {
                        currentGameState = GameState.Playing;
                        MediaPlayer.Stop();
                        MediaPlayer.Play(backgroundMusic);
                        MediaPlayer.IsRepeating = true;
                        timer = 600;
                        score = 0;
                        messageString = $"Time: {timer} Score: {score}";
                    }
                    if (buttonQuit.isClicked)
                    {
                        Exit();
                    }
                    buttonPlay.Update(mouse);
                    buttonQuit.Update(mouse);
                    break;

                case GameState.Playing:
                    
                    hero.KeyListener();
                    break;

                case GameState.Options:

                    if (buttonResume.isClicked)
                    {
                        currentGameState = GameState.Playing;
                    }
                    if (buttonQuit.isClicked)
                    {
                        Exit();
                    }
                    buttonResume.Update(mouse);
                    buttonQuit.Update(mouse);
                    break;
            }

                kBook.location = GetNewBookPositon();
                timer --;
                int secsLeft = timer / 30;
                messageString = $"Time: {secsLeft} Score: {score}";

            if (timer == 0)
            {
                currentGameState = GameState.Options;

                timer = 600;
                score = 0;
            }

            base.Update(gameTime);
        }

        private Vector2 GetNewBookPositon ()
        {
            if (GetDistanceFrom(kBook, hero) < 50)
            {
                burpSound.Play(1.0f, 0.0f, 0.0f);
                score += 100;
                kBook.location = kBook.RandamPlace();
                int num = 0;
                while (num < mapObjects.Count)
                {
                    if (mapObjects[num].Contains(kBook.location))
                    {
                        kBook.location = kBook.RandamPlace();
                        num = 0;
                        continue;
                    }
                    num++;
                }
            }
            return kBook.location;
        }
        /// <summary>
        ///     This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            //Draw limits of the screen

            switch (currentGameState)
            {
                case GameState.MainMenu:
                    spriteBatch.Draw(menuBackground, new Rectangle(0, 0, screenWidth, screenHeight), Color.White);
                    buttonPlay.Draw(spriteBatch);
                    buttonQuit.Draw(spriteBatch);
                    break;

                case GameState.Playing:
                    spriteBatch.Draw(bgrImage, position1, Color.White);
                    kBook.Draw(spriteBatch);
                    hero.AnimatedSprite.Draw(spriteBatch, hero.HeroLocation);
                    spriteBatch.DrawString(messageFont, messageString, messagePos, Color.DarkRed);
                    //Here we draw black boxes ontop of our objects to let us see how exactly we colide
                    //Coment the methods below to take off the black boxes
                    //DrawRectangle(this.hero.HeroBoundaries, Color.Black);
                    //DrawRectangle(this.kBook.BookBoundaries, Color.Black);
                    //DrawRectangle(new Rectangle(0, 0, 290, 143), Color.Black);
                    //DrawRectangle(new Rectangle(330, 305, 100, 75), Color.Black);
                    //DrawRectangle(new Rectangle(555, 595, 100, 75), Color.Black);
                    //DrawRectangle(new Rectangle(355, 0, 620, 145), Color.Black);
                    //------------------------------------------------------------
                    break;

                case GameState.Options:
                    spriteBatch.Draw(menuBackground, new Rectangle(0, 0, screenWidth, screenHeight), Color.White);
                    buttonResume.Draw(spriteBatch);
                    buttonQuit.Draw(spriteBatch);
                    break;
            }

            // draw string Time/Score
            spriteBatch.End();

            base.Draw(gameTime);
        }
        private void DrawRectangle(Rectangle coords, Color color)
        {
            var rect = new Texture2D(GraphicsDevice, 1, 1);
            rect.SetData(new[] { color });
            spriteBatch.Draw(rect, coords, color);
        }
        enum GameState
        {
            MainMenu,
            Options,
            Playing
        }

    }
}