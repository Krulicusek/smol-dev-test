```python
import pygame
from constants import BASE_HEALTH, SCORE, CURRENT_LEVEL

class HUD:
    def __init__(self, screen):
        self.screen = screen
        self.font = pygame.font.Font('assets/fonts/main_font.ttf', 24)
        self.base_health = BASE_HEALTH
        self.score = SCORE
        self.current_level = CURRENT_LEVEL

    def update(self, base_health, score, current_level):
        self.base_health = base_health
        self.score = score
        self.current_level = current_level

    def draw(self):
        # Draw the base health indicator
        base_health_text = self.font.render(f'Base Health: {self.base_health}', True, (255, 255, 255))
        self.screen.blit(base_health_text, (10, 10))

        # Draw the score display
        score_text = self.font.render(f'Score: {self.score}', True, (255, 255, 255))
        self.screen.blit(score_text, (10, 40))

        # Draw the level indicator
        level_text = self.font.render(f'Level: {self.current_level}', True, (255, 255, 255))
        self.screen.blit(level_text, (10, 70))

    def handle_events(self, event):
        # HUD doesn't handle events but it's here if needed in the future
        pass
```