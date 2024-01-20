using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace TowerDefense.Entities
{
    public class Player
    {
        public Vector2 Position { get; set; }
        public Texture2D Texture { get; set; }
        public int Score { get; set; }
        public int Currency { get; set; }
        public int TurretLimit { get; set; }

        public Player()
        {
            Position = new Vector2(0, 0);
            Score = 0;
            Currency = 0;
            TurretLimit = 10;
        }

        public void LoadContent(ContentManager content)
        {
            Texture = content.Load<Texture2D>("Textures/Player");
        }

        public void Update(GameTime gameTime)
        {
            // Update player state
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, Color.White);
        }

        public void EarnCurrency(int amount)
        {
            Currency += amount;
        }

        public bool SpendCurrency(int amount)
        {
            if (Currency >= amount)
            {
                Currency -= amount;
                return true;
            }
            return false;
        }

        public void ApplyPowerUp(PowerUp powerUp)
        {
            // Apply power-up effects
        }
    }
}