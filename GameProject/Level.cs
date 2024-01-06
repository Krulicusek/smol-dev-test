using System;

namespace GameProject
{
    public class Level
    {
        private int levelNumber;
        private Player player;
        private Enemy enemy;

        public Level(int levelNumber, Player player, Enemy enemy)
        {
            this.levelNumber = levelNumber;
            this.player = player;
            this.enemy = enemy;
        }

        public void StartLevel()
        {
            Console.WriteLine($"Starting level {levelNumber}");

            player.Start();
            enemy.Start();

            while (player.IsAlive && enemy.IsAlive)
            {
                player.Attack(enemy);
                if (enemy.IsAlive)
                {
                    enemy.Attack(player);
                }
            }

            if (player.IsAlive)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Enemy won!");
            }
        }
    }
}