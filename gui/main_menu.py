```python
import pygame
import sys
from game_logic import initGame
from constants import MAX_LEVEL, PLAYER_PROGRESS

# Initialize the main menu of the game
class MainMenu:
    def __init__(self, screen):
        self.screen = screen
        self.font = pygame.font.Font('assets/fonts/main_font.ttf', 30)
        self.running = True
        self.load_player_progress()

    def load_player_progress(self):
        try:
            with open('data/player_progress.json', 'r') as file:
                self.player_progress = json.load(file)
        except FileNotFoundError:
            self.player_progress = {'current_level': 1, 'formulas_unlocked': []}

    def display_menu(self):
        self.screen.fill((0, 0, 0))  # Fill the screen with black
        title_text = self.font.render('MathGuardians: The Geometric Frontier', True, (255, 255, 255))
        start_text = self.font.render('Start Game', True, (255, 255, 255))
        quit_text = self.font.render('Quit Game', True, (255, 255, 255))

        title_rect = title_text.get_rect(center=(self.screen.get_width()/2, 100))
        start_rect = start_text.get_rect(center=(self.screen.get_width()/2, 250))
        quit_rect = quit_text.get_rect(center=(self.screen.get_width()/2, 300))

        self.screen.blit(title_text, title_rect)
        self.screen.blit(start_text, start_rect)
        self.screen.blit(quit_text, quit_rect)

        pygame.display.update()

        while self.running:
            for event in pygame.event.get():
                if event.type == pygame.QUIT:
                    self.running = False
                    pygame.quit()
                    sys.exit()
                if event.type == pygame.MOUSEBUTTONDOWN:
                    if start_rect.collidepoint(pygame.mouse.get_pos()):
                        self.start_game()
                    elif quit_rect.collidepoint(pygame.mouse.get_pos()):
                        self.running = False
                        pygame.quit()
                        sys.exit()

    def start_game(self):
        initGame(self.player_progress['current_level'])

# Main function to run the main menu
def run_main_menu():
    pygame.init()
    screen = pygame.display.set_mode((800, 600))
    pygame.display.set_caption('MathGuardians: The Geometric Frontier')
    main_menu = MainMenu(screen)
    main_menu.display_menu()

if __name__ == '__main__':
    run_main_menu()
```