```javascript
document.addEventListener('DOMContentLoaded', (event) => {
    const mapView = document.querySelector('#mapView');
    const shopView = document.querySelector('#shopView');
    const hud = document.querySelector('#hud');

    // Import gameState from game.js
    import { gameState } from '../src/game.js';

    // Listen for gameStart and gameOver messages
    document.addEventListener('gameStart', startGame);
    document.addEventListener('gameOver', endGame);

    // Import and call startGame() and endGame() from game.js
    import { startGame, endGame } from '../src/game.js';
    startGame();
    endGame();

    // Import and call spawnMinion() and upgradeTower() from gameMechanics.js
    import { spawnMinion, upgradeTower } from '../src/gameMechanics.js';
    spawnMinion();
    upgradeTower();
});
```