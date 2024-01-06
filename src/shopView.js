```javascript
import { gameState } from './game.js';
import { upgradeTower } from './gameMechanics.js';

const shopView = document.getElementById('shopView');

function displayShopItems() {
    const shopItems = gameState.shopItems;
    shopView.innerHTML = '';

    shopItems.forEach(item => {
        const itemElement = document.createElement('div');
        itemElement.classList.add('shop-item');
        itemElement.innerText = `${item.name}: ${item.price} gold`;

        itemElement.addEventListener('click', () => {
            if (gameState.gold >= item.price) {
                gameState.gold -= item.price;
                upgradeTower(item);
            }
        });

        shopView.appendChild(itemElement);
    });
}

function openShopView() {
    shopView.style.display = 'block';
    displayShopItems();
}

function closeShopView() {
    shopView.style.display = 'none';
}

export { openShopView, closeShopView };
```