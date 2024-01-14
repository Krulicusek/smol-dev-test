using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Entities
{
    public class Lane
    {
        public Vector2 Position { get; set; }
        public Texture2D Texture { get; set; }
        public bool IsOccupied { get; set; }

        public Lane(Vector2 position, Texture2D texture)
        {
            Position = position;
            Texture = texture;
            IsOccupied = false;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, Color.White);
        }

        public void Occupy()
        {
            IsOccupied = true;
        }

        public void Free()
        {
            IsOccupied = false;
        }
    }
}