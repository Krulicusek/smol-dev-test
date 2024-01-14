using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TowerDefense.Managers
{
    public class GameManager
    {
        private List<Entities.Tower> towers;
        private List<Entities.Minion> minions;
        private Entities.Base baseEntity;
        private Entities.Player player;
        private Entities.AI ai;

        public GameManager()
        {
            towers = new List<Entities.Tower>();
            minions = new List<Entities.Minion>();
            baseEntity = new Entities.Base();
            player = new Entities.Player();
            ai = new Entities.AI();
        }

        public void Initialize()
        {
            // Initialize entities
            foreach (var tower in towers)
            {
                tower.Initialize();
            }

            foreach (var minion in minions)
            {
                minion.Initialize();
            }

            baseEntity.Initialize();
            player.Initialize();
            ai.Initialize();
        }

        public void Update(GameTime gameTime)
        {
            // Update entities
            foreach (var tower in towers)
            {
                tower.Update(gameTime);
            }

            foreach (var minion in minions)
            {
                minion.Update(gameTime);
            }

            baseEntity.Update(gameTime);
            player.Update(gameTime);
            ai.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            // Draw entities
            foreach (var tower in towers)
            {
                tower.Draw(spriteBatch);
            }

            foreach (var minion in minions)
            {
                minion.Draw(spriteBatch);
            }

            baseEntity.Draw(spriteBatch);
            player.Draw(spriteBatch);
            ai.Draw(spriteBatch);
        }
    }
}