using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Forms;
using BroadcasterExample.Interfaces;

namespace BroadcasterExample.Classes
{
    public class Broadcaster
    {
        private readonly Collection<IListener> _listeners = new Collection<IListener>();

     
        [DebuggerStepThrough()]
        public void Broadcast(Person person, Form sender)
        {
            foreach (IListener listener in _listeners)
            {
                listener.OnListen(person, sender);
            }
        }

        public void AddListener(IListener listener)
        {
            _listeners.Add(listener);
        }

        public void RemoveListener(IListener listener)
        {

            for (int index = 0; index < _listeners.Count; index++)
            {
                if (_listeners[index].Equals(listener))
                {
                    _listeners.Remove(_listeners[index]);
                }
            }
        }
    }
}