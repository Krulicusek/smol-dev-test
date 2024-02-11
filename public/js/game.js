// Importing dependencies from other script files
import { createBarrier, updateDefenses } from './defenses.js';
import { spawnProjectile, updateProjectiles } from './projectiles.js';
import { applyUpgrade, unlockNewFormula } from './upgradeSystem.js';
import { drawAxes } from './axes.js';
import { calculateCircle, calculateLine } from './mathFormulas.js';
import { convertToSVGPath, detectCollision } from './utilities.js';

// Game state variables
let gameRunning = false;
let requestId;

// Initialize the game environment
function initializeGame() {
  const svgCanvas = document.getElementById('svgCanvas');
  drawAxes(svgCanvas);
  createBarrier(svgCanvas);
  gameRunning = true;
  gameLoop();
}

// The main game loop
function gameLoop() {
  if (!gameRunning) {
    return;
  }

  updateProjectiles();
  updateDefenses();
  handleCollisions();

  // Request the next frame of the game
  requestId = requestAnimationFrame(gameLoop);
}

// Detects and handles collisions between projectiles and defenses
function handleCollisions() {
  const projectiles = document.getElementsByClassName('projectile');
  const barriers = document.getElementsByClassName('barrier');

  for (let projectile of projectiles) {
    for (let barrier of barriers) {
      if (detectCollision(projectile, barrier)) {
        // Handle collision logic here
        // Update health indicator, score, etc.
        const healthIndicator = document.getElementById('healthIndicator');
        const scoreBoard = document.getElementById('scoreBoard');
        // Placeholder for updating health and score
        healthIndicator.textContent = 'Health: X';
        scoreBoard.textContent = 'Score: Y';
      }
    }
  }
}

// Start the game when the DOM is fully loaded
document.addEventListener('DOMContentLoaded', () => {
  initializeGame();
});

// Exporting functions that might be used by other scripts
export { initializeGame, gameLoop, handleCollisions };