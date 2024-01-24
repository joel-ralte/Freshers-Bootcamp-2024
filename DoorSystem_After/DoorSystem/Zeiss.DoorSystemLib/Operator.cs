using System;
using System.Reflection;

namespace Zeiss.DoorSystemLib
{
    public class Operator
    {
        public SimpleDoor door;

        public Operator(object door)
        {
            Type type = door.GetType();

            if(type ==  typeof(SimpleDoor)) 
            {
                this.door = (SimpleDoor)door;
            }
            if(type == typeof(SmartDoor))
            {
                this.door = (SmartDoor)door;
            }
        }
        public void OpenDoor()
        {
            door.Open();
        }
        public void CloseDoor()
        {
            door.Close();
        }
    }
}
