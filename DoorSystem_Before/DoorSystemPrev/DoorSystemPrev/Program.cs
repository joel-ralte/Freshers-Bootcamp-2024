using System;
using Zeiss.DoorSystemPrevLib;

namespace DoorSystemPrev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleDoor simpleDoor = new SimpleDoor();
            Operator simpleDoorOperator = new Operator(simpleDoor);

            SmartDoor smartDoorObj = new SmartDoor();
            Operator smartDoorOperator = new Operator(smartDoorObj);

            SmartDoor smartDoorConverted = new SmartDoor();
            smartDoorConverted = simpleDoor.ConvertToSmartDoor(simpleDoor);

            BuzzerManager buzzer = new BuzzerManager();
            PagerManager pager = new PagerManager();
            AutoCloseManager autoClose = new AutoCloseManager(smartDoorOperator);

            Action buzzerObserver = new Action(buzzer.Notify);
            Action pagerObserver = new Action(pager.Notify);
            Action autoCloseObserver = new Action(autoClose.Notify);

            smartDoorObj.OnAlert += buzzerObserver + pagerObserver + autoCloseObserver;

            smartDoorObj.SetTimer(5);
            Console.ReadLine();

            smartDoorObj.OnAlert -= buzzerObserver;
            smartDoorObj.OnAlert -= autoCloseObserver;

            smartDoorObj.SetTimer(3);
            Console.ReadLine();
        }
    }
}
