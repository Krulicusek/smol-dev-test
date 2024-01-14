using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Entities
{
    public class Base
    {
        public Vector2 Position { get; set; }
        public int Health { get; set; }
        public Texture2D Texture { get; set; }

        public Base(Vector2 position, Texture2D texture)
        {
            Position = position;
            Health = 1000; // Initial health of the base
            Texture = texture;
        }

        public void Defend(int damage)
        {
            Health -= damage;
            if (Health < 0)
            {
                Health = 0;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, Color.White);
        }
    }
}