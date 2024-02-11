```python
import tkinter as tk
from tkinter import messagebox

def show_game_over_screen(score, restart_callback, exit_callback):
    """
    Display the game over screen with the final score and options to restart or exit the game.
    
    :param score: The final score of the player.
    :param restart_callback: Function to call when the player chooses to restart the game.
    :param exit_callback: Function to call when the player chooses to exit the game.
    """
    game_over_root = tk.Tk()
    game_over_root.title("Game Over")

    # Center the window on the screen
    window_width = 300
    window_height = 200
    screen_width = game_over_root.winfo_screenwidth()
    screen_height = game_over_root.winfo_screenheight()
    center_x = int(screen_width/2 - window_width / 2)
    center_y = int(screen_height/2 - window_height / 2)
    game_over_root.geometry(f'{window_width}x{window_height}+{center_x}+{center_y}')

    # Disable window resize
    game_over_root.resizable(False, False)

    # Game Over message
    label_game_over = tk.Label(game_over_root, text="Game Over", font=("Helvetica", 24))
    label_game_over.pack(pady=(20, 10))

    # Display final score
    label_score = tk.Label(game_over_root, text=f"Your Score: {score}", font=("Helvetica", 16))
    label_score.pack()

    # Restart button
    button_restart = tk.Button(game_over_root, text="Restart", command=lambda: restart_game(game_over_root, restart_callback))
    button_restart.pack(pady=(20, 5), fill='x', padx=50)

    # Exit button
    button_exit = tk.Button(game_over_root, text="Exit", command=lambda: exit_game(game_over_root, exit_callback))
    button_exit.pack(pady=(5, 20), fill='x', padx=50)

    game_over_root.mainloop()

def restart_game(root, restart_callback):
    """
    Handle the restart game action.
    
    :param root: The Tk root window.
    :param restart_callback: The callback function to restart the game.
    """
    root.destroy()
    restart_callback()

def exit_game(root, exit_callback):
    """
    Handle the exit game action.
    
    :param root: The Tk root window.
    :param exit_callback: The callback function to exit the game.
    """
    if messagebox.askokcancel("Exit", "Do you really wish to exit?"):
        root.destroy()
        exit_callback()

# Example usage:
# show_game_over_screen(1234, restart_callback=initGame, exit_callback=quit)
```