import { calculateCircle, calculateLine } from './mathFormulas.js';
import { convertToSVGPath } from './utilities.js';

const defenses = {
  barriers: [],
  walls: []
};

function createBarrier(svgCanvas, radius) {
  const circlePath = calculateCircle(radius);
  const barrierSVG = document.createElementNS('http://www.w3.org/2000/svg', 'path');
  barrierSVG.setAttribute('d', convertToSVGPath(circlePath));
  barrierSVG.classList.add('barrier');
  svgCanvas.appendChild(barrierSVG);
  defenses.barriers.push({ element: barrierSVG, radius: radius });
}

function createWall(svgCanvas, y) {
  const linePath = calculateLine(y);
  const wallSVG = document.createElementNS('http://www.w3.org/2000/svg', 'path');
  wallSVG.setAttribute('d', convertToSVGPath(linePath));
  wallSVG.classList.add('wall');
  svgCanvas.appendChild(wallSVG);
  defenses.walls.push({ element: wallSVG, y: y });
}

function updateDefenses() {
  defenses.barriers.forEach(barrier => {
    // Logic to update barrier properties, such as reducing radius on hit
  });
  defenses.walls.forEach(wall => {
    // Logic to update wall properties, such as changing position or height
  });
}

export { createBarrier, createWall, updateDefenses };