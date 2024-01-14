using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TowerDefenseGame.UI
{
    public class SpeedMenu
    {
        private Texture2D speedMenuTexture;
        private Vector2 position;
        private bool isVisible;
        private float currentSpeed;

        public SpeedMenu()
        {
            this.position = new Vector2(10, 10); // arbitrary position for now
            this.isVisible = false;
            this.currentSpeed = 1.0f; // normal speed
        }

        public void LoadContent(ContentManager content)
        {
            this.speedMenuTexture = content.Load<Texture2D>("Textures/SpeedMenu");
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
            if (!this.isVisible)
                return;

            if (Keyboard.GetState().IsKeyDown(Keys.F))
            {
                this.currentSpeed *= 2.0f; // double the speed
                if (this.currentSpeed > 4.0f) // limit the maximum speed
                    this.currentSpeed = 4.0f;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                this.currentSpeed /= 2.0f; // halve the speed
                if (this.currentSpeed < 1.0f) // limit the minimum speed
                    this.currentSpeed = 1.0f;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (!this.isVisible)
                return;

            spriteBatch.Draw(this.speedMenuTexture, this.position, Color.White);
            spriteBatch.DrawString(GameMain.font, "Speed: " + this.currentSpeed, this.position + new Vector2(10, 10), Color.Black);
        }
    }
}