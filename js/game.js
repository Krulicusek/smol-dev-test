const snake = require('./snake.js');
const score = require('./score.js');
const alerts = require('./alerts.js');

let gameState = "start";

const gameBoard = document.getElementById('game-board');

function startGame() {
    gameState = "playing";
    snake.init();
    score.init();
    alerts.sendAlert('gameStart');
}

function endGame() {
    gameState = "game over";
    alerts.sendAlert('gameOver');
}

function updateGame() {
    if (gameState === "playing") {
        snake.moveSnake();
        if (snake.checkCollision()) {
            endGame();
        }
        if (snake.checkFood()) {
            snake.addSegment();
            score.updateScore();
        }
    }
}

gameBoard.addEventListener('keydown', function(e) {
    if (gameState === "start" && e.keyCode === 32) {
        startGame();
    }
});

setInterval(updateGame, 100);

module.exports = {
    startGame,
    endGame
};