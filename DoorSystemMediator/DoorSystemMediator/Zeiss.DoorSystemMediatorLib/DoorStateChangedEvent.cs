using System;

namespace Zeiss.DoorSystemMediatorLib
{
    public class DoorStateChangedEvent
    {
        public DoorState NewState { get; }

        public DoorStateChangedEvent(DoorState newState)
        {
            NewState = newState;
        }
    }
}
