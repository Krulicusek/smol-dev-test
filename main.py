import pygame
from game import Game
from interface import Interface
from constants import SCREEN_WIDTH, SCREEN_HEIGHT

def main():
    pygame.init()
    screen = pygame.display.set_mode((SCREEN_WIDTH, SCREEN_HEIGHT))
    clock = pygame.time.Clock()
    game = Game()
    interface = Interface()

    running = True
    while running:
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                running = False
            elif event.type == pygame.MOUSEBUTTONDOWN:
                pos = pygame.mouse.get_pos()
                if interface.start_button.collidepoint(pos):
                    game.start()
                elif interface.stop_button.collidepoint(pos):
                    game.stop()
                elif interface.fast_forward_button.collidepoint(pos):
                    game.fast_forward()
                else:
                    game.handle_click(pos)

        game.update()
        interface.update(game)

        screen.fill((0, 0, 0))
        game.draw(screen)
        interface.draw(screen)

        pygame.display.flip()
        clock.tick(60)

    pygame.quit()

if __name__ == "__main__":
    main()