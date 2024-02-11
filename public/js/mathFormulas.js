// Calculate the SVG path for a circle based on the equation x^2 + y^2 = r^2
function calculateCircle(radius) {
  // SVG circle path calculation
  return `<circle cx="0" cy="0" r="${radius}" />`;
}

// Calculate the SVG path for a horizontal line based on the equation y = k
function calculateLine(yIntercept) {
  // SVG line path calculation for a horizontal line
  const x1 = -100; // Start point on the left side of the SVG canvas
  const x2 = 100;  // End point on the right side of the SVG canvas
  return `<line x1="${x1}" y1="${yIntercept}" x2="${x2}" y2="${yIntercept}" />`;
}

// Export the functions to be used in other scripts
export { calculateCircle, calculateLine };