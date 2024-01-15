```csharp
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
        EnemyAI enemyAI;
        GameMap gameMap;
        List<Tower> towers;
        Minion minion;
        SpawnSystem spawnSystem;
        UpgradeSystem upgradeSystem;
        SpeedControl speedControl;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            player = new Player();
            enemyAI = new EnemyAI(this, player, gameMap, speedControl);
            gameMap = new GameMap(this, player, enemyAI);
            towers = new List<Tower>();
            minion = new Minion();
            spawnSystem = new SpawnSystem(this, player, enemyAI, towers);
            upgradeSystem = new UpgradeSystem(this, player, towers[0], minion);
            speedControl = new SpeedControl(this);
        }

        protected override void Initialize()
        {
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

            gameMap.Update(gameTime);
            player.Update(gameTime);
            enemyAI.Update(gameTime);
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
```