// projectiles.js

class Projectile {
  constructor(svgCanvas, x, y, velocity, angle) {
    this.svgCanvas = svgCanvas;
    this.x = x;
    this.y = y;
    this.velocity = velocity;
    this.angle = angle;
    this.element = null;
  }

  create() {
    const projectileSVG = document.createElementNS("http://www.w3.org/2000/svg", "circle");
    projectileSVG.setAttribute("cx", this.x);
    projectileSVG.setAttribute("cy", this.y);
    projectileSVG.setAttribute("r", 5); // radius of the projectile
    projectileSVG.classList.add("projectile");
    this.svgCanvas.appendChild(projectileSVG);
    this.element = projectileSVG;
  }

  updatePosition(deltaTime) {
    // Convert angle to radians for calculation
    const angleRad = (Math.PI / 180) * this.angle;
    // Update the x and y position based on velocity and angle
    this.x += Math.cos(angleRad) * this.velocity * deltaTime;
    this.y += Math.sin(angleRad) * this.velocity * deltaTime;
    // Update the SVG element's position
    this.element.setAttribute("cx", this.x);
    this.element.setAttribute("cy", this.y);
  }

  isOutOfBounds(width, height) {
    // Check if the projectile has gone out of the SVG canvas bounds
    return this.x < 0 || this.x > width || this.y < 0 || this.y > height;
  }

  remove() {
    // Remove the projectile from the SVG canvas
    this.svgCanvas.removeChild(this.element);
  }
}

function spawnProjectile(svgCanvas, x, y, velocity, angle) {
  const projectile = new Projectile(svgCanvas, x, y, velocity, angle);
  projectile.create();
  return projectile;
}

function updateProjectiles(projectiles, deltaTime, width, height) {
  projectiles.forEach((projectile, index) => {
    projectile.updatePosition(deltaTime);
    if (projectile.isOutOfBounds(width, height)) {
      projectile.remove();
      projectiles.splice(index, 1);
    }
  });
}

// Export the functions to be used by other modules
export { spawnProjectile, updateProjectiles };