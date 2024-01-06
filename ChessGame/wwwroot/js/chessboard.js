var connection = new signalR.HubConnectionBuilder().withUrl("/gameHub").build();

var board,
    game = new Chess();

var onDragStart = function (source, piece, position, orientation) {
    if (game.in_checkmate() === true || game.in_draw() === true ||
        piece.search(/^b/) !== -1) {
        return false;
    }
};

var onDrop = function (source, target) {
    var move = game.move({
        from: source,
        to: target,
        promotion: 'q'
    });

    if (move === null) {
        return 'snapback';
    }

    connection.invoke("MoveMade", source, target).catch(function (err) {
        return console.error(err.toString());
    });
};

var onSnapEnd = function () {
    board.position(game.fen());
};

var cfg = {
    draggable: true,
    position: 'start',
    onDragStart: onDragStart,
    onDrop: onDrop,
    onSnapEnd: onSnapEnd
};

board = ChessBoard('chessboard', cfg);

connection.on("MoveMade", function (source, target) {
    game.move({
        from: source,
        to: target,
        promotion: 'q'
    });

    board.position(game.fen());
});

connection.start().catch(function (err) {
    return console.error(err.toString());
});