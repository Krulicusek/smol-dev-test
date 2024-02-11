```python
import unittest
from game_logic import updateHealth, spawnProjectile, calculateDamage
from base import Base
from projectiles import Projectile
from defenses import Defense

class TestGameLogic(unittest.TestCase):

    def setUp(self):
        self.base = Base(INITIAL_BASE_HEALTH)
        self.projectile = Projectile(PROJECTILE_DAMAGE)
        self.defense = Defense(DEFENSE_FORMULAS['circle'])

    def test_update_health(self):
        initial_health = self.base.health
        damage = 10
        updateHealth(self.base.health - damage)
        self.assertEqual(self.base.health, initial_health - damage, "Base health should decrease by the damage amount")

    def test_spawn_projectile(self):
        projectile_type = 'basic'
        damage = PROJECTILE_DAMAGE
        new_projectile = spawnProjectile(projectile_type, damage)
        self.assertIsInstance(new_projectile, Projectile, "Should create an instance of Projectile")
        self.assertEqual(new_projectile.damage, damage, "Projectile damage should be set correctly")

    def test_calculate_damage(self):
        self.base.health = 100
        projectile_damage = self.projectile.damage
        calculateDamage(self.projectile, self.defense)
        self.assertTrue(self.base.health < 100, "Base health should decrease when hit by a projectile")
        self.assertEqual(self.base.health, 100 - projectile_damage, "Base health should decrease by the projectile's damage")

    def test_defense_creation(self):
        formula = DEFENSE_FORMULAS['circle']
        defense = createDefense(formula)
        self.assertIsInstance(defense, Defense, "Should create an instance of Defense")
        self.assertEqual(defense.formula, formula, "Defense formula should be set correctly")

    def test_upgrade_defense(self):
        initial_health = self.defense.health
        upgrade_amount = 20
        self.defense.upgrade(upgrade_amount)
        self.assertEqual(self.defense.health, initial_health + upgrade_amount, "Defense health should increase by the upgrade amount")

if __name__ == '__main__':
    unittest.main()
```