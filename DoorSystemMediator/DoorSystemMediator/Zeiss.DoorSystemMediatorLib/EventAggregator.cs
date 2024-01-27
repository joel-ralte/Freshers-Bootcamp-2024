using System;
using System.Collections.Generic;

namespace Zeiss.DoorSystemMediatorLib
{
    public sealed class EventAggregator : IMediator
    {
        public static readonly EventAggregator instance = new EventAggregator();

        private EventAggregator() { }

        public static EventAggregator GetInstance()
        {
            return instance;
        }

        private Dictionary<Type, List<Action<object>>> subscribers = new Dictionary<Type, List<Action<object>>>();
        private Dictionary<Type, List<object>> subscriberReferences = new Dictionary<Type, List<object>>();

        public void Subscribe<TEvent>(Action<TEvent> action)
        {
            Type eventType = typeof(TEvent);
            if (!subscribers.ContainsKey(eventType))
            {
                subscribers[eventType] = new List<Action<object>>();
                subscriberReferences[eventType] = new List<object>();
            }

            Action<object> wrappedAction = obj => action((TEvent)obj);
            subscribers[eventType].Add(wrappedAction);
            subscriberReferences[eventType].Add(action);
        }

        public void Unsubscribe<TEvent>(Action<TEvent> action)
        {
            Type eventType = typeof(TEvent);
            if (subscribers.ContainsKey(eventType))
            {
                int index = subscriberReferences[eventType].IndexOf(action);
                if (index != -1)
                {
                    subscribers[eventType].RemoveAt(index);
                    subscriberReferences[eventType].RemoveAt(index);
                }
            }
        }

        public void Publish<TEvent>(TEvent eventToPublish)
        {
            Type eventType = typeof(TEvent);
            if (subscribers.ContainsKey(eventType))
            {
                foreach (var subscriber in subscribers[eventType])
                {
                    subscriber.Invoke(eventToPublish);
                }
            }
        }
    }
}
