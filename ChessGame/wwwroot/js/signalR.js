let connection = new signalR.HubConnectionBuilder()
    .withUrl("/gameHub")
    .build();

connection.on("GameStarted", function () {
    console.log("Game has started");
});

connection.on("MoveMade", function (player, move) {
    console.log(player + " made a move: " + move);
});

connection.on("GameEnded", function (winner) {
    console.log("Game has ended. Winner: " + winner);
});

connection.start().catch(function (err) {
    return console.error(err.toString());
});

function startGame() {
    connection.invoke("StartGame").catch(function (err) {
        return console.error(err.toString());
    });
}

function makeMove(move) {
    connection.invoke("MakeMove", move).catch(function (err) {
        return console.error(err.toString());
    });
}

function endGame() {
    connection.invoke("EndGame").catch(function (err) {
        return console.error(err.toString());
    });
}