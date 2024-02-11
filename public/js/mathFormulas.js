// public/js/mathFormulas.js

// Function to calculate the SVG path for a circle based on the equation x^2 + y^2 = r^2
function calculateCircle(radius) {
  // SVG circle path calculation
  return `
    M ${radius}, 0
    a ${radius},${radius} 0 1,0 ${-2 * radius},0
    a ${radius},${radius} 0 1,0 ${2 * radius},0
  `;
}

// Function to calculate the SVG path for a horizontal line based on the equation y = k
function calculateLine(y) {
  // SVG line path calculation
  return `M 0,${y} L 100,${y}`;
}

// Export the functions to be used in other scripts
export { calculateCircle, calculateLine };