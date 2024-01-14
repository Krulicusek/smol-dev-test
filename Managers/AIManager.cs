using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Entities;

namespace Managers
{
    public class AIManager
    {
        private List<AI> aiEntities;
        private TimeSpan spawnTime;
        private TimeSpan previousSpawnTime;

        public AIManager()
        {
            aiEntities = new List<AI>();
            spawnTime = TimeSpan.FromSeconds(2.0);
            previousSpawnTime = TimeSpan.Zero;
        }

        public void Initialize()
        {
            aiEntities.Clear();
        }

        public void Update(GameTime gameTime)
        {
            if (gameTime.TotalGameTime - previousSpawnTime > spawnTime)
            {
                previousSpawnTime = gameTime.TotalGameTime;
                SpawnAI();
            }

            for (int i = 0; i < aiEntities.Count; i++)
            {
                aiEntities[i].Update(gameTime);

                if (!aiEntities[i].IsActive)
                {
                    aiEntities.RemoveAt(i);
                    i--;
                }
            }
        }

        public void Draw(GameTime gameTime)
        {
            for (int i = 0; i < aiEntities.Count; i++)
            {
                aiEntities[i].Draw(gameTime);
            }
        }

        private void SpawnAI()
        {
            AI newAI = new AI();
            newAI.Initialize();
            aiEntities.Add(newAI);
        }
    }
}