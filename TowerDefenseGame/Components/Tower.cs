using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TowerDefenseGame.Components;

namespace TowerDefenseGame
{
    public class Tower
    {
        public Vector2 Position { get; set; }
        public int Level { get; set; }
        public Texture2D Texture { get; private set; }

        private Game1 _game;
        private Player _player;
        private EnemyAI _enemyAI;
        private UpgradeSystem _upgradeSystem;
        private SpeedControl _speedControl;

        public Tower(Game1 game, Player player, EnemyAI enemyAI, UpgradeSystem upgradeSystem, SpeedControl speedControl)
        {
            _game = game;
            _player = player;
            _enemyAI = enemyAI;
            _upgradeSystem = upgradeSystem;
            _speedControl = speedControl;

            Texture = _game.Content.Load<Texture2D>("Images/Tower");
            Level = 1;
        }

        public void Upgrade()
        {
            if (_player.Gold >= _upgradeSystem.GetUpgradeCost(this))
            {
                _player.Gold -= _upgradeSystem.GetUpgradeCost(this);
                Level++;
            }
        }

        public void Attack()
        {
            if (_speedControl.GameSpeed != SpeedControl.Speed.FastForward)
            {
                _enemyAI.TakeDamage(Level);
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, Color.White);
        }
    }
}