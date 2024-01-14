```csharp
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TowerDefenseGame.Components
{
    public class Minion
    {
        public Vector2 Position { get; set; }
        public float Speed { get; set; }
        public int Health { get; set; }
        public bool IsAlive { get; set; }

        private Texture2D minionTexture;
        private Game1 game;

        public Minion(Game1 game, Vector2 position)
        {
            this.game = game;
            this.Position = position;
            this.Speed = 1.0f;
            this.Health = 100;
            this.IsAlive = true;

            LoadContent();
        }

        public void LoadContent()
        {
            this.minionTexture = this.game.Content.Load<Texture2D>("Images/Minion");
        }

        public void Update(GameTime gameTime)
        {
            if (!IsAlive)
                return;

            // Move towards the enemy base
            this.Position += new Vector2(this.Speed, 0) * (float)gameTime.ElapsedGameTime.TotalSeconds;

            // Check for collision with towers or enemy base
            // TODO: Implement collision detection

            // Check if health is 0, if so, set IsAlive to false
            if (this.Health <= 0)
            {
                this.IsAlive = false;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (IsAlive)
            {
                spriteBatch.Draw(this.minionTexture, this.Position, Color.White);
            }
        }
    }
}
```