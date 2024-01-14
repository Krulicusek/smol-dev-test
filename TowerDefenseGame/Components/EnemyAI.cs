```csharp
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TowerDefenseGame.Components
{
    public class EnemyAI
    {
        private Game1 _game;
        private Player _player;
        private GameMap _gameMap;
        private SpeedControl _speedControl;

        public EnemyAI(Game1 game, Player player, GameMap gameMap, SpeedControl speedControl)
        {
            _game = game;
            _player = player;
            _gameMap = gameMap;
            _speedControl = speedControl;
        }

        public void Update(GameTime gameTime)
        {
            // AI logic to attack player's towers and minions
            // AI logic to defend its own towers and minions
            // AI logic to upgrade its own towers and minions
            // AI logic to spawn minions
            // AI logic to adjust game speed based on game state
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            // Draw AI's towers, minions, and other game elements
        }
    }
}
```