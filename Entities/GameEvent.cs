using System;

namespace TowerDefense.Entities
{
    public class GameEvent
    {
        public string EventName { get; private set; }
        public Action EventAction { get; private set; }
        public bool IsTriggered { get; private set; }

        public GameEvent(string eventName, Action eventAction)
        {
            EventName = eventName;
            EventAction = eventAction;
            IsTriggered = false;
        }

        public void TriggerEvent()
        {
            if (!IsTriggered)
            {
                EventAction.Invoke();
                IsTriggered = true;
            }
        }

        public void ResetEvent()
        {
            IsTriggered = false;
        }
    }
}