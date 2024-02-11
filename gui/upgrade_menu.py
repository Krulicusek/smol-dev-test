```python
import tkinter as tk
from tkinter import messagebox
from upgrade_system import applyUpgrade
from constants import UPGRADE_COSTS, PLAYER_PROGRESS
from data.player_progress import PlayerProgress

class UpgradeMenu:
    def __init__(self, root):
        self.root = root
        self.upgrade_window = tk.Toplevel(root)
        self.upgrade_window.title("Upgrade Menu")
        self.upgrade_window.geometry("400x300")
        self.player_progress = PlayerProgress.load(PLAYER_PROGRESS)

        self.create_widgets()

    def create_widgets(self):
        tk.Label(self.upgrade_window, text="Select an upgrade to purchase:").pack(pady=10)

        for formula, cost in UPGRADE_COSTS.items():
            button = tk.Button(self.upgrade_window, text=f"{formula} - {cost} points", command=lambda f=formula: self.purchase_upgrade(f))
            button.pack()

        self.back_button = tk.Button(self.upgrade_window, text="Back", command=self.upgrade_window.destroy)
        self.back_button.pack(pady=10)

    def purchase_upgrade(self, formula):
        if self.player_progress.score >= UPGRADE_COSTS[formula]:
            applyUpgrade(formula)
            self.player_progress.score -= UPGRADE_COSTS[formula]
            self.player_progress.save()
            messagebox.showinfo("Upgrade Purchased", f"You have successfully purchased the {formula} upgrade!")
        else:
            messagebox.showerror("Insufficient Points", "You do not have enough points to purchase this upgrade.")

    @staticmethod
    def show(root):
        UpgradeMenu(root)

# Example usage:
# root = tk.Tk()
# upgrade_menu = UpgradeMenu(root)
# root.mainloop()
```
