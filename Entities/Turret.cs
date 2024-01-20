using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;
using System;

namespace TowerDefense.Entities
{
    public class Turret
    {
        public Vector2 Position { get; set; }
        public Texture2D Texture { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public SoundEffect TurretFireSound { get; set; }

        private float fireRate;
        private float fireTimer;

        public Turret(Vector2 position, Texture2D texture, SoundEffect turretFireSound)
        {
            Position = position;
            Texture = texture;
            TurretFireSound = turretFireSound;
            Health = 100;
            Damage = 10;
            fireRate = 1.0f;
            fireTimer = 0.0f;
        }

        public void Update(GameTime gameTime)
        {
            fireTimer += (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (fireTimer >= fireRate)
            {
                Fire();
                fireTimer = 0.0f;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, Color.White);
        }

        private void Fire()
        {
            TurretFireSound.Play();
            // Logic for firing at enemies goes here
        }

        public void Upgrade()
        {
            Health += 50;
            Damage += 5;
            fireRate -= 0.1f;
        }
    }
}