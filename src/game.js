```javascript
const TowerSchema = require('./TowerSchema');
const MinionSchema = require('./MinionSchema');

let gameState = {
  towers: [],
  minions: [],
  gameRunning: false,
};

function startGame() {
  gameState.gameRunning = true;
  console.log('Game has started');
}

function endGame() {
  gameState.gameRunning = false;
  console.log('Game has ended');
}

function addTower(tower) {
  if (tower instanceof TowerSchema) {
    gameState.towers.push(tower);
    console.log('Tower added');
  } else {
    console.error('Invalid tower object');
  }
}

function addMinion(minion) {
  if (minion instanceof MinionSchema) {
    gameState.minions.push(minion);
    console.log('Minion added');
  } else {
    console.error('Invalid minion object');
  }
}

module.exports = {
  gameState,
  startGame,
  endGame,
  addTower,
  addMinion,
};
```