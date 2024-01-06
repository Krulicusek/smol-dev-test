```csharp
using System;

namespace ChessGame.Models
{
    public class Player
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsWhite { get; set; }
        public bool IsMyTurn { get; set; }
    }
}
```