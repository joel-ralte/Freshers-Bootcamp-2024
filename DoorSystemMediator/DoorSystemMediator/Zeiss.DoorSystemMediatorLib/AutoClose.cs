using System;

namespace Zeiss.DoorSystemMediatorLib
{
    public class AutoClose : BaseComponent
    {
        public AutoClose(IMediator eventAggregator) : base(eventAggregator) { }

        public void HandleDoorStateChanged(DoorStateChangedEvent doorStateChangedEvent)
        {
            if (doorStateChangedEvent.NewState == DoorState.Opened)
            {
                Console.WriteLine($"Autoclose Alerted: Closing Door..");

                eventAggregator.Publish(new DoorStateChangedEvent(DoorState.Closed));
            }
        }
    }
}
