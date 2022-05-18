using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGameTest
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D laptoptexture;
        Texture2D binotexture;
        Texture2D desktexture;
        Texture2D CoCtexture;
        Texture2D classtexture;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            this.Window.Title = "Mr Aldworths class";
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 500;
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            binotexture = Content.Load<Texture2D>("Binoculars");
            laptoptexture = Content.Load<Texture2D>("Laptop-computer");
            desktexture = Content.Load<Texture2D>("desk2");
            CoCtexture = Content.Load<Texture2D>("phone");
            classtexture = Content.Load<Texture2D>("classFR");
            // TODO: use this.Content to load your game content here



        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(classtexture, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(binotexture, new Vector2(50, 50), Color.White);
            _spriteBatch.Draw(CoCtexture, new Vector2(300, 300), Color.White);
            _spriteBatch.Draw(desktexture, new Vector2(200, 150), Color.White);
            _spriteBatch.Draw(laptoptexture, new Vector2(225, 70), Color.Silver);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
