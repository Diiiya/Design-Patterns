using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class Subject
    {
        private List<Observer> observers = new List<Observer>();
        int state;

        public int GetState()
        {
            return this.state;
        }

        public void SetState(int state)
        {
            this.state = state;
            NotifyAllObservers();
        }

        public void AddObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void NotifyAllObservers()
        {
            foreach (Observer observer in observers)
            {
                observer.Update();
            }
        }
    }
}
