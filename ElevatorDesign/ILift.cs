using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorDesign
{
    interface ILift
    {
        void SelectFloor(Floor floor);
        void OpenDoor();
        void CloseDoor();
    }
}
