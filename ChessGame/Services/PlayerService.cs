```csharp
using System;
using System.Collections.Generic;
using ChessGame.Models;

namespace ChessGame.Services
{
    public class PlayerService
    {
        private readonly List<Player> _players;

        public PlayerService()
        {
            _players = new List<Player>();
        }

        public Player CreatePlayer(string name)
        {
            var player = new Player
            {
                Id = Guid.NewGuid(),
                Name = name
            };

            _players.Add(player);

            return player;
        }

        public Player GetPlayer(Guid id)
        {
            return _players.Find(player => player.Id == id);
        }

        public void RemovePlayer(Guid id)
        {
            var player = GetPlayer(id);
            if (player != null)
            {
                _players.Remove(player);
            }
        }
    }
}
```