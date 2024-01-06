import React, { useState } from 'react';
import Upgrade from './upgrade.js';

const Tower = () => {
    const [attackSpeed, setAttackSpeed] = useState(1);
    const [armor, setArmor] = useState(0);
    const [magicResist, setMagicResist] = useState(0);

    const upgradeTower = (upgradeType) => {
        switch(upgradeType) {
            case 'attackSpeed':
                setAttackSpeed(attackSpeed * 1.5);
                break;
            case 'armor':
                setArmor(armor * 1.35);
                break;
            case 'magicResist':
                setMagicResist(magicResist * 1.35);
                break;
            default:
                break;
        }
    }

    return (
        <div id="tower-container" onClick={() => upgradeTower('attackSpeed')}>
            <Upgrade type="attackSpeed" upgradeFunction={upgradeTower} />
            <Upgrade type="armor" upgradeFunction={upgradeTower} />
            <Upgrade type="magicResist" upgradeFunction={upgradeTower} />
        </div>
    );
}

export default Tower;