// Import necessary functions from other scripts
import { calculateCircle, calculateLine } from './mathFormulas.js';
import { convertToSVGPath } from './utilities.js';

// Define the defenses class
class Defenses {
  constructor(svgCanvas) {
    this.svgCanvas = svgCanvas;
    this.barriers = [];
  }

  createBarrier(radius) {
    const circlePath = calculateCircle(radius);
    const svgPath = convertToSVGPath(circlePath);
    const barrier = document.createElementNS('http://www.w3.org/2000/svg', 'path');
    barrier.setAttribute('d', svgPath);
    barrier.classList.add('barrier');
    this.svgCanvas.appendChild(barrier);
    this.barriers.push(barrier);
  }

  updateDefenses() {
    this.barriers.forEach((barrier, index) => {
      // Logic to update the defenses based on game state
      // For example, changing the radius of the barrier
      // This is a placeholder for the actual game logic
      const newRadius = barrier.radius.baseVal.value - 1; // Decrease radius for demonstration
      if (newRadius > 0) {
        const circlePath = calculateCircle(newRadius);
        const svgPath = convertToSVGPath(circlePath);
        barrier.setAttribute('d', svgPath);
      } else {
        // Remove the barrier if the radius is zero or less
        this.svgCanvas.removeChild(barrier);
        this.barriers.splice(index, 1);
      }
    });
  }
}

// Export the Defenses class to be used in the main game script
export { Defenses };