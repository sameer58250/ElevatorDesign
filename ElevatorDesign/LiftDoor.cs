using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ElevatorDesign
{
    public class LiftDoor:ILiftDoor
    {
        ILiftRun Lift;
        public LiftDoor(ILiftRun lift)
        {
            Lift = lift;
        }
        public void OpenDoor()
        {
            if (Lift.IsStopped())
                Lift.OpenDoor();
            Thread.Sleep(1000);
        }

        public void CloseDoor()
        {
            Lift.CloseDoor();
            for (int i = 0; i < Lift.getFloorList().Count; i++)
            {
                if (Lift.IsGoingUp() && Lift.getFloorList()[i].FloorNo > Lift.CurrentFloor().FloorNo && Lift.getFloorList()[i].IsSelected)
                {
                    Lift.setCurrentFloor(Lift.getFloorList()[i]);
                    Lift.GoUp();
                    break;
                }
                else if (Lift.IsGoingDown() && Lift.getFloorList()[i].FloorNo < Lift.CurrentFloor().FloorNo && Lift.getFloorList()[i].IsSelected)
                {
                    Lift.setCurrentFloor(Lift.getFloorList()[i]);
                    Lift.GoDown();
                    break;
                }
                else
                {
                    if (Lift.getFloorList()[i].IsSelected && Lift.getFloorList()[i].FloorNo > Lift.CurrentFloor().FloorNo)
                    {
                        Lift.setCurrentFloor(Lift.getFloorList()[i]);
                        Lift.GoUp();
                        break;
                    }
                    else if (Lift.getFloorList()[i].IsSelected && Lift.getFloorList()[i].FloorNo < Lift.CurrentFloor().FloorNo)
                    {
                        Lift.setCurrentFloor(Lift.getFloorList()[i]);
                        Lift.GoDown();
                        break;
                    }
                    else
                        Lift.Stop(Lift.CurrentFloor());
                }
            }
        }
    }
}
