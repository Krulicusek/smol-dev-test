```javascript
import { gameState } from './game.js';

const mapView = document.querySelector('#mapView');
const shopView = document.querySelector('#shopView');
const hud = document.querySelector('#hud');

function updateHUD() {
    hud.innerHTML = `
        <div>Score: ${gameState.score}</div>
        <div>Health: ${gameState.health}</div>
        <div>Gold: ${gameState.gold}</div>
    `;
}

function updateMapView() {
    mapView.innerHTML = '';
    gameState.towers.forEach(tower => {
        const towerElement = document.createElement('div');
        towerElement.classList.add('tower');
        towerElement.style.left = `${tower.position.x}px`;
        towerElement.style.top = `${tower.position.y}px`;
        mapView.appendChild(towerElement);
    });
}

function updateShopView() {
    shopView.innerHTML = '';
    gameState.shopItems.forEach(item => {
        const itemElement = document.createElement('div');
        itemElement.classList.add('shop-item');
        itemElement.innerHTML = `
            <div>${item.name}</div>
            <div>${item.cost} Gold</div>
        `;
        shopView.appendChild(itemElement);
    });
}

function startGameUI() {
    updateHUD();
    updateMapView();
    updateShopView();
}

function endGameUI() {
    hud.innerHTML = 'Game Over';
    mapView.innerHTML = '';
    shopView.innerHTML = '';
}

export { startGameUI, endGameUI, updateHUD, updateMapView, updateShopView };
```