function sendAlert(message) {
    alert(message);
}

document.addEventListener('keydown', function(event) {
    if(gameState === "start" && event.keyCode !== 0) {
        sendAlert('Press any key to start');
        startGame();
    }
});

document.addEventListener('gameOver', function() {
    sendAlert('Game Over! Your score is: ' + score);
});

document.addEventListener('playerJoined', function() {
    sendAlert('A new player has joined the game');
});

document.addEventListener('scoreUpdate', function() {
    sendAlert('Your score is now: ' + score);
});