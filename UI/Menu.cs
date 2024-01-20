using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TowerDefense.UI
{
    public class Menu
    {
        private Texture2D backgroundTexture;
        private SpriteFont menuFont;
        private SpriteBatch spriteBatch;
        private Game1 game;

        private string[] menuItems = { "Start Game", "Options", "Exit" };
        private int selectedIndex = 0;

        public Menu(Game1 game, SpriteBatch spriteBatch)
        {
            this.game = game;
            this.spriteBatch = spriteBatch;
        }

        public void LoadContent()
        {
            backgroundTexture = game.Content.Load<Texture2D>("Textures/MenuBackground");
            menuFont = game.Content.Load<SpriteFont>("Fonts/MenuFont");
        }

        public void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                selectedIndex--;
                if (selectedIndex < 0)
                    selectedIndex = menuItems.Length - 1;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                selectedIndex++;
                if (selectedIndex >= menuItems.Length)
                    selectedIndex = 0;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Enter))
            {
                switch (selectedIndex)
                {
                    case 0:
                        game.StartGame();
                        break;
                    case 1:
                        game.ShowOptions();
                        break;
                    case 2:
                        game.Exit();
                        break;
                }
            }
        }

        public void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(backgroundTexture, new Rectangle(0, 0, game.GraphicsDevice.Viewport.Width, game.GraphicsDevice.Viewport.Height), Color.White);

            for (int i = 0; i < menuItems.Length; i++)
            {
                Color color = (i == selectedIndex) ? Color.Red : Color.White;
                spriteBatch.DrawString(menuFont, menuItems[i], new Vector2(100, 100 + i * 30), color);
            }

            spriteBatch.End();
        }
    }
}