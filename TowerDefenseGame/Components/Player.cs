```csharp
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TowerDefenseGame.Components
{
    public class Player
    {
        private Game1 _game;
        private Texture2D _playerTexture;
        private Vector2 _position;

        public Player(Game1 game)
        {
            _game = game;
        }

        public void LoadContent()
        {
            _playerTexture = _game.Content.Load<Texture2D>("Player");
            _position = new Vector2(_game.GraphicsDevice.Viewport.Width / 2, _game.GraphicsDevice.Viewport.Height / 2);
        }

        public void Update(GameTime gameTime)
        {
            var keyboardState = Keyboard.GetState();

            if (keyboardState.IsKeyDown(Keys.W))
                _position.Y -= 2;
            if (keyboardState.IsKeyDown(Keys.S))
                _position.Y += 2;
            if (keyboardState.IsKeyDown(Keys.A))
                _position.X -= 2;
            if (keyboardState.IsKeyDown(Keys.D))
                _position.X += 2;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_playerTexture, _position, Color.White);
        }
    }
}
```