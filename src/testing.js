```javascript
const assert = require('assert');
const { gameState } = require('./game.js');
const { TowerSchema, MinionSchema } = require('./gameMechanics.js');

function testGameState() {
    assert(gameState !== null, 'Game state should not be null');
    assert(gameState !== undefined, 'Game state should not be undefined');
}

function testTowerSchema() {
    const tower = new TowerSchema();
    assert(tower !== null, 'Tower should not be null');
    assert(tower !== undefined, 'Tower should not be undefined');
}

function testMinionSchema() {
    const minion = new MinionSchema();
    assert(minion !== null, 'Minion should not be null');
    assert(minion !== undefined, 'Minion should not be undefined');
}

function runTests() {
    testGameState();
    testTowerSchema();
    testMinionSchema();
    console.log('All tests passed');
}

runTests();
```