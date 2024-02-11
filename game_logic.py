```python
import random
from base import Base
from defenses import DefenseManager
from projectiles import ProjectileManager
from math_formulas import MathFormulas
from upgrade_system import UpgradeSystem
from educational_element import EducationalElement
from utils import calculateDistance, isCollision
from constants import BASE_HEALTH, PROJECTILE_DAMAGE, DEFENSE_FORMULAS, PLAYER_PROGRESS, CURRENT_LEVEL, SCORE

class GameLogic:
    def __init__(self):
        self.base = Base(BASE_HEALTH)
        self.defense_manager = DefenseManager()
        self.projectile_manager = ProjectileManager(PROJECTILE_DAMAGE)
        self.math_formulas = MathFormulas()
        self.upgrade_system = UpgradeSystem()
        self.educational_element = EducationalElement()
        self.score = SCORE
        self.current_level = CURRENT_LEVEL
        self.player_progress = PLAYER_PROGRESS
        self.game_over = False

    def init_game(self):
        self.base.reset_health()
        self.defense_manager.clear_defenses()
        self.projectile_manager.clear_projectiles()
        self.score = INITIAL_SCORE
        self.current_level = 1
        self.game_over = False
        self.load_level(self.current_level)

    def update(self):
        self.projectile_manager.move_projectiles()
        self.check_collisions()
        self.defense_manager.update_defenses()
        self.check_base_health()

    def check_collisions(self):
        for projectile in self.projectile_manager.projectiles:
            if isCollision(projectile, self.base):
                self.base.take_damage(projectile.damage)
                self.projectile_manager.remove_projectile(projectile)
            else:
                for defense in self.defense_manager.defenses:
                    if isCollision(projectile, defense):
                        defense.take_damage(projectile.damage)
                        self.projectile_manager.remove_projectile(projectile)
                        break

    def check_base_health(self):
        if self.base.health <= 0:
            self.game_over = True
            self.trigger_game_over()

    def trigger_game_over(self):
        # Handle game over logic, such as saving scores, showing game over screen, etc.
        pass

    def spawn_projectile(self, type, damage):
        self.projectile_manager.spawn_projectile(type, damage)

    def create_defense(self, formula):
        if formula in self.math_formulas.unlocked_formulas:
            self.defense_manager.create_defense(formula)

    def apply_upgrade(self, upgrade_type):
        self.upgrade_system.apply_upgrade(upgrade_type, self.defense_manager.defenses)

    def load_level(self, level_data):
        # Load level configuration from level_data
        pass

    def save_progress(self):
        # Save the player's progress to a file or database
        pass

    def update_score(self, new_score):
        self.score += new_score
        # Update the scoreboard with the new score

    def show_tutorial(self, tip):
        self.educational_element.show_tip(tip)

# Example usage
game_logic = GameLogic()
game_logic.init_game()
while not game_logic.game_over:
    game_logic.update()
```