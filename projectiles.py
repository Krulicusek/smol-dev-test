```python
import random
from math import sqrt
from utils import calculateDistance
from constants import PROJECTILE_DAMAGE, BASE_HEALTH

class Projectile:
    def __init__(self, x, y, velocity, angle):
        self.x = x
        self.y = y
        self.velocity = velocity
        self.angle = angle
        self.damage = PROJECTILE_DAMAGE

    def move(self):
        # Update the projectile's position based on its velocity and angle
        self.x += self.velocity * cos(self.angle)
        self.y += self.velocity * sin(self.angle)

    def check_collision(self, base):
        # Check if the projectile has collided with the base
        distance_to_base = calculateDistance((self.x, self.y), (base.x, base.y))
        if distance_to_base <= base.radius:
            return True
        return False

    def apply_damage(self, base):
        # Apply damage to the base if there is a collision
        if self.check_collision(base):
            base.health -= self.damage
            if base.health < 0:
                base.health = 0
            return True
        return False

class ProjectileSpawner:
    def __init__(self, spawn_rate, max_projectiles):
        self.spawn_rate = spawn_rate
        self.max_projectiles = max_projectiles
        self.projectiles = []

    def spawn_projectile(self):
        if len(self.projectiles) < self.max_projectiles:
            # Randomly generate the position and angle for the new projectile
            x = random.randint(0, 800)  # Assuming a window width of 800 for example
            y = random.randint(0, 600)  # Assuming a window height of 600 for example
            velocity = random.uniform(1, 5)
            angle = random.uniform(0, 2 * pi)
            new_projectile = Projectile(x, y, velocity, angle)
            self.projectiles.append(new_projectile)

    def update_projectiles(self, base):
        # Move each projectile and check for collisions
        for projectile in self.projectiles:
            projectile.move()
            if projectile.apply_damage(base):
                self.projectiles.remove(projectile)

    def run_spawner(self, base):
        # Spawn and update projectiles at the defined spawn rate
        if random.random() < self.spawn_rate:
            self.spawn_projectile()
        self.update_projectiles(base)
```