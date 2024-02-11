// upgradeSystem.js

const mathFormulas = require('./mathFormulas.js');
const defenses = require('./defenses.js');

function applyUpgrade(defenseType, upgradeType) {
  // Assuming each defense has an 'id', 'type', and 'strength' property
  const defense = defenses.getDefenseById(defenseType);
  if (!defense) {
    console.error('Defense not found');
    return;
  }

  switch (upgradeType) {
    case 'increaseStrength':
      defense.strength += 10; // Increment strength by 10
      break;
    case 'expandRadius':
      if (defense.type === 'circle') {
        defense.radius += 5; // Increment radius by 5 for circular defenses
      }
      break;
    case 'heightenWall':
      if (defense.type === 'wall') {
        defense.height += 5; // Increment height by 5 for wall defenses
      }
      break;
    default:
      console.error('Invalid upgrade type');
      return;
  }

  // Update the SVG representation of the defense
  defenses.updateDefenseSVG(defense);
  // Notify the game of the applied upgrade
  const upgradeAppliedEvent = new CustomEvent('upgradeApplied', { detail: { defenseType, upgradeType } });
  document.dispatchEvent(upgradeAppliedEvent);
}

function unlockNewFormula(formulaType) {
  // Assuming we have a set of predefined formulas that can be unlocked
  const newFormula = mathFormulas.getFormulaByType(formulaType);
  if (!newFormula) {
    console.error('Formula type not found');
    return;
  }

  // Add the new formula to the player's arsenal
  mathFormulas.addFormulaToPlayerArsenal(newFormula);
  // Notify the game that a new formula has been unlocked
  const unlockFormulaEvent = new CustomEvent('newFormulaUnlocked', { detail: { formulaType } });
  document.dispatchEvent(unlockFormulaEvent);
}

module.exports = {
  applyUpgrade,
  unlockNewFormula
};