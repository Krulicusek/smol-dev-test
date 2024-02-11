import unittest
from visualization import renderVisualization
from math_formulas import convertFormulaToPath

class TestVisualization(unittest.TestCase):

    def test_render_circle_visualization(self):
        # Test rendering a circle visualization
        formula = "x^2 + y^2 = r^2"
        path = convertFormulaToPath(formula)
        visualization = renderVisualization(path)
        self.assertIsNotNone(visualization, "Failed to render circle visualization")

    def test_render_line_visualization(self):
        # Test rendering a line visualization
        formula = "y=5"
        path = convertFormulaToPath(formula)
        visualization = renderVisualization(path)
        self.assertIsNotNone(visualization, "Failed to render line visualization")

    def test_render_complex_visualization(self):
        # Test rendering a complex visualization
        formula = "y = sin(x)"
        path = convertFormulaToPath(formula)
        visualization = renderVisualization(path)
        self.assertIsNotNone(visualization, "Failed to render complex visualization")

    def test_visualization_integrity(self):
        # Test the integrity of the visualization (e.g., no missing parts)
        formula = "x^2 + y^2 = r^2"
        path = convertFormulaToPath(formula)
        visualization = renderVisualization(path)
        # This is a placeholder for a more complex integrity check
        self.assertTrue(isinstance(visualization, str), "Visualization integrity check failed")

# This allows the test to be run from the command line
if __name__ == '__main__':
    unittest.main()