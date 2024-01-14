using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using TowerDefenseGame.Components;

namespace TowerDefenseGame
{
    public class SpawnSystem
    {
        private Game1 _game;
        private Player _player;
        private EnemyAI _enemyAI;
        private List<Tower> _towers;
        private List<Minion> _minions;
        private float _spawnTimer;
        private const float SpawnInterval = 5f; // Spawn every 5 seconds

        public SpawnSystem(Game1 game, Player player, EnemyAI enemyAI, List<Tower> towers)
        {
            _game = game;
            _player = player;
            _enemyAI = enemyAI;
            _towers = towers;
            _minions = new List<Minion>();
        }

        public void Update(GameTime gameTime)
        {
            _spawnTimer += (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (_spawnTimer >= SpawnInterval)
            {
                SpawnMinion();
                _spawnTimer = 0f;
            }

            foreach (var minion in _minions)
            {
                minion.Update(gameTime);
            }
        }

        private void SpawnMinion()
        {
            var minion = new Minion(_game, _player, _enemyAI, _towers);
            _minions.Add(minion);
        }
    }
}