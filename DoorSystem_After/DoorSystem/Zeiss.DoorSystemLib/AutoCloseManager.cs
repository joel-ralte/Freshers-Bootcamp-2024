using System;

namespace Zeiss.DoorSystemLib
{
    public class AutoCloseManager
    {
        public SmartDoor smartDoorObj;
        public AutoCloseManager(SmartDoor inputSmartDoorObj)
        {
            smartDoorObj = inputSmartDoorObj;
        }
        public void Notify()
        {
            Console.WriteLine("Autoclose Alerted");
            smartDoorObj.Close();
        }
    }
}
