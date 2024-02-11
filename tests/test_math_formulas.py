import unittest
from math_formulas import create_circle, create_wall

class TestMathFormulas(unittest.TestCase):

    def test_create_circle(self):
        # Test creating a circle with a given radius
        radius = 5
        expected_formula = 'x^2 + y^2 = 25'
        circle_formula = create_circle(radius)
        self.assertEqual(circle_formula, expected_formula, "The circle formula is incorrect.")

    def test_create_wall(self):
        # Test creating a wall with a given y-intercept
        y_intercept = 5
        expected_formula = 'y = 5'
        wall_formula = create_wall(y_intercept)
        self.assertEqual(wall_formula, expected_formula, "The wall formula is incorrect.")

    def test_circle_hit(self):
        # Test the circle's width reduction when hit
        circle_formula = 'x^2 + y^2 = 25'
        hit_damage = 1
        expected_formula_after_hit = 'x^2 + y^2 = 24'
        new_circle_formula = create_circle(5 - hit_damage)
        self.assertEqual(new_circle_formula, expected_formula_after_hit, "The circle formula after hit is incorrect.")

    def test_wall_hit(self):
        # Test the wall's durability reduction when hit
        wall_formula = 'y = 5'
        hit_damage = 1
        expected_formula_after_hit = 'y = 4'
        new_wall_formula = create_wall(5 - hit_damage)
        self.assertEqual(new_wall_formula, expected_formula_after_hit, "The wall formula after hit is incorrect.")

if __name__ == '__main__':
    unittest.main()