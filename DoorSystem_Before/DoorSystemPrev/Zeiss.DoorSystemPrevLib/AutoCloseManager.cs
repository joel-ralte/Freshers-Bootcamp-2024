using System;

namespace Zeiss.DoorSystemPrevLib
{
    public class AutoCloseManager
    {
        public Operator operatorObj;
        public AutoCloseManager(Operator inputOperatorObj)
        {
            operatorObj = inputOperatorObj;
        }
        public void Notify()
        {
            Console.WriteLine("Autoclose Alerted");
            operatorObj.CloseDoor();
        }
    }
}
