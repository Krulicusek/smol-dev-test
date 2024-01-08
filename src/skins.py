```python
class Skin:
    def __init__(self, name, image_path):
        self.name = name
        self.image_path = image_path

class TowerSkin(Skin):
    def __init__(self, name, image_path):
        super().__init__(name, image_path)

class ChampionSkin(Skin):
    def __init__(self, name, image_path):
        super().__init__(name, image_path)

class SkinManager:
    def __init__(self):
        self.tower_skins = {}
        self.champion_skins = {}

    def add_tower_skin(self, name, image_path):
        self.tower_skins[name] = TowerSkin(name, image_path)

    def add_champion_skin(self, name, image_path):
        self.champion_skins[name] = ChampionSkin(name, image_path)

    def get_tower_skin(self, name):
        return self.tower_skins.get(name, None)

    def get_champion_skin(self, name):
        return self.champion_skins.get(name, None)
```