using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace TowerDefenseGame
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Player player;
        Map map;
        GameManager gameManager;
        EnemyManager enemyManager;
        TurretManager turretManager;
        PlayerManager playerManager;
        PowerUpManager powerUpManager;
        EventManager eventManager;
        Menu menu;
        HUD hud;
        UpgradeMenu upgradeMenu;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            base.Initialize();
            player = new Player();
            map = new Map();
            gameManager = new GameManager();
            enemyManager = new EnemyManager();
            turretManager = new TurretManager();
            playerManager = new PlayerManager();
            powerUpManager = new PowerUpManager();
            eventManager = new EventManager();
            menu = new Menu();
            hud = new HUD();
            upgradeMenu = new UpgradeMenu();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            player.LoadContent(Content);
            map.LoadContent(Content);
            gameManager.LoadContent(Content);
            enemyManager.LoadContent(Content);
            turretManager.LoadContent(Content);
            playerManager.LoadContent(Content);
            powerUpManager.LoadContent(Content);
            eventManager.LoadContent(Content);
            menu.LoadContent(Content);
            hud.LoadContent(Content);
            upgradeMenu.LoadContent(Content);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            player.Update(gameTime);
            map.Update(gameTime);
            gameManager.Update(gameTime);
            enemyManager.Update(gameTime);
            turretManager.Update(gameTime);
            playerManager.Update(gameTime);
            powerUpManager.Update(gameTime);
            eventManager.Update(gameTime);
            menu.Update(gameTime);
            hud.Update(gameTime);
            upgradeMenu.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            player.Draw(spriteBatch);
            map.Draw(spriteBatch);
            gameManager.Draw(spriteBatch);
            enemyManager.Draw(spriteBatch);
            turretManager.Draw(spriteBatch);
            playerManager.Draw(spriteBatch);
            powerUpManager.Draw(spriteBatch);
            eventManager.Draw(spriteBatch);
            menu.Draw(spriteBatch);
            hud.Draw(spriteBatch);
            upgradeMenu.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}