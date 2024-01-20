using System;
using System.Collections.Generic;
using Entities;

namespace Managers
{
    public class EventManager
    {
        private List<GameEvent> _events;
        private Player _player;

        public EventManager(Player player)
        {
            _player = player;
            _events = new List<GameEvent>();
        }

        public void AddEvent(GameEvent gameEvent)
        {
            _events.Add(gameEvent);
        }

        public void Update(GameTime gameTime)
        {
            for (int i = _events.Count - 1; i >= 0; i--)
            {
                _events[i].Update(gameTime);
                if (_events[i].IsTriggered)
                {
                    HandleEvent(_events[i]);
                    _events.RemoveAt(i);
                }
            }
        }

        private void HandleEvent(GameEvent gameEvent)
        {
            switch (gameEvent.EventTriggered)
            {
                case "PowerUp":
                    _player.ApplyPowerUp(gameEvent.PowerUp);
                    break;
                case "EnemyWave":
                    GameManager.Instance.SpawnEnemyWave(gameEvent.EnemyWave);
                    break;
                default:
                    throw new Exception("Unknown event triggered");
            }
        }
    }
}