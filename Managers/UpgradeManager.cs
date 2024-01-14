using System;
using System.Collections.Generic;
using Entities;

namespace Managers
{
    public class UpgradeManager
    {
        private Dictionary<string, int> upgradeCosts;

        public UpgradeManager()
        {
            upgradeCosts = new Dictionary<string, int>
            {
                {"tower", 100},
                {"minion", 50},
                {"base", 200}
            };
        }

        public bool CanUpgrade(string entityName, int playerGold)
        {
            return playerGold >= upgradeCosts[entityName];
        }

        public void UpgradeTower(Tower tower)
        {
            if (CanUpgrade("tower", Player.Gold))
            {
                tower.Upgrade();
                Player.Gold -= upgradeCosts["tower"];
            }
        }

        public void UpgradeMinion(Minion minion)
        {
            if (CanUpgrade("minion", Player.Gold))
            {
                minion.Upgrade();
                Player.Gold -= upgradeCosts["minion"];
            }
        }

        public void UpgradeBase(Base baseEntity)
        {
            if (CanUpgrade("base", Player.Gold))
            {
                baseEntity.Upgrade();
                Player.Gold -= upgradeCosts["base"];
            }
        }
    }
}