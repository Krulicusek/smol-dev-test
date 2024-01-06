```csharp
using System.Collections.Generic;

namespace ChessGame.Models
{
    public class ChessBoard
    {
        public ChessPiece[,] Board { get; set; }
        public Player CurrentPlayer { get; set; }
        public bool GameOver { get; set; }
        public Player Winner { get; set; }

        public ChessBoard()
        {
            Board = new ChessPiece[8, 8];
            CurrentPlayer = null;
            GameOver = false;
            Winner = null;
        }

        public void InitializeBoard(List<Player> players)
        {
            // Initialize the board with chess pieces for each player
            // This is a placeholder and needs to be replaced with actual game logic
        }

        public bool MakeMove(Player player, ChessPiece piece, int newX, int newY)
        {
            // Make a move with the given chess piece to the new position
            // This is a placeholder and needs to be replaced with actual game logic
            return true;
        }

        public bool CheckGameOver()
        {
            // Check if the game is over
            // This is a placeholder and needs to be replaced with actual game logic
            return GameOver;
        }
    }
}
```