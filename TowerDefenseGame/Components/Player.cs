using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TowerDefenseGame.Components
{
    public class Player
    {
        public Vector2 Position { get; set; }
        public int Health { get; set; }
        public int Gold { get; set; }
        public int Score { get; set; }

        public Player()
        {
            Position = new Vector2(0, 0);
            Health = 100;
            Gold = 1000;
            Score = 0;
        }

        public void Update(GameTime gameTime)
        {
            KeyboardState state = Keyboard.GetState();

            if (state.IsKeyDown(Keys.W))
            {
                Position.Y -= 5;
            }
            if (state.IsKeyDown(Keys.S))
            {
                Position.Y += 5;
            }
            if (state.IsKeyDown(Keys.A))
            {
                Position.X -= 5;
            }
            if (state.IsKeyDown(Keys.D))
            {
                Position.X += 5;
            }
        }

        public void UpgradeTower(Tower tower)
        {
            if (Gold >= tower.UpgradeCost)
            {
                Gold -= tower.UpgradeCost;
                tower.Upgrade();
            }
        }

        public void UpgradeMinion(Minion minion)
        {
            if (Gold >= minion.UpgradeCost)
            {
                Gold -= minion.UpgradeCost;
                minion.Upgrade();
            }
        }

        public void SpawnMinion(Minion minion, SpawnSystem spawnSystem)
        {
            if (Gold >= minion.SpawnCost)
            {
                Gold -= minion.SpawnCost;
                spawnSystem.SpawnMinion(minion);
            }
        }
    }
}