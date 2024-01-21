```python
import pygame
from constants import UPGRADE_COSTS, UPGRADE_VALUES

class Upgrade:
    def __init__(self, type):
        self.type = type
        self.level = 0
        self.cost = UPGRADE_COSTS[type][self.level]
        self.value = UPGRADE_VALUES[type][self.level]

    def upgrade(self):
        if self.level < len(UPGRADE_COSTS[self.type]) - 1:
            self.level += 1
            self.cost = UPGRADE_COSTS[self.type][self.level]
            self.value = UPGRADE_VALUES[self.type][self.level]

    def draw(self, win):
        pygame.draw.rect(win, (255, 255, 255), (self.x, self.y, self.width, self.height))
        font = pygame.font.SysFont("comicsans", 50)
        text = font.render(self.type + ": " + str(self.level), 1, (0, 0, 0))
        win.blit(text, (self.x, self.y))
```