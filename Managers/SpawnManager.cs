using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Entities;

namespace Managers
{
    public class SpawnManager
    {
        private List<Tower> towers;
        private List<Minion> minions;
        private Player player;
        private AI ai;

        public SpawnManager(Player player, AI ai)
        {
            this.player = player;
            this.ai = ai;
            towers = new List<Tower>();
            minions = new List<Minion>();
        }

        public void Initialize()
        {
            // Initialize towers and minions
            for (int i = 0; i < 3; i++)
            {
                towers.Add(new Tower(new Vector2(i * 100, 0)));
                minions.Add(new Minion(new Vector2(i * 100, 100)));
            }
        }

        public void Update(GameTime gameTime)
        {
            // Update towers and minions
            foreach (var tower in towers)
            {
                tower.Update(gameTime);
            }

            foreach (var minion in minions)
            {
                minion.Update(gameTime);
            }

            // Check for player or AI spawn commands
            if (player.WantsToSpawn)
            {
                SpawnMinion(player);
            }

            if (ai.WantsToSpawn)
            {
                SpawnMinion(ai);
            }
        }

        private void SpawnMinion(Player player)
        {
            // Spawn a minion for the player
            minions.Add(new Minion(player.Position));
            player.WantsToSpawn = false;
        }

        private void SpawnMinion(AI ai)
        {
            // Spawn a minion for the AI
            minions.Add(new Minion(ai.Position));
            ai.WantsToSpawn = false;
        }

        public void Draw(GameTime gameTime)
        {
            // Draw towers and minions
            foreach (var tower in towers)
            {
                tower.Draw(gameTime);
            }

            foreach (var minion in minions)
            {
                minion.Draw(gameTime);
            }
        }
    }
}