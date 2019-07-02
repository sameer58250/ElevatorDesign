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
            if (Lift.IsStopped)
                Lift.IsDoorOpen = true; ;
            Thread.Sleep(1000);
        }

        public void CloseDoor()
        {
            Lift.IsDoorOpen = false;
            for (int i = 0; i < Lift.FloorList.Count; i++)
            {
                if (Lift.IsGoingUp && Lift.FloorList[i].FloorNo > Lift.CurrentFloor.FloorNo && Lift.FloorList[i].IsSelected)
                {
                    Lift.CurrentFloor=Lift.FloorList[i];
                    Lift.GoUp();
                    break;
                }
                else if (Lift.IsGoingDown && Lift.FloorList[i].FloorNo < Lift.CurrentFloor.FloorNo && Lift.FloorList[i].IsSelected)
                {
                    Lift.CurrentFloor = Lift.FloorList[i];
                    Lift.GoDown();
                    break;
                }
                else
                {
                    if (Lift.FloorList[i].IsSelected && Lift.FloorList[i].FloorNo > Lift.CurrentFloor.FloorNo)
                    {
                        Lift.CurrentFloor = Lift.FloorList[i];
                        Lift.GoUp();
                        break;
                    }
                    else if (Lift.FloorList[i].IsSelected && Lift.FloorList[i].FloorNo < Lift.CurrentFloor.FloorNo)
                    {
                        Lift.CurrentFloor = Lift.FloorList[i];
                        Lift.GoDown();
                        break;
                    }
                    else
                        Lift.Stop(Lift.CurrentFloor);
                }
            }
        }
    }
}
