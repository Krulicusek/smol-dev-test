```csharp
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace TowerDefenseGame.Managers
{
    public class GameManager
    {
        public Player Player { get; private set; }
        public Map Map { get; private set; }
        public List<Turret> Turrets { get; private set; }
        public List<Enemy> Enemies { get; private set; }
        public int Difficulty { get; private set; }

        private EnemyManager enemyManager;
        private TurretManager turretManager;
        private PlayerManager playerManager;
        private PowerUpManager powerUpManager;
        private EventManager eventManager;

        public GameManager()
        {
            Player = new Player();
            Map = new Map("map.txt");
            Turrets = new List<Turret>();
            Enemies = new List<Enemy>();
            Difficulty = 1;

            enemyManager = new EnemyManager(this);
            turretManager = new TurretManager(this);
            playerManager = new PlayerManager(this);
            powerUpManager = new PowerUpManager(this);
            eventManager = new EventManager(this);
        }

        public void Initialize()
        {
            Player.Initialize();
            Map.Initialize();
            turretManager.Initialize();
            enemyManager.Initialize();
            playerManager.Initialize();
            powerUpManager.Initialize();
            eventManager.Initialize();
        }

        public void Update(GameTime gameTime)
        {
            Player.Update(gameTime);
            Map.Update(gameTime);
            turretManager.Update(gameTime);
            enemyManager.Update(gameTime);
            playerManager.Update(gameTime);
            powerUpManager.Update(gameTime);
            eventManager.Update(gameTime);

            Difficulty = Player.Score / 1000 + 1;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Map.Draw(spriteBatch);
            foreach (var turret in Turrets)
            {
                turret.Draw(spriteBatch);
            }
            foreach (var enemy in Enemies)
            {
                enemy.Draw(spriteBatch);
            }
            Player.Draw(spriteBatch);
        }
    }
}
```