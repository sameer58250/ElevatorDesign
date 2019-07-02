using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorDesign
{
    public class LiftFloor:ILiftFloor
    {
        ILiftRun Lift;

        public LiftFloor(ILiftRun lift)
        {
            Lift = lift;
        }

        public void SelectFloorInLift(Floor floor){
            for (int i = 0; i < Lift.getFloorList().Count; i++)
            {
                if (floor.FloorNo == Lift.getFloorList()[i].FloorNo && Lift.getFloorList()[i].IsActive)
                    Lift.getFloorList()[i].IsSelected = true;
            }
        }

        public void DeselectFloorInLift(Floor floor){
            for (int i = 0; i < Lift.getFloorList().Count; i++)
            {
                if (floor.FloorNo == Lift.getFloorList()[i].FloorNo && Lift.getFloorList()[i].IsActive && Lift.getFloorList()[i].IsSelected)
                    Lift.getFloorList()[i].IsSelected = false;
            }
        }
    }
}
