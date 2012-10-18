using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Image
{

    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        //Load in your Texture2D's
        Texture2D _background;

        //Define Texture's with a Rectangle
        Rectangle _bgRect;


        //Configure Screen 
        int screenWidth;
        int screenHeight;

        //Declare Floats - Screen Paramaters 
        float windowWidth;
        float windowHeight;
        float overScan = 10.0f; //Overscan is the TV'S Render rate
        float windowMinX;
        float windowMaxX;
        float windowMinY;
        float windowMaxY;

        //Insert Debug Code Below (FPS, String for Buttons, Etc )

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            
            //BACK BUFFER 
            // -- The size of the television screen. 
            // Fall back to 1280 x 720 
            // Write Custom Function for Fall Back (Optional)
            this.graphics.PreferredBackBufferWidth = 1920;
            this.graphics.PreferredBackBufferHeight = 1080;
            this.graphics.IsFullScreen = true;
        }

        protected override void Initialize()
        {
            ConfigureScreen();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            //Load in Image
            _background = Content.Load<Texture2D>("Bg\\_background");
            _bgRect = new Rectangle(0, 0, 1920, 1080);

            //Screen Paramaters
            screenWidth = GraphicsDevice.Viewport.Width;
            screenHeight = GraphicsDevice.Viewport.Height;
        }

        private void ConfigureScreen()
        {
            //Set window width and height
            windowWidth = graphics.GraphicsDevice.Viewport.Width;
            windowHeight = graphics.GraphicsDevice.Viewport.Height;

            //Calculate the over scan margin (for Xbox 360)
            float xOverscanMargin = (windowWidth * overScan) / 100;
            float yOverscanMargin = (windowHeight * overScan) / 100;

            //Use the over scan margin to set the game's boarders
            windowMinX = xOverscanMargin;
            windowMinY = yOverscanMargin;
            windowMaxX = windowWidth - xOverscanMargin;
            windowMaxY = windowHeight - yOverscanMargin;
        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here

            spriteBatch.Begin();
            spriteBatch.Draw(_background, _bgRect, Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
