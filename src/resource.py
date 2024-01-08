```python
class Resource:
    def __init__(self):
        self.player_resources = {
            "gold": 1000,
            "gems": 10,
            "elixir": 500
        }

    def update_resources(self, resource_type, amount):
        if resource_type in self.player_resources:
            self.player_resources[resource_type] += amount
            return True
        return False

    def get_resources(self):
        return self.player_resources

    def spend_resources(self, resource_type, amount):
        if resource_type in self.player_resources and self.player_resources[resource_type] >= amount:
            self.player_resources[resource_type] -= amount
            return True
        return False

    def check_resource_availability(self, resource_type, amount):
        if resource_type in self.player_resources and self.player_resources[resource_type] >= amount:
            return True
        return False
```