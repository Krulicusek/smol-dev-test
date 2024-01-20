using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Entities;

namespace Managers
{
    public class TurretManager
    {
        private List<Turret> turrets;
        private int turretLimit;
        private int turretCost;

        public TurretManager()
        {
            turrets = new List<Turret>();
            turretLimit = 10; // Arbitrary limit, can be adjusted
            turretCost = 100; // Arbitrary cost, can be adjusted
        }

        public void Update(GameTime gameTime)
        {
            foreach (var turret in turrets)
            {
                turret.Update(gameTime);
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (var turret in turrets)
            {
                turret.Draw(spriteBatch);
            }
        }

        public bool CanPlaceTurret(Player player)
        {
            return turrets.Count < turretLimit && player.Currency >= turretCost;
        }

        public void PlaceTurret(Player player, Vector2 position)
        {
            if (CanPlaceTurret(player))
            {
                turrets.Add(new Turret(position));
                player.Currency -= turretCost;
            }
        }

        public void UpgradeTurret(Player player, Turret turret)
        {
            if (player.Currency >= turret.UpgradeCost)
            {
                turret.Upgrade();
                player.Currency -= turret.UpgradeCost;
            }
        }
    }
}