using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TowerDefenseGame.Components;

namespace TowerDefenseGame
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Player player;
        EnemyAI enemyAI;
        GameMap gameMap;
        UpgradeSystem upgradeSystem;
        SpawnSystem spawnSystem;
        SpeedControl speedControl;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            player = new Player();
            enemyAI = new EnemyAI();
            gameMap = new GameMap();
            upgradeSystem = new UpgradeSystem();
            spawnSystem = new SpawnSystem();
            speedControl = new SpeedControl();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            gameMap.LoadContent(Content);
            player.LoadContent(Content);
            enemyAI.LoadContent(Content);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            player.Update(gameTime);
            enemyAI.Update(gameTime);
            gameMap.Update(gameTime);
            upgradeSystem.Update(gameTime, player);
            spawnSystem.Update(gameTime, player);
            speedControl.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            gameMap.Draw(spriteBatch);
            player.Draw(spriteBatch);
            enemyAI.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}