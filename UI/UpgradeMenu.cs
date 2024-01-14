using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace TowerDefenseGame.UI
{
    public class UpgradeMenu
    {
        private Texture2D upgradeMenuTexture;
        private Vector2 position;
        private bool isVisible;

        public UpgradeMenu()
        {
            this.position = new Vector2(100, 100);
            this.isVisible = false;
        }

        public void LoadContent(ContentManager content)
        {
            this.upgradeMenuTexture = content.Load<Texture2D>("Textures/UpgradeMenu");
        }

        public void Show()
        {
            this.isVisible = true;
        }

        public void Hide()
        {
            this.isVisible = false;
        }

        public void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.U))
            {
                this.isVisible = !this.isVisible;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (this.isVisible)
            {
                spriteBatch.Draw(this.upgradeMenuTexture, this.position, Color.White);
            }
        }
    }
}