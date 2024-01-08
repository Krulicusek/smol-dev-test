```python
class Champion:
    def __init__(self, champion_schema):
        self.champion_schema = champion_schema
        self.game_state = None
        self.augments = None

    def spawn(self, game_state, augments):
        self.game_state = game_state
        self.augments = augments
        self.game_state['champion'] = self.champion_schema
        self.update_game_state()

    def move(self, direction):
        if direction in ['up', 'down', 'left', 'right']:
            self.game_state['champion']['position'] = self.calculate_new_position(direction)
            self.update_game_state()

    def attack(self, target):
        if self.is_target_in_range(target):
            target['health'] -= self.game_state['champion']['attack_damage']
            self.update_game_state()

    def use_ability(self, ability_name, target):
        if ability_name in self.game_state['champion']['abilities']:
            ability = self.game_state['champion']['abilities'][ability_name]
            if self.can_use_ability(ability):
                ability['effect'](target)
                self.update_game_state()

    def calculate_new_position(self, direction):
        # Calculate new position based on direction and champion's speed
        pass

    def is_target_in_range(self, target):
        # Check if target is within champion's attack range
        pass

    def can_use_ability(self, ability):
        # Check if ability can be used (e.g. enough resources, not on cooldown)
        pass

    def update_game_state(self):
        # Update game state with current champion status
        pass
```