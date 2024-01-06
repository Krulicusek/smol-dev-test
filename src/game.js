import React, { useState } from 'react';
import Tower from './tower';
import Shop from './shop';
import Minion from './minion';
import Upgrade from './upgrade';

const Game = () => {
  const [gameState, setGameState] = useState('stop');
  const [towers, setTowers] = useState([]);
  const [minions, setMinions] = useState([]);
  const [shopItems, setShopItems] = useState([]);
  const [upgrades, setUpgrades] = useState([]);

  const startGame = () => {
    setGameState('start');
    // Initialize towers, minions, shop items, and upgrades here
  };

  const endGame = () => {
    setGameState('stop');
    // Reset towers, minions, shop items, and upgrades here
  };

  const spawnMinion = (minion) => {
    setMinions([...minions, minion]);
  };

  const purchaseItem = (item) => {
    setShopItems(shopItems.filter(shopItem => shopItem.id !== item.id));
    // Apply item effects here
  };

  const upgradeTower = (towerId, upgrade) => {
    setTowers(towers.map(tower => tower.id === towerId ? { ...tower, ...upgrade } : tower));
  };

  return (
    <div id="game-container" style={{ width: '100vw', height: '100vh' }}>
      <button onClick={startGame}>Start Game</button>
      <button onClick={endGame}>End Game</button>
      <div id="tower-container">
        {towers.map(tower => <Tower key={tower.id} {...tower} onUpgrade={upgradeTower} />)}
      </div>
      <div id="shop-container">
        <Shop items={shopItems} onPurchase={purchaseItem} />
      </div>
      <div id="minion-container">
        {minions.map(minion => <Minion key={minion.id} {...minion} />)}
      </div>
      <div id="upgrade-container">
        {upgrades.map(upgrade => <Upgrade key={upgrade.id} {...upgrade} />)}
      </div>
    </div>
  );
};

export default Game;