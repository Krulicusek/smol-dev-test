using System;

namespace GameProject
{
    public class Game
    {
        private Player player;
        private Enemy enemy;
        private Level level;

        public Game()
        {
            player = new Player();
            enemy = new Enemy();
            level = new Level();
        }

        public void Start()
        {
            while (true)
            {
                player.Move();
                enemy.Move();
                level.Update();

                if (player.IsDead || enemy.IsDead)
                {
                    break;
                }
            }
        }
    }
}