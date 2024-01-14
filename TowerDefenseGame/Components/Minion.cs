```csharp
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TowerDefenseGame.Components
{
    public class Minion
    {
        private Game1 _game;
        private Texture2D _texture;
        private Vector2 _position;
        private float _speed;

        public Minion(Game1 game)
        {
            _game = game;
            _speed = 1.0f;
        }

        public void LoadContent()
        {
            _texture = _game.Content.Load<Texture2D>("minion");
        }

        public void Update(GameTime gameTime)
        {
            _position.X += _speed;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, _position, Color.White);
        }
    }
}
```