```javascript
import { gameState, TowerSchema } from './game.js';
import { startGame, endGame, upgradeTower } from './gameMechanics.js';

const mapView = document.getElementById('mapView');

function renderMap() {
    mapView.innerHTML = '';
    gameState.map.forEach((row, rowIndex) => {
        row.forEach((cell, cellIndex) => {
            const cellElement = document.createElement('div');
            cellElement.classList.add('cell');
            if (cell instanceof TowerSchema) {
                cellElement.classList.add('tower');
                cellElement.addEventListener('click', () => {
                    upgradeTower(rowIndex, cellIndex);
                });
            }
            mapView.appendChild(cellElement);
        });
    });
}

function initMap() {
    renderMap();
    document.addEventListener('gameStart', renderMap);
    document.addEventListener('gameOver', () => {
        mapView.innerHTML = '';
    });
}

export default initMap;
```