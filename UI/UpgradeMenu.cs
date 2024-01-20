using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace TowerDefenseGame.UI
{
    public class UpgradeMenu
    {
        private Player player;
        private SpriteBatch spriteBatch;
        private SpriteFont font;
        private Texture2D upgradeButtonTexture;
        private Vector2 upgradeButtonPosition;

        public UpgradeMenu(Player player, SpriteBatch spriteBatch, SpriteFont font, Texture2D upgradeButtonTexture)
        {
            this.player = player;
            this.spriteBatch = spriteBatch;
            this.font = font;
            this.upgradeButtonTexture = upgradeButtonTexture;
            this.upgradeButtonPosition = new Vector2(100, 100); // Arbitrary position for now
        }

        public void Update(GameTime gameTime)
        {
            if (Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                var mousePosition = new Vector2(Mouse.GetState().X, Mouse.GetState().Y);
                if (new Rectangle(upgradeButtonPosition.ToPoint(), new Point(upgradeButtonTexture.Width, upgradeButtonTexture.Height)).Contains(mousePosition))
                {
                    Upgrade();
                }
            }
        }

        public void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(upgradeButtonTexture, upgradeButtonPosition, Color.White);
            spriteBatch.DrawString(font, $"Currency: {player.Currency}", new Vector2(10, 10), Color.White);
            spriteBatch.End();
        }

        private void Upgrade()
        {
            if (player.Currency >= 100) // Arbitrary cost for now
            {
                player.Upgrade();
                player.Currency -= 100;
            }
        }
    }
}