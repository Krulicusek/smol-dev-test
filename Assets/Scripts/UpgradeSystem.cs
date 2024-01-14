```csharp
using UnityEngine;

public class UpgradeSystem : MonoBehaviour
{
    public int towerUpgradeCost = 100;
    public int minionUpgradeCost = 50;

    public void UpgradeTower(Tower tower)
    {
        if (PlayerController.gold >= towerUpgradeCost)
        {
            tower.level += 1;
            tower.damage += 10;
            tower.range += 1;
            PlayerController.gold -= towerUpgradeCost;
        }
    }

    public void UpgradeMinion(Minion minion)
    {
        if (PlayerController.gold >= minionUpgradeCost)
        {
            minion.level += 1;
            minion.damage += 5;
            minion.health += 10;
            PlayerController.gold -= minionUpgradeCost;
        }
    }
}
```