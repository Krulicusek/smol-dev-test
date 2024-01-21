import pygame
from constants import GREEN, RED, BLUE, BLACK
from upgrade import Upgrade

class Tower:
    def __init__(self, x, y, color):
        self.x = x
        self.y = y
        self.color = color
        self.upgrades = {
            'AD': Upgrade('AD'),
            'AS': Upgrade('AS'),
            'ARMOR': Upgrade('ARMOR'),
            'MAGIC_RES': Upgrade('MAGIC_RES'),
            'ARMOR_PEN': Upgrade('ARMOR_PEN'),
            'CRIT': Upgrade('CRIT'),
            'HP': Upgrade('HP')
        }
        self.image = None
        if color == GREEN:
            self.image = pygame.image.load('assets/rectangle_green.png')
        elif color == RED:
            self.image = pygame.image.load('assets/rectangle_red.png')
        elif color == BLUE:
            self.image = pygame.image.load('assets/rectangle_blue.png')

    def draw(self, window):
        window.blit(self.image, (self.x, self.y))

    def upgrade(self, upgrade_type):
        if upgrade_type in self.upgrades:
            self.upgrades[upgrade_type].level_up()

    def attack(self, enemy):
        if self.color == GREEN:
            damage = self.upgrades['AD'].get_value()
            enemy.take_damage(damage)
        elif self.color == RED:
            damage = self.upgrades['MAGIC_RES'].get_value()
            enemy.take_magic_damage(damage)
        elif self.color == BLUE:
            damage = self.upgrades['ARMOR_PEN'].get_value()
            enemy.take_armor_pen_damage(damage)

    def get_upgrade_cost(self, upgrade_type):
        if upgrade_type in self.upgrades:
            return self.upgrades[upgrade_type].get_cost()