using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace TowerDefenseGame.UI
{
    public class GameUI
    {
        private Texture2D backgroundTexture;
        private SpriteFont font;
        private Vector2 scorePosition;
        private Vector2 speedPosition;

        public GameUI()
        {
            backgroundTexture = GameContent.Load<Texture2D>("Textures/GameUI");
            font = GameContent.Load<SpriteFont>("Fonts/Default");
            scorePosition = new Vector2(10, 10);
            speedPosition = new Vector2(10, 50);
        }

        public void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                SpeedManager.FastForward();
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(backgroundTexture, Vector2.Zero, Color.White);
            spriteBatch.DrawString(font, $"Score: {GameManager.Score}", scorePosition, Color.White);
            spriteBatch.DrawString(font, $"Speed: {SpeedManager.CurrentSpeed}", speedPosition, Color.White);
        }
    }
}