using System.Collections.Generic;

namespace SnakeGame.Models
{
    public class Snake
    {
        public List<(int, int)> Body { get; set; }
        public (int, int) Direction { get; set; }

        public Snake()
        {
            Body = new List<(int, int)>
            {
                (10, 10),
                (10, 11),
                (10, 12),
            };

            Direction = (0, -1);
        }

        public void Move()
        {
            var head = (Body[0].Item1 + Direction.Item1, Body[0].Item2 + Direction.Item2);
            Body.Insert(0, head);
            Body.RemoveAt(Body.Count - 1);
        }

        public void Grow()
        {
            var tail = Body[Body.Count - 1];
            Body.Add(tail);
        }

        public bool CheckSelfCollision()
        {
            var head = Body[0];
            for (int i = 1; i < Body.Count; i++)
            {
                if (Body[i] == head)
                {
                    return true;
                }
            }

            return false;
        }
    }
}