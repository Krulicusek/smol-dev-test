```python
class Map:
    def __init__(self, lanes, central_area, bases):
        self.lanes = lanes
        self.central_area = central_area
        self.bases = bases

    def create_map(self):
        # Create a map with lanes, a central area, and bases at opposite ends
        self.map_layout = {
            "lanes": self.lanes,
            "central_area": self.central_area,
            "bases": self.bases
        }
        return self.map_layout

    def get_map_layout(self):
        # Return the current map layout
        return self.map_layout

    def update_map(self, new_layout):
        # Update the map layout
        self.map_layout = new_layout

    def get_lane(self, lane_id):
        # Return a specific lane based on its ID
        return self.map_layout["lanes"][lane_id]

    def get_base(self, base_id):
        # Return a specific base based on its ID
        return self.map_layout["bases"][base_id]

    def get_central_area(self):
        # Return the central area of the map
        return self.map_layout["central_area"]
```