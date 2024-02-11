```python
import unittest
from projectiles import Projectile
from utils import calculateDistance

class TestProjectiles(unittest.TestCase):
    def setUp(self):
        self.projectile = Projectile(type='basic', damage=PROJECTILE_DAMAGE, speed=5, direction=(1, 0))

    def test_projectile_creation(self):
        self.assertEqual(self.projectile.type, 'basic')
        self.assertEqual(self.projectile.damage, PROJECTILE_DAMAGE)
        self.assertEqual(self.projectile.speed, 5)
        self.assertEqual(self.projectile.direction, (1, 0))

    def test_projectile_movement(self):
        initial_position = self.projectile.position
        self.projectile.move()
        new_position = self.projectile.position
        self.assertNotEqual(initial_position, new_position)
        self.assertEqual(calculateDistance(initial_position, new_position), self.projectile.speed)

    def test_projectile_damage(self):
        base_health_before = BASE_HEALTH
        self.projectile.hit()
        base_health_after = BASE_HEALTH
        self.assertEqual(base_health_before - base_health_after, self.projectile.damage)

    def test_projectile_collision(self):
        defense_position = (10, 10)
        self.projectile.position = defense_position
        collision = self.projectile.check_collision(defense_position)
        self.assertTrue(collision)

if __name__ == '__main__':
    unittest.main()
```