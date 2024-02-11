// public/js/axes.js

function drawAxes(svgCanvas) {
  const width = svgCanvas.clientWidth;
  const height = svgCanvas.clientHeight;
  const centerX = width / 2;
  const centerY = height / 2;

  // Create the x-axis line
  const xAxis = document.createElementNS("http://www.w3.org/2000/svg", "line");
  xAxis.setAttribute("x1", 0);
  xAxis.setAttribute("y1", centerY);
  xAxis.setAttribute("x2", width);
  xAxis.setAttribute("y2", centerY);
  xAxis.setAttribute("stroke", "black");
  xAxis.classList.add("axis");

  // Create the y-axis line
  const yAxis = document.createElementNS("http://www.w3.org/2000/svg", "line");
  yAxis.setAttribute("x1", centerX);
  yAxis.setAttribute("y1", 0);
  yAxis.setAttribute("x2", centerX);
  yAxis.setAttribute("y2", height);
  yAxis.setAttribute("stroke", "black");
  yAxis.classList.add("axis");

  // Append axes to the SVG canvas
  svgCanvas.appendChild(xAxis);
  svgCanvas.appendChild(yAxis);
}

// Export the drawAxes function to be used in other modules
export { drawAxes };