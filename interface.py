import pygame
from constants import GREEN, RED, BLUE, BLACK, WHITE, WIDTH, HEIGHT, FONT

class Interface:
    def __init__(self):
        self.font = pygame.font.Font(FONT, 24)
        self.score = 0
        self.upgrades = {'AD': 0, 'AS': 0, 'ARMOR': 0, 'MAGIC RES': 0, 'ARMOR PEN': 0, 'CRIT': 0, 'HP': 0}
        self.fast_forward = False

    def draw(self, win):
        pygame.draw.rect(win, WHITE, (0, HEIGHT, WIDTH, 100))
        score_text = self.font.render(f'Score: {self.score}', 1, BLACK)
        win.blit(score_text, (10, HEIGHT + 10))

        ff_text = self.font.render('Fast Forward: ON' if self.fast_forward else 'Fast Forward: OFF', 1, BLACK)
        win.blit(ff_text, (WIDTH - 200, HEIGHT + 10))

        for i, (upgrade, level) in enumerate(self.upgrades.items()):
            upgrade_text = self.font.render(f'{upgrade}: {level}', 1, BLACK)
            win.blit(upgrade_text, (10, HEIGHT + 40 + (30 * i)))

    def click(self, pos):
        x, y = pos
        if HEIGHT < y < HEIGHT + 100:
            if WIDTH - 200 < x < WIDTH:
                self.fast_forward = not self.fast_forward
            for i, (upgrade, level) in enumerate(self.upgrades.items()):
                if 10 < x < 200 and HEIGHT + 40 + (30 * i) < y < HEIGHT + 70 + (30 * i):
                    if self.score >= (level + 1) * 10:
                        self.score -= (level + 1) * 10
                        self.upgrades[upgrade] += 1

    def add_score(self, points):
        self.score += points

    def reset(self):
        self.score = 0
        self.upgrades = {'AD': 0, 'AS': 0, 'ARMOR': 0, 'MAGIC RES': 0, 'ARMOR PEN': 0, 'CRIT': 0, 'HP': 0}
        self.fast_forward = False
