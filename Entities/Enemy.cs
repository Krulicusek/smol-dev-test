using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace TowerDefense.Entities
{
    public class Enemy
    {
        public Vector2 Position { get; set; }
        public Texture2D Texture { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public bool IsAlive => Health > 0;

        public Enemy(Texture2D texture, Vector2 position, int health, int damage)
        {
            Texture = texture;
            Position = position;
            Health = health;
            Damage = damage;
        }

        public void Update(GameTime gameTime)
        {
            // Logic for enemy movement and attacking goes here
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, Color.White);
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health <= 0)
            {
                Die();
            }
        }

        private void Die()
        {
            // Logic for enemy death goes here
            // This should include playing the death sound and increasing the player's currency
        }
    }
}