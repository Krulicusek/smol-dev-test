using System;
using Microsoft.Xna.Framework;

namespace TowerDefense.Managers
{
    public class SpeedManager
    {
        private const float NormalSpeed = 1.0f;
        private const float FastForwardSpeed = 2.0f;
        private float currentSpeed;

        public SpeedManager()
        {
            currentSpeed = NormalSpeed;
        }

        public void Update(GameTime gameTime)
        {
            // Update game speed based on user input
            if (GameMain.Instance.InputManager.IsFastForwardPressed())
            {
                FastForward();
            }
            else
            {
                NormalSpeed();
            }
        }

        public void FastForward()
        {
            currentSpeed = FastForwardSpeed;
        }

        public void NormalSpeed()
        {
            currentSpeed = NormalSpeed;
        }

        public float GetCurrentSpeed()
        {
            return currentSpeed;
        }
    }
}