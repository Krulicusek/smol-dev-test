// public/js/axes.js

function drawAxes(svgCanvas) {
    const svgNS = svgCanvas.namespaceURI;
    const width = svgCanvas.clientWidth;
    const height = svgCanvas.clientHeight;
    const centerX = width / 2;
    const centerY = height / 2;

    // Create the X axis line
    const xAxis = document.createElementNS(svgNS, 'line');
    xAxis.setAttribute('x1', 0);
    xAxis.setAttribute('y1', centerY);
    xAxis.setAttribute('x2', width);
    xAxis.setAttribute('y2', centerY);
    xAxis.setAttribute('stroke', 'black');
    xAxis.setAttribute('stroke-width', '2');
    xAxis.classList.add('axis');

    // Create the Y axis line
    const yAxis = document.createElementNS(svgNS, 'line');
    yAxis.setAttribute('x1', centerX);
    yAxis.setAttribute('y1', 0);
    yAxis.setAttribute('x2', centerX);
    yAxis.setAttribute('y2', height);
    yAxis.setAttribute('stroke', 'black');
    yAxis.setAttribute('stroke-width', '2');
    yAxis.classList.add('axis');

    // Append the axes to the SVG canvas
    svgCanvas.appendChild(xAxis);
    svgCanvas.appendChild(yAxis);
}

// Export the drawAxes function to be used by other modules
export { drawAxes };