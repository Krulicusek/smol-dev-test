using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Entities;

namespace Managers
{
    public class PowerUpManager
    {
        private List<PowerUp> powerUps;
        private Random random;

        public PowerUpManager()
        {
            powerUps = new List<PowerUp>();
            random = new Random();
        }

        public void Update(GameTime gameTime)
        {
            for (int i = 0; i < powerUps.Count; i++)
            {
                powerUps[i].Update(gameTime);

                if (powerUps[i].IsExpired)
                {
                    powerUps.RemoveAt(i);
                    i--;
                }
            }

            if (random.NextDouble() < 0.01)
            {
                SpawnPowerUp();
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (var powerUp in powerUps)
            {
                powerUp.Draw(spriteBatch);
            }
        }

        private void SpawnPowerUp()
        {
            var powerUpType = (PowerUpType)random.Next(Enum.GetNames(typeof(PowerUpType)).Length);
            var position = new Vector2(random.Next(Game1.ScreenWidth), random.Next(Game1.ScreenHeight));

            powerUps.Add(new PowerUp(powerUpType, position));
        }

        public void ApplyPowerUp(Player player, PowerUp powerUp)
        {
            powerUp.Apply(player);
            powerUps.Remove(powerUp);
        }
    }
}