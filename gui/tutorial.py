```python
import tkinter as tk
from tkinter import messagebox

class Tutorial:
    def __init__(self, root):
        self.root = root
        self.tutorial_window = None
        self.create_tutorial_window()

    def create_tutorial_window(self):
        self.tutorial_window = tk.Toplevel(self.root)
        self.tutorial_window.title("Tutorial")
        self.tutorial_window.geometry("400x300")
        self.tutorial_window.resizable(False, False)

        tutorial_text = (
            "Welcome to MathGuardians: The Geometric Frontier!\n\n"
            "In this game, your goal is to protect the central circle, your base, "
            "from incoming projectiles using mathematical defenses.\n\n"
            "Defenses are created by entering mathematical formulas. For example:\n"
            " - Enter 'x^2 + y^2 = r^2' to create a circular barrier.\n"
            " - Enter 'y=5' to create a horizontal wall.\n\n"
            "As you progress, you'll unlock new formulas and face more complex challenges. "
            "Use strategic thinking and your knowledge of geometry to survive.\n\n"
            "Good luck, and enjoy the geometric journey!"
        )

        tutorial_label = tk.Label(self.tutorial_window, text=tutorial_text, justify=tk.LEFT)
        tutorial_label.pack(padx=10, pady=10)

        close_button = tk.Button(self.tutorial_window, text="Close", command=self.close_tutorial)
        close_button.pack(pady=10)

    def show_tutorial(self):
        self.tutorial_window.deiconify()

    def close_tutorial(self):
        self.tutorial_window.destroy()

    @staticmethod
    def show_tutorial_tip(tip):
        messagebox.showinfo("Tutorial Tip", tip)

# Example usage:
# root = tk.Tk()
# tutorial = Tutorial(root)
# tutorial.show_tutorial()
# root.mainloop()
```