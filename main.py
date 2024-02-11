```python
import pygame
import json
from game_logic import GameLogic
from gui.main_menu import MainMenu
from gui.game_over import GameOver
from gui.pause_menu import PauseMenu
from gui.upgrade_menu import UpgradeMenu
from gui.level_select import LevelSelect
from gui.tutorial import Tutorial
from gui.hud import HUD
from constants import INITIAL_BASE_HEALTH, INITIAL_SCORE, MAX_LEVEL
from utils import loadLevel

# Initialize Pygame
pygame.init()

# Load settings
with open('config/settings.json', 'r') as settings_file:
    settings = json.load(settings_file)

# Set up the screen
screen_width = settings['screen_width']
screen_height = settings['screen_height']
screen = pygame.display.set_mode((screen_width, screen_height))
pygame.display.set_caption("MathGuardians: The Geometric Frontier")

# Load player progress
with open('data/player_progress.json', 'r') as progress_file:
    player_progress = json.load(progress_file)

# Initialize game components
game_logic = GameLogic()
main_menu = MainMenu(screen)
game_over = GameOver(screen)
pause_menu = PauseMenu(screen)
upgrade_menu = UpgradeMenu(screen)
level_select = LevelSelect(screen)
tutorial = Tutorial(screen)
hud = HUD(screen)

# Game loop variables
running = True
current_level = player_progress.get('current_level', 1)
score = INITIAL_SCORE
base_health = INITIAL_BASE_HEALTH

# Main game loop
while running:
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            running = False

    # Game logic updates
    game_logic.update()

    # Render updates
    screen.fill((0, 0, 0))  # Clear screen
    hud.render(base_health, score, current_level)
    game_logic.render(screen)

    # Check for game over
    if base_health <= 0:
        game_over.show()
        running = False

    # Check for level completion
    if game_logic.is_level_complete():
        current_level += 1
        if current_level > MAX_LEVEL:
            # Game completed
            running = False
        else:
            # Load next level
            level_data = loadLevel(f'levels/level_{current_level:02}.json')
            game_logic.load_level(level_data)

    pygame.display.flip()  # Update the full display

# Save progress
with open('data/player_progress.json', 'w') as progress_file:
    json.dump({'current_level': current_level, 'score': score}, progress_file)

pygame.quit()
```