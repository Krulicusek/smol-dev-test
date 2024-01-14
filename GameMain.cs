using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TowerDefenseGame
{
    public class GameMain : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        GameManager gameManager;
        UpgradeManager upgradeManager;
        SpawnManager spawnManager;
        AIManager aiManager;
        SpeedManager speedManager;

        GameUI gameUI;
        UpgradeMenu upgradeMenu;
        SpeedMenu speedMenu;

        public GameMain()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            gameManager = new GameManager();
            upgradeManager = new UpgradeManager();
            spawnManager = new SpawnManager();
            aiManager = new AIManager();
            speedManager = new SpeedManager();

            gameUI = new GameUI();
            upgradeMenu = new UpgradeMenu();
            speedMenu = new SpeedMenu();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            gameManager.LoadContent(Content);
            upgradeManager.LoadContent(Content);
            spawnManager.LoadContent(Content);
            aiManager.LoadContent(Content);
            speedManager.LoadContent(Content);

            gameUI.LoadContent(Content);
            upgradeMenu.LoadContent(Content);
            speedMenu.LoadContent(Content);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            gameManager.Update(gameTime);
            upgradeManager.Update(gameTime);
            spawnManager.Update(gameTime);
            aiManager.Update(gameTime);
            speedManager.Update(gameTime);

            gameUI.Update(gameTime);
            upgradeMenu.Update(gameTime);
            speedMenu.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            gameManager.Draw(gameTime, spriteBatch);
            upgradeManager.Draw(gameTime, spriteBatch);
            spawnManager.Draw(gameTime, spriteBatch);
            aiManager.Draw(gameTime, spriteBatch);
            speedManager.Draw(gameTime, spriteBatch);

            gameUI.Draw(gameTime, spriteBatch);
            upgradeMenu.Draw(gameTime, spriteBatch);
            speedMenu.Draw(gameTime, spriteBatch);

            base.Draw(gameTime);
        }
    }
}