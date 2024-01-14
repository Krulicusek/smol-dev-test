using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TowerDefenseGame.Entities
{
    public class AI
    {
        public Vector2 Position { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public Texture2D Texture { get; set; }

        public AI(Vector2 position, Texture2D texture)
        {
            Position = position;
            Health = 100;
            Attack = 10;
            Defense = 5;
            Texture = texture;
        }

        public void Move(Vector2 newPosition)
        {
            Position = newPosition;
        }

        public void AttackBase(Base playerBase)
        {
            playerBase.Health -= Attack - playerBase.Defense;
        }

        public void Defend(int damage)
        {
            Health -= damage - Defense;
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