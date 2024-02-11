```python
import json
from gui.tutorial import showTutorial

# Load educational tips and formulas from a JSON file
def load_educational_content():
    with open('data/formula_unlocks.json', 'r') as file:
        content = json.load(file)
    return content

# Display an educational tip based on the player's progress
def display_educational_tip(player_progress):
    educational_content = load_educational_content()
    current_level = player_progress['current_level']
    if str(current_level) in educational_content:
        tip = educational_content[str(current_level)]['tip']
        showTutorial(tip)

# Unlock a new mathematical formula for the player
def unlock_formula(player_progress):
    educational_content = load_educational_content()
    current_level = player_progress['current_level']
    if str(current_level) in educational_content:
        new_formula = educational_content[str(current_level)]['formula']
        player_progress['unlocked_formulas'].append(new_formula)
        save_player_progress(player_progress)
        return new_formula
    return None

# Save the player's progress to a JSON file
def save_player_progress(player_progress):
    with open('data/player_progress.json', 'w') as file:
        json.dump(player_progress, file, indent=4)

# Initialize educational content for a new player
def initialize_educational_content():
    educational_content = {
        "1": {
            "tip": "Did you know that the area of a circle is π times the radius squared?",
            "formula": "πr^2"
        },
        # Additional levels and tips can be added here
    }
    with open('data/formula_unlocks.json', 'w') as file:
        json.dump(educational_content, file, indent=4)

# Call this function when the game starts for the first time
# initialize_educational_content()
```