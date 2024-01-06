const http = require('http');
const fs = require('fs');
const path = require('path');
const io = require('socket.io')(http);

let gameState = "start";
let players = {};

io.on('connection', (socket) => {
    console.log('A user connected');

    socket.on('playerJoined', (player) => {
        players[player.id] = player;
        console.log(`Player ${player.id} joined the game`);
    });

    socket.on('gameStart', () => {
        gameState = "playing";
        console.log('Game started');
    });

    socket.on('gameOver', () => {
        gameState = "game over";
        console.log('Game over');
    });

    socket.on('scoreUpdate', (score) => {
        players[socket.id].score = score;
        console.log(`Player ${socket.id} score: ${score}`);
    });

    socket.on('disconnect', () => {
        delete players[socket.id];
        console.log('A user disconnected');
    });
});

http.createServer((req, res) => {
    const filePath = path.join(__dirname, req.url === '/' ? 'index.html' : req.url);
    const extname = String(path.extname(filePath)).toLowerCase();

    const mimeTypes = {
        '.html': 'text/html',
        '.js': 'text/javascript',
        '.css': 'text/css',
    };

    const contentType = mimeTypes[extname] || 'application/octet-stream';

    fs.readFile(filePath, (error, content) => {
        if (!error) {
            res.writeHead(200, { 'Content-Type': contentType });
            res.end(content, 'utf-8');
        } else {
            res.writeHead(500);
            res.end('Sorry, check with the site admin for error: '+error.code+' ..\n');
        }
    });
}).listen(8080);

console.log('Server running at http://127.0.0.1:8080/');