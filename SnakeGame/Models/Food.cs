using System;

namespace SnakeGame.Models
{
    public class Food
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsEaten { get; set; }

        public Food(int x, int y)
        {
            X = x;
            Y = y;
            IsEaten = false;
        }

        public void GenerateNewPosition(Random random, int boardWidth, int boardHeight)
        {
            X = random.Next(0, boardWidth);
            Y = random.Next(0, boardHeight);
            IsEaten = false;
        }
    }
}