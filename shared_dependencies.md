1. Exported Variables:
    - `snake`: The object representing the snake in the game.
    - `score`: The current score of the game.
    - `gameState`: The current state of the game (e.g., "start", "playing", "game over").

2. Data Schemas:
    - `Player`: Schema for player data, including player ID and score.
    - `Game`: Schema for game data, including game state, snake data, and score.

3. ID Names of DOM Elements:
    - `game-board`: The main game area where the snake moves.
    - `score-board`: The area where the score is displayed.
    - `start-button`: The button to start the game.
    - `restart-button`: The button to restart the game after game over.

4. Message Names:
    - `playerJoined`: Message sent when a new player joins the game.
    - `gameStart`: Message sent when the game starts.
    - `gameOver`: Message sent when the game is over.
    - `scoreUpdate`: Message sent when the score is updated.

5. Function Names:
    - `startGame()`: Function to start the game.
    - `endGame()`: Function to end the game.
    - `updateScore()`: Function to update the score.
    - `moveSnake()`: Function to move the snake.
    - `addSegment()`: Function to add a segment to the snake.
    - `playerJoin()`: Function to handle a player joining the game.
    - `sendAlert()`: Function to send alerts to the player.