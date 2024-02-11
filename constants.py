# Constants for "MathGuardians: The Geometric Frontier" game

# Base Constants
INITIAL_BASE_HEALTH = 100
BASE_WIDTH_DECREASE_ON_HIT = 1  # The amount by which the base width decreases per hit

# Projectile Constants
PROJECTILE_DAMAGE = 10

# Defense Constants
DEFENSE_FORMULAS = {
    'circle': 'x^2 + y^2 = r^2',
    'line': 'y = mx + b',
    # Additional formulas can be added here as the player progresses and unlocks them
}

# Upgrade System Constants
UPGRADE_COSTS = {
    'circle': 100,
    'line': 50,
    # Costs for additional formulas can be added here
}

# Player Progress Constants
PLAYER_PROGRESS = {
    'levels_completed': 0,
    'formulas_unlocked': ['circle', 'line'],
    # Additional progress tracking can be added here
}

# Level Constants
CURRENT_LEVEL = 1
MAX_LEVEL = 10

# Score Constants
INITIAL_SCORE = 0

# GUI Element IDs
BASE_HEALTH_INDICATOR_ID = 'baseHealthIndicator'
SCORE_DISPLAY_ID = 'scoreDisplay'
LEVEL_INDICATOR_ID = 'levelIndicator'
UPGRADE_MENU_ID = 'upgradeMenu'
PAUSE_MENU_ID = 'pauseMenu'
MAIN_MENU_ID = 'mainMenu'
GAME_OVER_SCREEN_ID = 'gameOverScreen'
TUTORIAL_MODAL_ID = 'tutorialModal'

# Message Names
GAME_START = 'GAME_START'
GAME_PAUSE = 'GAME_PAUSE'
GAME_OVER = 'GAME_OVER'
LEVEL_COMPLETE = 'LEVEL_COMPLETE'
UPGRADE_PURCHASED = 'UPGRADE_PURCHASED'
FORMULA_UNLOCKED = 'FORMULA_UNLOCKED'

# Shared Assets (Note: In the context of this game, assets are minimal or procedurally generated)
ENEMY_SPRITE = 'assets/sprites/enemy.png'
ALLY_SPRITE = 'assets/sprites/ally.png'
PROJECTILE_SPRITE = 'assets/sprites/projectile.png'
BASE_SPRITE = 'assets/sprites/base.png'
DEFENSIVE_STRUCTURE_SPRITE = 'assets/sprites/defensive_structure.png'
BACKGROUND_MUSIC = 'assets/sounds/background_music.mp3'
EXPLOSION_SOUND = 'assets/sounds/explosion.wav'
UPGRADE_SOUND = 'assets/sounds/upgrade.wav'
HIT_SOUND = 'assets/sounds/hit.wav'
MAIN_FONT = 'assets/fonts/main_font.ttf'

# Configuration Files
SETTINGS_FILE = 'config/settings.json'

# Shared Data Files
SCOREBOARD_FILE = 'data/scoreboard.json'
PLAYER_PROGRESS_FILE = 'data/player_progress.json'
FORMULA_UNLOCKS_FILE = 'data/formula_unlocks.json'

# Documentation Files
README_FILE = 'README.md'
REQUIREMENTS_FILE = 'requirements.txt'
GITIGNORE_FILE = '.gitignore'