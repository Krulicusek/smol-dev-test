import pygame
from tower import Tower
from enemy import Enemy
from interface import Interface
from upgrade import Upgrade
from constants import *

class Game:
    def __init__(self):
        self.state = 'stopped'
        self.score = 0
        self.towers = []
        self.enemies = []
        self.upgrades = []
        self.interface = Interface()
        self.fast_forward = False

    def start(self):
        self.state = 'running'
        self.score = 0
        self.towers = [Tower(GREEN), Tower(RED), Tower(BLUE)]
        self.enemies = [Enemy(BLACK) for _ in range(10)]
        self.upgrades = [Upgrade('AD'), Upgrade('AS'), Upgrade('ARMOR'), Upgrade('MAGIC RES'), Upgrade('ARMOR PEN'), Upgrade('CRIT'), Upgrade('HP')]

    def stop(self):
        self.state = 'stopped'

    def handle_click(self, pos):
        for tower in self.towers:
            if tower.rect.collidepoint(pos):
                tower.upgrade(self.upgrades)
        for upgrade in self.upgrades:
            if upgrade.rect.collidepoint(pos):
                upgrade.apply(self.towers)

    def update(self):
        if self.state == 'running':
            for enemy in self.enemies:
                enemy.move()
                if enemy.reached_end:
                    self.stop()
                for tower in self.towers:
                    if tower.in_range(enemy):
                        tower.attack(enemy)
                        if enemy.hp <= 0:
                            self.score += POINTS_PER_KILL
                            self.enemies.remove(enemy)
            if self.fast_forward:
                self.update()

    def draw(self, screen):
        for tower in self.towers:
            tower.draw(screen)
        for enemy in self.enemies:
            enemy.draw(screen)
        self.interface.draw(screen, self.score, self.state)

    def toggle_fast_forward(self):
        self.fast_forward = not self.fast_forward
