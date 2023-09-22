using System;
using System.Collections.Generic;

namespace RicardoRalha.Core.EventDispatcher
{
    public static class EventDispatcher
    {
        private static readonly Dictionary<Type, Dictionary<int, object>> Subscriptions = new();

        public static void Publish<T>(T obj)
        {
            if (!Subscriptions.TryGetValue(typeof(T), out var dictCallbacks))
            {
                throw new EventNotPublishedException($"Publication of event of type {typeof(T)} failed. Try to subscribe before publishing event.");
            }

            foreach (var (hash, callback) in dictCallbacks)
            {
                Action<T> castedCallback = (Action<T>)callback;
                castedCallback(obj);
            }
        }

        public static void AddSubscriber<T>(Action<T> callback)
        {
            Type argumentType = typeof(T);
            int callbackHash = callback.GetHashCode();

            if (!Subscriptions.TryGetValue(argumentType, out var dictCallbacks))
            {
                Subscriptions.Add(argumentType, new Dictionary<int, object>() { { callbackHash, callback } });
                return;
            }
            
            dictCallbacks.Add(callbackHash, callback);
        }

        public static void RemoveSubscriber<T>(Action<T> callback)
        {
            Type argumentType = typeof(T);
            int callbackHash = callback.GetHashCode();

            if (!Subscriptions.TryGetValue(argumentType, out var dictCallbacks))
            {
                throw new EventNotRemovedException($"Removal of event of type {typeof(T)} failed. Try to subscribe before removing event.");
            }

            dictCallbacks.Remove(callbackHash);

            if (dictCallbacks.Count == 0)
            {
                Subscriptions.Remove(argumentType);
            }
        }
    }
}
