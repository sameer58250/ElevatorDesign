using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorDesign
{
    interface ILiftFloor
    {
        void SelectFloorInLift(Floor floor);
        void DeselectFloorInLift(Floor floor);
    }
}
