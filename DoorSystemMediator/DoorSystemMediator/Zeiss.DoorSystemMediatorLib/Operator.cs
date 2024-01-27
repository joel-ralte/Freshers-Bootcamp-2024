using System;

namespace Zeiss.DoorSystemMediatorLib
{
    public class Operator : BaseComponent
    {
        private SimpleDoor door;

        public Operator(object door, IMediator eventAggregator) : base(eventAggregator)
        {
            Type type = door.GetType();

            if (type == typeof(SimpleDoor))
            {
                this.door = door as SimpleDoor;
            }
            if (type == typeof(SmartDoor))
            {
                this.door = door as SmartDoor;
            }
        }

        public void OpenDoor()
        {
            Console.WriteLine("Operator Opened Door");
            door.Open();
            eventAggregator.Publish(new DoorStateChangedEvent(door.State));
        }

        public void CloseDoor()
        {
            Console.WriteLine("Operator Closed Door");
            door.Close();
            eventAggregator.Publish(new DoorStateChangedEvent(door.State));
        }
    }
}
