using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TowerDefense.Entities
{
    public class Tower
    {
        public Vector2 Position { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public Texture2D Texture { get; set; }
        public bool IsUpgraded { get; set; }

        public Tower(Vector2 position, Texture2D texture)
        {
            Position = position;
            Health = 100;
            Attack = 10;
            Texture = texture;
            IsUpgraded = false;
        }

        public void Defend(int damage)
        {
            Health -= damage;
            if (Health < 0)
            {
                Health = 0;
            }
        }

        public void Upgrade()
        {
            Health += 50;
            Attack += 5;
            IsUpgraded = true;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, Color.White);
        }
    }
}