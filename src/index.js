```javascript
import { gameState } from './game.js';
import { startGame, endGame } from './gameMechanics.js';

document.addEventListener('DOMContentLoaded', () => {
  const mapView = document.querySelector('#mapView');
  const shopView = document.querySelector('#shopView');
  const hud = document.querySelector('#hud');

  // Listen for game start and end events
  document.addEventListener('gameStart', startGame);
  document.addEventListener('gameOver', endGame);

  // Initialize game state
  gameState.init();

  // Render initial game state
  mapView.render(gameState);
  shopView.render(gameState);
  hud.render(gameState);
});
```