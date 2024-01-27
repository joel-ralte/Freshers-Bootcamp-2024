using System;

namespace Zeiss.DoorSystemMediatorLib
{
    public class Pager : BaseComponent
    {
        public Pager(IMediator eventAggregator) : base(eventAggregator) { }
        public void HandleDoorStateChanged(DoorStateChangedEvent doorStateChangedEvent)
        {
            if (doorStateChangedEvent.NewState == DoorState.Opened)
            {
                Console.WriteLine($"Pager Alerted: Door opened beyond threshold");
            }
        }
    }
}
