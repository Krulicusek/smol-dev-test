import React, { useState } from 'react';

const Shop = () => {
  const [items, setItems] = useState([
    { id: 1, name: 'Minion Booster', effect: 'Increase minion strength and speed' },
    { id: 2, name: 'Tower Upgrade', effect: 'Increase tower attack speed and armor' },
    // Add more items as needed
  ]);

  const purchaseItem = (itemId) => {
    const item = items.find(item => item.id === itemId);
    if (item) {
      // Implement the logic to purchase the item
      // This could involve updating the state of the game, the player's resources, etc.
    }
  };

  return (
    <div id="shop-container" style={{width: '100vw', height: '100vh'}}>
      {items.map(item => (
        <div key={item.id} onClick={() => purchaseItem(item.id)}>
          <h2>{item.name}</h2>
          <p>{item.effect}</p>
        </div>
      ))}
    </div>
  );
};

export default Shop;