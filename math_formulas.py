```python
import math

# Shared Dependencies
from constants import DEFENSE_FORMULAS

class MathFormulas:
    @staticmethod
    def circle_formula(x, y, r):
        """
        Represents the formula for a circle with radius r.
        x^2 + y^2 = r^2
        """
        return x**2 + y**2 == r**2

    @staticmethod
    def horizontal_line(y, line_y):
        """
        Represents the formula for a horizontal line at y = line_y.
        """
        return y == line_y

    @staticmethod
    def vertical_line(x, line_x):
        """
        Represents the formula for a vertical line at x = line_x.
        """
        return x == line_x

    @staticmethod
    def line_slope_intercept(x, slope, intercept):
        """
        Represents the formula for a line in slope-intercept form.
        y = mx + b
        """
        return slope * x + intercept

    @staticmethod
    def parabola(x, a, b, c):
        """
        Represents the formula for a parabola.
        y = ax^2 + bx + c
        """
        return a * x**2 + b * x + c

    @staticmethod
    def ellipse(x, y, a, b):
        """
        Represents the formula for an ellipse with radii a and b.
        (x^2 / a^2) + (y^2 / b^2) = 1
        """
        return (x**2 / a**2) + (y**2 / b**2) == 1

    @staticmethod
    def distance_between_points(x1, y1, x2, y2):
        """
        Calculate the distance between two points (x1, y1) and (x2, y2).
        """
        return math.sqrt((x2 - x1)**2 + (y2 - y1)**2)

    @staticmethod
    def is_point_inside_circle(px, py, cx, cy, r):
        """
        Check if a point (px, py) is inside a circle centered at (cx, cy) with radius r.
        """
        return MathFormulas.distance_between_points(px, py, cx, cy) <= r

    @staticmethod
    def is_point_on_line(px, py, line_formula):
        """
        Check if a point (px, py) is on the line described by the line_formula.
        """
        return line_formula(px, py)

    @staticmethod
    def get_defense_formula(formula_name):
        """
        Retrieve a defense formula by name from the DEFENSE_FORMULAS collection.
        """
        return DEFENSE_FORMULAS.get(formula_name, None)

# Example usage:
# Check if a point is inside a circle
# inside = MathFormulas.is_point_inside_circle(1, 1, 0, 0, 5)

# Check if a point is on a line
# on_line = MathFormulas.is_point_on_line(2, 3, MathFormulas.horizontal_line)
```