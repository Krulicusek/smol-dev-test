import unittest
from upgrade_system import applyUpgrade
from base import Base
from defenses import Defense

class TestUpgradeSystem(unittest.TestCase):

    def setUp(self):
        self.base = Base(initial_health=100)
        self.defense = Defense(formula='x^2 + y^2 = r^2', health=50)

    def test_apply_upgrade_to_base(self):
        initial_health = self.base.health
        applyUpgrade(upgradeType='baseHealth', target=self.base)
        self.assertTrue(self.base.health > initial_health, "Base health should increase after upgrade.")

    def test_apply_upgrade_to_defense(self):
        initial_health = self.defense.health
        applyUpgrade(upgradeType='defenseHealth', target=self.defense)
        self.assertTrue(self.defense.health > initial_health, "Defense health should increase after upgrade.")

    def test_upgrade_costs(self):
        initial_base_health = self.base.health
        applyUpgrade(upgradeType='baseHealth', target=self.base)
        self.assertEqual(self.base.upgrade_cost, UPGRADE_COSTS['baseHealth'], "Upgrade cost for base health should match predefined costs.")

        initial_defense_health = self.defense.health
        applyUpgrade(upgradeType='defenseHealth', target=self.defense)
        self.assertEqual(self.defense.upgrade_cost, UPGRADE_COSTS['defenseHealth'], "Upgrade cost for defense health should match predefined costs.")

    def test_invalid_upgrade_type(self):
        with self.assertRaises(ValueError):
            applyUpgrade(upgradeType='invalidType', target=self.base)

    def test_upgrade_without_target(self):
        with self.assertRaises(TypeError):
            applyUpgrade(upgradeType='baseHealth')

if __name__ == '__main__':
    unittest.main()