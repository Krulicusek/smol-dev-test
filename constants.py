# constants.py

import pygame

# Colors
GREEN = (0, 255, 0)
RED = (255, 0, 0)
BLUE = (0, 0, 255)
BLACK = (0, 0, 0)

# Game settings
SCREEN_WIDTH = 800
SCREEN_HEIGHT = 600
FPS = 60

# Tower settings
TOWER_WIDTH = 50
TOWER_HEIGHT = 50
TOWER_DAMAGE = 10
TOWER_ATTACK_SPEED = 1.0
TOWER_RANGE = 100

# Enemy settings
ENEMY_WIDTH = 30
ENEMY_HEIGHT = 30
ENEMY_SPEED = 2
ENEMY_HEALTH = 100

# Upgrade settings
UPGRADE_COST = 100
UPGRADE_AD = 10
UPGRADE_AS = 0.1
UPGRADE_ARMOR = 10
UPGRADE_MAGIC_RES = 10
UPGRADE_ARMOR_PEN = 10
UPGRADE_CRIT = 0.05
UPGRADE_HP = 10

# Points per kill
POINTS_PER_KILL = 10

# Asset paths
ASSET_GREEN_TOWER = "assets/rectangle_green.png"
ASSET_RED_TOWER = "assets/rectangle_red.png"
ASSET_BLUE_TOWER = "assets/rectangle_blue.png"
ASSET_BLACK_ENEMY = "assets/rectangle_black.png"