using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Entities;

namespace UI
{
    public class HUD
    {
        private SpriteFont font;
        private Player player;

        public HUD(Player player, SpriteFont font)
        {
            this.player = player;
            this.font = font;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            spriteBatch.DrawString(font, $"Score: {player.Score}", new Vector2(10, 10), Color.White);
            spriteBatch.DrawString(font, $"Currency: {player.Currency}", new Vector2(10, 30), Color.White);
            spriteBatch.DrawString(font, $"Turrets: {player.Turrets.Count}/{player.MaxTurrets}", new Vector2(10, 50), Color.White);

            spriteBatch.End();
        }
    }
}