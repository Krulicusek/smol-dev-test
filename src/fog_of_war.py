```python
class FogOfWar:
    def __init__(self, game_state):
        self.game_state = game_state
        self.visibility_map = self.initialize_visibility_map()

    def initialize_visibility_map(self):
        map_size = self.game_state['map'].size
        return [[False for _ in range(map_size[1])] for _ in range(map_size[0])]

    def update_visibility(self, champion_position, vision_range):
        x, y = champion_position
        for i in range(max(0, x - vision_range), min(self.game_state['map'].size[0], x + vision_range + 1)):
            for j in range(max(0, y - vision_range), min(self.game_state['map'].size[1], y + vision_range + 1)):
                self.visibility_map[i][j] = True

    def is_visible(self, position):
        x, y = position
        return self.visibility_map[x][y]

    def apply_augment(self, augment):
        if augment.type == 'vision':
            self.update_visibility(self.game_state['champion'].position, augment.effect_range)

    def update_game_state(self, game_state):
        self.game_state = game_state
        self.visibility_map = self.initialize_visibility_map()
        for augment in self.game_state['augments']:
            if augment.type == 'vision':
                self.apply_augment(augment)
```
