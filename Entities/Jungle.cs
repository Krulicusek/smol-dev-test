using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TowerDefenseGame.Entities
{
    public class Jungle
    {
        public Vector2 Position { get; set; }
        public Texture2D Texture { get; private set; }
        public int Health { get; set; }

        public Jungle(Vector2 position, Texture2D texture)
        {
            Position = position;
            Texture = texture;
            Health = 100;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, Color.White);
        }

        public void Update(GameTime gameTime)
        {
            // Update logic for Jungle entity goes here
        }
    }
}