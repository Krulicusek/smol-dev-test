```javascript
import { gameState } from './game.js';
import { TowerSchema, MinionSchema } from './assets.js';

export function spawnMinion() {
  const minion = new MinionSchema();
  gameState.minions.push(minion);
}

export function upgradeTower(towerId, upgradeType) {
  const tower = gameState.towers.find(t => t.id === towerId);
  if (!tower) {
    console.error(`Tower with id ${towerId} not found.`);
    return;
  }

  switch (upgradeType) {
    case 'damage':
      tower.damage += 10;
      break;
    case 'range':
      tower.range += 1;
      break;
    default:
      console.error(`Invalid upgrade type: ${upgradeType}`);
  }
}

export function attack() {
  gameState.minions.forEach(minion => {
    const towerInRange = gameState.towers.find(tower => {
      const distance = Math.hypot(tower.x - minion.x, tower.y - minion.y);
      return distance <= tower.range;
    });

    if (towerInRange) {
      minion.health -= towerInRange.damage;
      if (minion.health <= 0) {
        const index = gameState.minions.indexOf(minion);
        gameState.minions.splice(index, 1);
      }
    }
  });
}

export function defend() {
  gameState.towers.forEach(tower => {
    const minionInRange = gameState.minions.find(minion => {
      const distance = Math.hypot(tower.x - minion.x, tower.y - minion.y);
      return distance <= tower.range;
    });

    if (minionInRange) {
      tower.health -= minionInRange.damage;
      if (tower.health <= 0) {
        const index = gameState.towers.indexOf(tower);
        gameState.towers.splice(index, 1);
      }
    }
  });
}
```