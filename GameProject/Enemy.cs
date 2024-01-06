```csharp
using System;

namespace GameProject
{
    public class Enemy
    {
        public int Health { get; set; }
        public int Damage { get; set; }

        public Enemy(int health, int damage)
        {
            Health = health;
            Damage = damage;
        }

        public void Attack(Player player)
        {
            player.Health -= Damage;
            Console.WriteLine("Enemy attacks Player. Player's health is now " + player.Health);
        }
    }
}
```