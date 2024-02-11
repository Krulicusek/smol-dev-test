// projectiles.js
import { convertToSVGPath, detectCollision } from './utilities.js';
import { updateHealth } from './game.js';

const projectiles = [];
const projectileTypes = {
  'linear': { equation: 'y = x', svgPath: '' },
  // Additional projectile types with their respective equations can be added here
};

function initializeProjectileTypes() {
  for (const type in projectileTypes) {
    projectileTypes[type].svgPath = convertToSVGPath(projectileTypes[type].equation);
  }
}

function spawnProjectile(type, startX, startY, velocityX, velocityY) {
  if (!projectileTypes[type]) {
    console.error(`Projectile type "${type}" not found.`);
    return;
  }

  const projectile = {
    type: type,
    x: startX,
    y: startY,
    velocityX: velocityX,
    velocityY: velocityY,
    svgElement: document.createElementNS('http://www.w3.org/2000/svg', 'path')
  };

  projectile.svgElement.setAttribute('d', projectileTypes[type].svgPath);
  projectile.svgElement.classList.add('projectile');
  document.getElementById('svgCanvas').appendChild(projectile.svgElement);

  projectiles.push(projectile);
}

function updateProjectiles(deltaTime) {
  projectiles.forEach((projectile, index) => {
    projectile.x += projectile.velocityX * deltaTime;
    projectile.y += projectile.velocityY * deltaTime;

    projectile.svgElement.setAttribute('transform', `translate(${projectile.x} ${projectile.y})`);

    if (detectCollision(projectile.svgElement)) {
      updateHealth(-1);
      projectile.svgElement.remove();
      projectiles.splice(index, 1);
    }
  });
}

function randomizeProjectileSpawn() {
  const type = Object.keys(projectileTypes)[Math.floor(Math.random() * Object.keys(projectileTypes).length)];
  const startX = Math.random() * window.innerWidth;
  const startY = -50; // Start above the viewable area
  const velocityX = (Math.random() - 0.5) * 2; // Random X velocity between -1 and 1
  const velocityY = Math.random() + 0.5; // Random Y velocity between 0.5 and 1.5

  spawnProjectile(type, startX, startY, velocityX, velocityY);
}

// Initialize projectile types on load
initializeProjectileTypes();

// Export functions for use in other modules
export { spawnProjectile, updateProjectiles, randomizeProjectileSpawn };