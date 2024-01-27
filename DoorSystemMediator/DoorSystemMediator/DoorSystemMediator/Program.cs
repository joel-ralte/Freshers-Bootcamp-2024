using System;
using Zeiss.DoorSystemMediatorLib;

namespace DoorSystemMediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EventAggregator eventAggregator = EventAggregator.GetInstance();

            SimpleDoor simpleDoor = new SimpleDoor(eventAggregator);
            Operator simpleDoorOperator = new Operator(simpleDoor, eventAggregator);

            SmartDoor smartDoorObj = new SmartDoor(eventAggregator);
            Operator smartDoorOperator = new Operator(smartDoorObj, eventAggregator);

            Buzzer buzzer = new Buzzer(eventAggregator);
            Pager pager = new Pager(eventAggregator);
            AutoClose autoClose = new AutoClose(eventAggregator);

            eventAggregator.Subscribe<DoorStateChangedEvent>(buzzer.HandleDoorStateChanged);
            eventAggregator.Subscribe<DoorStateChangedEvent>(pager.HandleDoorStateChanged);
            eventAggregator.Subscribe<DoorStateChangedEvent>(autoClose.HandleDoorStateChanged);
            eventAggregator.Subscribe<DoorStateChangedEvent>(smartDoorObj.HandleDoorStateChanged);

            smartDoorObj.TimerLimit = 2;
            smartDoorObj.Open();
            Console.ReadLine();

            eventAggregator.Unsubscribe<DoorStateChangedEvent>(buzzer.HandleDoorStateChanged);
            eventAggregator.Unsubscribe<DoorStateChangedEvent>(pager.HandleDoorStateChanged);

            smartDoorObj.TimerLimit = 3;
            smartDoorObj.Open();
            Console.ReadLine();
        }
    }
}
