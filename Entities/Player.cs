using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TowerDefenseGame.Entities
{
    public class Player
    {
        public Vector2 Position { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public Texture2D PlayerTexture { get; set; }

        public Player(Texture2D texture)
        {
            PlayerTexture = texture;
            Health = 100;
            Attack = 10;
            Defense = 5;
        }

        public void Move(Vector2 newPosition)
        {
            Position = newPosition;
        }

        public void AttackEnemy(AI enemy)
        {
            enemy.Health -= Attack - enemy.Defense;
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
            spriteBatch.Draw(PlayerTexture, Position, Color.White);
        }
    }
}