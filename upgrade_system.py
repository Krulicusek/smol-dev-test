```python
import json
from constants import UPGRADE_COSTS, DEFENSE_FORMULAS
from data.player_progress import PLAYER_PROGRESS

class UpgradeSystem:
    def __init__(self):
        self.upgrade_costs = UPGRADE_COSTS
        self.defense_formulas = DEFENSE_FORMULAS
        self.player_progress = PLAYER_PROGRESS

    def upgrade_defense(self, defense_id):
        if defense_id in self.defense_formulas:
            current_level = self.player_progress['defenses'][defense_id]['level']
            upgrade_cost = self.upgrade_costs[defense_id][current_level]
            player_currency = self.player_progress['currency']

            if player_currency >= upgrade_cost:
                self.player_progress['currency'] -= upgrade_cost
                self.player_progress['defenses'][defense_id]['level'] += 1
                self.save_progress()
                return True
            else:
                print("Not enough currency to upgrade.")
                return False
        else:
            print("Defense ID not recognized.")
            return False

    def unlock_formula(self, formula_id):
        if formula_id not in self.player_progress['unlocked_formulas']:
            self.player_progress['unlocked_formulas'].append(formula_id)
            self.save_progress()
            return True
        else:
            print("Formula already unlocked.")
            return False

    def save_progress(self):
        with open('data/player_progress.json', 'w') as file:
            json.dump(self.player_progress, file)

    def load_progress(self):
        with open('data/player_progress.json', 'r') as file:
            self.player_progress = json.load(file)

# Initialize the upgrade system
upgrade_system = UpgradeSystem()
upgrade_system.load_progress()

# Example usage:
# upgrade_system.upgrade_defense('circle_barrier')
# upgrade_system.unlock_formula('y=mx+b')
```