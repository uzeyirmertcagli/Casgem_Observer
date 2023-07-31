﻿using Casgem_Observer.DAL;

namespace Casgem_Observer.ObserverPattern
{
    public class ObserverObject
    {
        private readonly List<IObserver> _observers;

        public ObserverObject()
        {
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObserver(AppUser appuser)
        {
            _observers.ForEach(x =>
            {
                x.CreateNewUser(appuser);
            });
        }


    }
}
