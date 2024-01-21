import pygame
from constants import BLACK, ENEMY_SPEED, ENEMY_HP

class Enemy:
    def __init__(self, path):
        self.image = pygame.image.load('assets/rectangle_black.png')
        self.rect = self.image.get_rect()
        self.path = path
        self.current_path_index = 0
        self.speed = ENEMY_SPEED
        self.hp = ENEMY_HP
        self.color = BLACK

    def move(self):
        if self.current_path_index < len(self.path):
            target_position = self.path[self.current_path_index]
            target_x, target_y = target_position

            dx = target_x - self.rect.x
            dy = target_y - self.rect.y

            distance = (dx**2 + dy**2)**0.5
            if distance:
                self.rect.x += self.speed * dx / distance
                self.rect.y += self.speed * dy / distance

                if dx < 0 and self.rect.x < target_x or dx > 0 and self.rect.x > target_x:
                    self.rect.x = target_x
                if dy < 0 and self.rect.y < target_y or dy > 0 and self.rect.y > target_y:
                    self.rect.y = target_y

                if self.rect.x == target_x and self.rect.y == target_y:
                    self.current_path_index += 1

    def draw(self, screen):
        screen.blit(self.image, self.rect)

    def take_damage(self, damage):
        self.hp -= damage
        if self.hp <= 0:
            return True
        return False