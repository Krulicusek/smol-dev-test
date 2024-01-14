using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace TowerDefenseGame.Components
{
    public class GameMap
    {
        private Texture2D mapTexture;
        private List<Tower> towers;
        private List<Minion> minions;
        private Player player;
        private EnemyAI enemyAI;

        public GameMap(Game1 game, Player player, EnemyAI enemyAI)
        {
            this.player = player;
            this.enemyAI = enemyAI;
            this.towers = new List<Tower>();
            this.minions = new List<Minion>();
            this.mapTexture = game.Content.Load<Texture2D>("Images/GameMap");
        }

        public void Update(GameTime gameTime)
        {
            foreach (var tower in towers)
            {
                tower.Update(gameTime);
            }

            foreach (var minion in minions)
            {
                minion.Update(gameTime);
            }

            player.Update(gameTime);
            enemyAI.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(mapTexture, Vector2.Zero, Color.White);

            foreach (var tower in towers)
            {
                tower.Draw(spriteBatch);
            }

            foreach (var minion in minions)
            {
                minion.Draw(spriteBatch);
            }

            player.Draw(spriteBatch);
            enemyAI.Draw(spriteBatch);
        }
    }
}