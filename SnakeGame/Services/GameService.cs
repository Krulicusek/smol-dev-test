using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SnakeGame.Models;

namespace SnakeGame.Services
{
    public class GameService
    {
        private Snake _snake;
        private Food _food;

        public GameService()
        {
            _snake = new Snake();
            _food = new Food();
        }

        public void StartGame()
        {
            _snake.Initialize();
            _food.GenerateFood();
        }

        public void Move()
        {
            _snake.Move();

            if (_snake.HeadPosition == _food.Position)
            {
                _snake.Eat();
                _food.GenerateFood();
            }

            if (_snake.IsCollidingWithSelf())
            {
                EndGame();
            }
        }

        public void ChangeDirection(Direction direction)
        {
            _snake.ChangeDirection(direction);
        }

        public void PauseGame()
        {
            // Pause game logic
        }

        public void EndGame()
        {
            // End game logic
        }
    }
}