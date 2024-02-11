```python
import json
from tkinter import Tk, Button, Label, Frame

class LevelSelect:
    def __init__(self, master):
        self.master = master
        self.master.title("MathGuardians: Level Select")
        self.frame = Frame(self.master)
        self.frame.pack()

        self.level_buttons = []
        self.load_levels()
        self.display_levels()

    def load_levels(self):
        with open('levels/level_01.json', 'r') as level_file:
            self.level_01_data = json.load(level_file)
        with open('levels/level_02.json', 'r') as level_file:
            self.level_02_data = json.load(level_file)
        with open('levels/level_03.json', 'r') as level_file:
            self.level_03_data = json.load(level_file)
        self.levels = [self.level_01_data, self.level_02_data, self.level_03_data]

    def display_levels(self):
        for index, level in enumerate(self.levels):
            level_button = Button(self.frame, text=f"Level {index + 1}", command=lambda lvl=level: self.select_level(lvl))
            level_button.pack()
            self.level_buttons.append(level_button)

    def select_level(self, level_data):
        # This function will be responsible for loading the selected level
        # For now, it just prints the level data to the console
        print(f"Selected level: {level_data['name']}")
        # Here you would typically call a function like loadLevel(level_data)
        # from the game_logic.py file to actually start the level

def main():
    root = Tk()
    app = LevelSelect(root)
    root.mainloop()

if __name__ == "__main__":
    main()
```