using UnityEngine.Events;

namespace MashBoxBridge.Common.Interfaces.GameEvent
{
    public interface IGameEvent
    {
        void Raise();
        UnityEvent OnRaise { get; set; }
    }
}