```python
import unittest
from selenium import webdriver
from selenium.webdriver.common.keys import Keys

class EndToEndTests(unittest.TestCase):

    def setUp(self):
        self.driver = webdriver.Firefox()

    def test_game_flow(self):
        driver = self.driver
        driver.get("http://localhost:8000")
        self.assertIn("Tower Defense Hybrid", driver.title)

        # Test map loading
        map_element = driver.find_element_by_id("map")
        self.assertIsNotNone(map_element)

        # Test base building
        base_element = driver.find_element_by_id("base")
        base_element.click()
        self.assertEqual(base_element.get_attribute('class'), 'base upgraded')

        # Test unit wave spawning
        unit_element = driver.find_element_by_id("unit")
        unit_element.click()
        self.assertEqual(unit_element.get_attribute('class'), 'unit spawned')

        # Test resource management
        resource_element = driver.find_element_by_id("resource")
        self.assertEqual(resource_element.text, '100')

        # Test tower placement
        tower_element = driver.find_element_by_id("tower")
        tower_element.click()
        self.assertEqual(tower_element.get_attribute('class'), 'tower placed')

        # Test champion control
        champion_element = driver.find_element_by_id("champion")
        champion_element.click()
        self.assertEqual(champion_element.get_attribute('class'), 'champion active')

        # Test augment system
        augment_element = driver.find_element_by_id("augment")
        augment_element.click()
        self.assertEqual(augment_element.get_attribute('class'), 'augment active')

        # Test winning condition
        self.assertIn("Victory", driver.page_source)

    def tearDown(self):
        self.driver.close()

if __name__ == "__main__":
    unittest.main()
```