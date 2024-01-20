using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TowerDefense.Managers
{
    public class PlayerManager
    {
        private Player player;
        private int turretLimit;
        private int currency;

        public PlayerManager(Player player, int turretLimit)
        {
            this.player = player;
            this.turretLimit = turretLimit;
            this.currency = 0;
        }

        public void Update(GameTime gameTime)
        {
            HandleInput();
            player.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            player.Draw(spriteBatch);
        }

        private void HandleInput()
        {
            KeyboardState state = Keyboard.GetState();

            if (state.IsKeyDown(Keys.Space))
            {
                if (currency >= 100 && player.Turrets.Count < turretLimit)
                {
                    player.PlaceTurret();
                    currency -= 100;
                }
            }

            if (state.IsKeyDown(Keys.U))
            {
                if (currency >= 200)
                {
                    player.UpgradeTurret();
                    currency -= 200;
                }
            }
        }

        public void AddCurrency(int amount)
        {
            currency += amount;
        }
    }
}