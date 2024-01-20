using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;

namespace TowerDefenseGame.Entities
{
    public class PowerUp
    {
        public Vector2 Position { get; set; }
        public Texture2D Texture { get; private set; }
        public bool IsActive { get; set; }
        private SoundEffect powerUpSound;

        public PowerUp(Vector2 position)
        {
            Position = position;
            IsActive = true;
        }

        public void LoadContent(ContentManager content)
        {
            Texture = content.Load<Texture2D>("Content/Textures/PowerUp.png");
            powerUpSound = content.Load<SoundEffect>("Content/Sounds/PowerUp.wav");
        }

        public void Update(GameTime gameTime)
        {
            // PowerUp logic goes here
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (IsActive)
            {
                spriteBatch.Draw(Texture, Position, Color.White);
            }
        }

        public void ApplyPowerUp(Player player)
        {
            if (IsActive)
            {
                // Apply power-up effect to player
                player.PowerUp();
                powerUpSound.Play();
                IsActive = false;
            }
        }
    }
}