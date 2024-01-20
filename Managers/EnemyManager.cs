using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TowerDefense.Managers
{
    public class EnemyManager
    {
        private List<Entities.Enemy> enemies;
        private int difficulty;
        private double spawnTimer;
        private const double SpawnInterval = 2000;

        public EnemyManager()
        {
            enemies = new List<Entities.Enemy>();
            difficulty = 1;
            spawnTimer = 0;
        }

        public void Update(GameTime gameTime, Entities.Player player)
        {
            spawnTimer += gameTime.ElapsedGameTime.TotalMilliseconds;

            if (spawnTimer > SpawnInterval)
            {
                SpawnEnemy();
                spawnTimer = 0;
            }

            for (int i = 0; i < enemies.Count; i++)
            {
                var enemy = enemies[i];
                enemy.Update(gameTime);

                if (enemy.Health <= 0)
                {
                    player.Score += enemy.ScoreValue;
                    player.Currency += enemy.CurrencyValue;
                    enemies.RemoveAt(i);
                    i--;
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (var enemy in enemies)
            {
                enemy.Draw(spriteBatch);
            }
        }

        private void SpawnEnemy()
        {
            var enemy = new Entities.Enemy(difficulty);
            enemies.Add(enemy);
        }

        public void IncreaseDifficulty()
        {
            difficulty++;
        }
    }
}