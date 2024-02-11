```python
import pygame
from constants import GAME_PAUSE, GAME_START

class PauseMenu:
    def __init__(self, screen, resume_callback, main_menu_callback):
        self.screen = screen
        self.resume_callback = resume_callback
        self.main_menu_callback = main_menu_callback
        self.font = pygame.font.Font(None, 36)
        self.menu_items = ['Resume', 'Main Menu']
        self.selected_item = 0

    def display_menu(self):
        self.screen.fill((0, 0, 0, 128))  # Semi-transparent overlay
        for index, item in enumerate(self.menu_items):
            if index == self.selected_item:
                color = (255, 0, 0)
            else:
                color = (255, 255, 255)
            text_surface = self.font.render(item, True, color)
            self.screen.blit(text_surface, (self.screen.get_width() / 2 - text_surface.get_width() / 2,
                                            self.screen.get_height() / 2 - text_surface.get_height() / 2 + index * 50))

        pygame.display.flip()

    def navigate(self, direction):
        if direction == 'up' and self.selected_item > 0:
            self.selected_item -= 1
        elif direction == 'down' and self.selected_item < len(self.menu_items) - 1:
            self.selected_item += 1

    def select_option(self):
        if self.selected_item == 0:
            self.resume_game()
        elif self.selected_item == 1:
            self.go_to_main_menu()

    def resume_game(self):
        pygame.event.post(pygame.event.Event(pygame.USEREVENT, {'code': GAME_START}))
        self.resume_callback()

    def go_to_main_menu(self):
        pygame.event.post(pygame.event.Event(pygame.USEREVENT, {'code': GAME_PAUSE}))
        self.main_menu_callback()

    def handle_events(self, event):
        if event.type == pygame.KEYDOWN:
            if event.key == pygame.K_UP:
                self.navigate('up')
            elif event.key == pygame.K_DOWN:
                self.navigate('down')
            elif event.key in [pygame.K_RETURN, pygame.K_SPACE]:
                self.select_option()
```