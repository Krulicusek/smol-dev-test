// Importing necessary modules and functions
import { createBarrier, updateDefenses } from './defenses.js';
import { spawnProjectile, updateProjectiles } from './projectiles.js';
import { applyUpgrade, unlockNewFormula } from './upgradeSystem.js';
import { drawAxes } from './axes.js';
import { calculateCircle } from './mathFormulas.js';
import { detectCollision } from './utilities.js';

// Game state variables
let gameRunning = false;
let requestId;
let score = 0;
let health = 100;

// Initialize the game environment
function initializeGame() {
  const svgCanvas = document.getElementById('svgCanvas');
  drawAxes(svgCanvas);
  createBarrier(svgCanvas);
  gameRunning = true;
  gameLoop();
}

// Main game loop
function gameLoop() {
  if (!gameRunning) {
    return;
  }

  updateProjectiles();
  updateDefenses();
  handleCollisions();
  updateGameUI();

  // Request the next frame
  requestId = requestAnimationFrame(gameLoop);
}

// Handle collisions between projectiles and defenses
function handleCollisions() {
  const projectiles = document.querySelectorAll('.projectile');
  const barriers = document.querySelectorAll('.barrier');

  projectiles.forEach(projectile => {
    barriers.forEach(barrier => {
      if (detectCollision(projectile, barrier)) {
        // Modify the health of the barrier and projectile accordingly
        health -= 10; // Example damage value
        projectile.remove(); // Remove the projectile from the game
        updateHealthIndicator();
      }
    });
  });

  if (health <= 0) {
    endGame();
  }
}

// Update the game UI elements
function updateGameUI() {
  const healthIndicator = document.getElementById('healthIndicator');
  const scoreBoard = document.getElementById('scoreBoard');

  healthIndicator.textContent = `Health: ${health}`;
  scoreBoard.textContent = `Score: ${score}`;
}

// Update the health indicator
function updateHealthIndicator() {
  const healthIndicator = document.getElementById('healthIndicator');
  healthIndicator.textContent = `Health: ${health}`;
}

// End the game
function endGame() {
  gameRunning = false;
  cancelAnimationFrame(requestId);
  alert('Game Over! Your score: ' + score);
}

// Start the game when the DOM is fully loaded
document.addEventListener('DOMContentLoaded', () => {
  initializeGame();
});

// Exporting functions for potential use in other modules
export { initializeGame, gameLoop, handleCollisions, updateGameUI, endGame };