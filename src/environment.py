```python
class Environment:
    def __init__(self):
        self.dynamic_elements = []

    def add_element(self, element):
        self.dynamic_elements.append(element)

    def remove_element(self, element):
        self.dynamic_elements.remove(element)

    def update(self, game_state):
        for element in self.dynamic_elements:
            element.update(game_state)

class DynamicElement:
    def __init__(self, id, position):
        self.id = id
        self.position = position

    def update(self, game_state):
        pass

class Weather(DynamicElement):
    def __init__(self, id, position, weather_type):
        super().__init__(id, position)
        self.weather_type = weather_type

    def update(self, game_state):
        # Update game state based on weather conditions
        pass

class Terrain(DynamicElement):
    def __init__(self, id, position, terrain_type):
        super().__init__(id, position)
        self.terrain_type = terrain_type

    def update(self, game_state):
        # Update game state based on terrain conditions
        pass
```