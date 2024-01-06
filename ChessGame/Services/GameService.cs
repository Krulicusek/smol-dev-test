using System;
using System.Threading.Tasks;
using ChessGame.Models;
using Microsoft.AspNetCore.SignalR;

namespace ChessGame.Services
{
    public class GameService
    {
        private readonly IHubContext<GameHub> _hubContext;

        public GameService(IHubContext<GameHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public async Task StartGame(Player player1, Player player2)
        {
            var game = new ChessBoard(player1, player2);
            await _hubContext.Clients.All.SendAsync("GameStarted", game);
        }

        public async Task MakeMove(Player player, ChessPiece piece, int newX, int newY)
        {
            var game = new ChessBoard(player, piece, newX, newY);
            await _hubContext.Clients.All.SendAsync("MoveMade", game);
        }

        public async Task EndGame(Player winner)
        {
            await _hubContext.Clients.All.SendAsync("GameEnded", winner);
        }
    }
}