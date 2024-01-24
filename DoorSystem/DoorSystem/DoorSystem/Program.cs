using System;
using Zeiss.DoorSystemLib;

namespace DoorSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleDoor simpleDoor = new SimpleDoor();
            Operator simpleDoorOperator = new Operator(simpleDoor);

            SmartDoor smartDoorObj = new SmartDoor();
            Operator smartDoorOperator = new Operator(smartDoorObj);

            BuzzerManager buzzer = new BuzzerManager();
            PagerManager pager = new PagerManager();
            AutoCloseManager autoClose = new AutoCloseManager(smartDoorObj);

            Action buzzerObserver = new Action(buzzer.Notify);
            Action pagerObserver = new Action(pager.Notify);
            Action autoCloseObserver = new Action(autoClose.Notify);

            smartDoorObj.OnAlert += buzzerObserver + pagerObserver + autoCloseObserver;

            smartDoorObj.TimerLimit = 3;
            smartDoorObj.Open();
            Console.ReadLine();

            smartDoorObj.OnAlert -= buzzerObserver;
            smartDoorObj.OnAlert -= autoCloseObserver;

            smartDoorObj.TimerLimit = 2;
            smartDoorObj.Open();
            Console.ReadLine();
        } 
    }
}
