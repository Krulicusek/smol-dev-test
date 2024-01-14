using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class Minion
{
    public Vector2 Position { get; set; }
    public int Health { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public Texture2D MinionTexture { get; set; }
    public bool IsAlive { get; set; }

    public Minion(Texture2D texture)
    {
        MinionTexture = texture;
        Health = 100;
        Attack = 10;
        Defense = 5;
        IsAlive = true;
    }

    public void Move(Vector2 newPosition)
    {
        Position = newPosition;
    }

    public void AttackEnemy(Base enemyBase)
    {
        if (Vector2.Distance(Position, enemyBase.Position) <= Attack)
        {
            enemyBase.Health -= Attack;
        }
    }

    public void Defend(Base playerBase)
    {
        if (Vector2.Distance(Position, playerBase.Position) <= Defense)
        {
            Health += Defense;
        }
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        if (IsAlive)
        {
            spriteBatch.Draw(MinionTexture, Position, Color.White);
        }
    }
}