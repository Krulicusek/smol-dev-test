```csharp
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TowerDefenseGame.Components
{
    public class Tower
    {
        private Game1 _game;
        private Texture2D _texture;
        private Vector2 _position;
        private int _level;

        public Tower(Game1 game)
        {
            _game = game;
            _level = 1;
        }

        public void LoadContent()
        {
            _texture = _game.Content.Load<Texture2D>("Tower");
            _position = new Vector2(_game.GraphicsDevice.Viewport.Width / 2, _game.GraphicsDevice.Viewport.Height / 2);
        }

        public void Upgrade()
        {
            _level++;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, _position, Color.White);
        }
    }
}
```