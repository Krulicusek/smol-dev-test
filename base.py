class Base:
    def __init__(self, initial_health):
        self.health = initial_health
        self.width = self.calculate_width_from_health(self.health)

    @staticmethod
    def calculate_width_from_health(health):
        # Assuming the width is directly proportional to health
        return health

    def take_damage(self, damage):
        self.health -= damage
        self.width = self.calculate_width_from_health(self.health)
        self.check_destroyed()

    def check_destroyed(self):
        if self.health <= 0:
            self.on_destroyed()

    def on_destroyed(self):
        # Placeholder for game over logic or base destroyed logic
        pass

    def repair(self, repair_amount):
        self.health += repair_amount
        self.width = self.calculate_width_from_health(self.health)

    def upgrade(self, upgrade_amount):
        self.health += upgrade_amount
        self.width = self.calculate_width_from_health(self.health)

    def get_health(self):
        return self.health

    def get_width(self):
        return self.width

# Shared variable from dependencies
INITIAL_BASE_HEALTH = 100

# Example usage
if __name__ == "__main__":
    base = Base(INITIAL_BASE_HEALTH)
    print(f"Initial base health: {base.get_health()}")
    base.take_damage(10)
    print(f"Base health after damage: {base.get_health()}")
    base.repair(5)
    print(f"Base health after repair: {base.get_health()}")
    base.upgrade(20)
    print(f"Base health after upgrade: {base.get_health()}")