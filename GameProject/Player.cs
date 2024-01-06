```csharp
using System;

namespace GameProject
{
    public class Player
    {
        public int Health { get; set; }
        public int Score { get; set; }

        public Player()
        {
            Health = 100;
            Score = 0;
        }

        public void Move(string direction)
        {
            // Add movement logic here
        }

        public void Attack(Enemy enemy)
        {
            // Add attack logic here
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health <= 0)
            {
                // Add game over logic here
            }
        }
    }
}
```