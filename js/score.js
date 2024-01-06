let score = 0;

function updateScore() {
    score++;
    document.getElementById('score-board').innerText = `Score: ${score}`;
}

function resetScore() {
    score = 0;
    document.getElementById('score-board').innerText = `Score: ${score}`;
}

module.exports = {
    score,
    updateScore,
    resetScore
};