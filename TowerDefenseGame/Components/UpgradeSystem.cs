using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TowerDefenseGame.Components
{
    public class UpgradeSystem
    {
        private Game1 _game;
        private Player _player;
        private Tower _tower;
        private Minion _minion;

        public UpgradeSystem(Game1 game, Player player, Tower tower, Minion minion)
        {
            _game = game;
            _player = player;
            _tower = tower;
            _minion = minion;
        }

        public void UpgradeTower()
        {
            if (_player.Gold >= _tower.UpgradeCost)
            {
                _player.Gold -= _tower.UpgradeCost;
                _tower.Level++;
                _tower.Damage += 10;
                _tower.UpgradeCost *= 2;
            }
        }

        public void UpgradeMinion()
        {
            if (_player.Gold >= _minion.UpgradeCost)
            {
                _player.Gold -= _minion.UpgradeCost;
                _minion.Level++;
                _minion.Damage += 5;
                _minion.Health += 10;
                _minion.UpgradeCost *= 2;
            }
        }

        public void Update(GameTime gameTime)
        {
            if (_game.KeyboardState.IsKeyDown(Keys.T))
            {
                UpgradeTower();
            }

            if (_game.KeyboardState.IsKeyDown(Keys.M))
            {
                UpgradeMinion();
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(_game.Font, $"Gold: {_player.Gold}", new Vector2(10, 10), Color.Gold);
            spriteBatch.DrawString(_game.Font, $"Tower Level: {_tower.Level}", new Vector2(10, 30), Color.White);
            spriteBatch.DrawString(_game.Font, $"Minion Level: {_minion.Level}", new Vector2(10, 50), Color.White);
        }
    }
}