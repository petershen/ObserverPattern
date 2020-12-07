using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.AbstractParties
{
    public abstract class Issuer
    {
        private List<Observer> _observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (Observer obsvr in _observers)
            {
                obsvr.Update();
            }
        }

    }
}
