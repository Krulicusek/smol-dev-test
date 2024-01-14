using System;
using Microsoft.Xna.Framework;

namespace TowerDefenseGame.Components
{
    public class SpeedControl
    {
        private Game1 _game;
        private float _gameSpeed;

        public SpeedControl(Game1 game)
        {
            _game = game;
            _gameSpeed = 1.0f;
        }

        public void IncreaseSpeed()
        {
            _gameSpeed *= 2.0f;
            _game.TargetElapsedTime = TimeSpan.FromTicks((long)(TimeSpan.TicksPerSecond / _gameSpeed));
        }

        public void DecreaseSpeed()
        {
            _gameSpeed /= 2.0f;
            _game.TargetElapsedTime = TimeSpan.FromTicks((long)(TimeSpan.TicksPerSecond / _gameSpeed));
        }

        public void ResetSpeed()
        {
            _gameSpeed = 1.0f;
            _game.TargetElapsedTime = TimeSpan.FromTicks(TimeSpan.TicksPerSecond);
        }
    }
}