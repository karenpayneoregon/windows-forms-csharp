using System.Windows.Forms;
using BroadcasterExample.Classes;

namespace BroadcasterExample.Interfaces
{
    public interface IListener
    {
        void OnListen(Person person, Form Type);
    }
}