```python
import tkinter as tk
from tkinter import messagebox

class EducationalTips:
    def __init__(self, root):
        self.root = root
        self.tips = {
            "base": "Your base is a circle. Its health is proportional to its radius. Protect it!",
            "math_defense": "Use equations like x^2 + y^2 = r^2 to create circular defenses.",
            "learn_play": "New formulas will be unlocked as you progress. Use them wisely!",
            "upgrade_system": "Upgrade your defenses by enhancing their mathematical properties.",
            "strategic_challenges": "Each projectile type requires a different defense strategy.",
            "educational_element": "Learn mathematical concepts while playing and apply them to improve your defenses.",
            "visualize_math": "Watch your mathematical defenses come to life and protect your base.",
            "endless_creativity": "Experiment with different formulas to create the most effective defense patterns."
        }
        self.current_tip = tk.StringVar(value="Welcome to MathGuardians! Click 'Next Tip' to learn more.")
        self.create_widgets()

    def create_widgets(self):
        self.tip_label = tk.Label(self.root, textvariable=self.current_tip, wraplength=300, justify="left")
        self.tip_label.pack(pady=10)

        self.next_tip_button = tk.Button(self.root, text="Next Tip", command=self.next_tip)
        self.next_tip_button.pack(pady=5)

    def next_tip(self):
        current_tip_key = next(iter(self.tips))  # Get the first key from the dictionary
        current_tip_value = self.tips.pop(current_tip_key)  # Remove it to cycle through tips
        self.current_tip.set(current_tip_value)
        self.tips[current_tip_key] = current_tip_value  # Add it back to the end

    def show_tip(self, tip_key):
        if tip_key in self.tips:
            self.current_tip.set(self.tips[tip_key])
        else:
            messagebox.showerror("Error", "Tip not found.")

# Example usage:
# root = tk.Tk()
# educational_tips = EducationalTips(root)
# root.mainloop()
```